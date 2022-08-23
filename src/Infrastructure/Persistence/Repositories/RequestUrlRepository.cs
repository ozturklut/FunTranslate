using System;
using Application.Interfaces.Repository;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
	public class RequestUrlRepository : GenericRepository<RequestUrl> , IRequestUrlRepository
	{
		public RequestUrlRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}

