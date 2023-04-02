using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal sealed class WebinarConfiguration : IEntityTypeConfiguration<Webinar>
    {
        public void Configure(EntityTypeBuilder<Webinar> builder)
        {
            //builder.HasKey(webinar => webinar.Id);

            //builder.OwnsOne(webinar => webinar.Name, webinarNameBuilder =>
            //{
            //    webinarNameBuilder.WithOwner();

            //    webinarNameBuilder.Property<string>()

            //})
        }
    }
}
