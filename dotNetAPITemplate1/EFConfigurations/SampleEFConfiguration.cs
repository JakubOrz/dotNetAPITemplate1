using dotNetAPITemplate1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace dotNetAPITemplate1.EFConfigurations
{
    public class SampleEfConfiguration : IEntityTypeConfiguration<SampleOne>
    {
        public void Configure(EntityTypeBuilder<SampleOne> builder)
        {
            builder.HasKey(sample => sample.IdSample);
            builder.Property(sample => sample.Pole).IsRequired();
            
        }
    }
}