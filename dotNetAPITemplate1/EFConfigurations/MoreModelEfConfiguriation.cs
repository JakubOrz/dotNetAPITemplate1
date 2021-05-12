using dotNetAPITemplate1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotNetAPITemplate1.EFConfigurations
{
    public class MoreModelEfConfiguriation : IEntityTypeConfiguration<SampleMore>
    {
        public void Configure(EntityTypeBuilder<SampleMore> builder)
        {
            builder.HasKey(model => model.MoreModelId);
            builder.Property(model => model.NazwaModelu).IsRequired();

            builder.HasOne(more => more.One)
                .WithMany(one => one.SampleMores)
                .HasForeignKey(more => more.IdOne);
        }
    }
}