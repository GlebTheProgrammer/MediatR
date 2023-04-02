using Application.Abstractions.Data;
using Application.Abstractions.Messaging;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Application.Webinars.Queries.GetWebinarById
{
    internal sealed class GetWebinarQueryHandler : IQueryHandler<GetWebinarByIdQuery, WebinarResponse>
    {
        private readonly IApplicationDbContext _dbContext;

        public GetWebinarQueryHandler(IApplicationDbContext dbContext) => _dbContext = dbContext;

        public async Task<WebinarResponse> Handle(
            GetWebinarByIdQuery request,
            CancellationToken cancellationToken)
        {
            var webinars = await _dbContext
                .Database
                .SqlQuery<WebinarResponse>($@"
                    SELECT w.Id AS Id, w.Name AS Name, w.SheduledOn AS SheduledOn
                    FROM Webinars AS w
                    WHERE w.Id = {request.WebinarId}")
                .ToListAsync(cancellationToken);

            if (webinars.Count is 0)
            {
                throw new WebinarNotFoundException(request.WebinarId);
            }

            return webinars.First();
        }
    }
}
