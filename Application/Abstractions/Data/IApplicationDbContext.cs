using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Application.Abstractions.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Webinar> Webinars { get; set; }

        DatabaseFacade Database { get; }
    }
}
