using System;
namespace Domain.Common
{
	public class BaseEntity
	{
		public Guid Id { get; set; }

		public DateTime CreatedDate { get; set; }

		public BaseEntity()
		{
			CreatedDate = DateTime.UtcNow;
		}
	}
}

