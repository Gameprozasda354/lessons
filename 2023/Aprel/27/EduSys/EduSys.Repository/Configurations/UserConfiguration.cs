using EduSys.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduSys.Repository.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(50);
            builder.Property(x => x.EmailAddress).IsRequired().HasMaxLength(255);
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Password).IsRequired().HasMaxLength(200);
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.CountryId).IsRequired();
            builder.ToTable("Users");

            builder.HasOne(x => x.Country).WithOne(x => x.User).HasForeignKey<User>(x => x.CountryId);
        }
    }
}
