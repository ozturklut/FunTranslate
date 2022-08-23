using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
	public class TranslateRequestConfiguration : IEntityTypeConfiguration<TranslateRequest>
	{

        public void Configure(EntityTypeBuilder<TranslateRequest> builder)
        {
            builder.HasOne(x => x.RequestUrl).WithOne(x => x.TranslateRequest);
        }
    }
}

