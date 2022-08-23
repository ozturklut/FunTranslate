using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
	public class TranslateResponseConfiguration : IEntityTypeConfiguration<TranslateResponse>
	{
        public void Configure(EntityTypeBuilder<TranslateResponse> builder)
        {
            builder.HasOne(x => x.TranslateRequest).WithOne(x => x.TranslateResponse);
        }
    }
}

