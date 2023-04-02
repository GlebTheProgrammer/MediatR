namespace Application.Webinars.Queries.GetWebinarById
{
    public sealed class WebinarResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime SheduledOn { get; set; }
    }
}
