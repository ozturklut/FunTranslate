using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
	public class RequestUrlConfiguration : IEntityTypeConfiguration<RequestUrl>
	{
        public void Configure(EntityTypeBuilder<RequestUrl> builder)
        {
            builder.HasOne(x => x.TranslateRequest).WithOne(x => x.RequestUrl);
        }
    }
}

