using System;
using Application.Interfaces.Repository;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
	public class TranslateRequestRepository:GenericRepository<TranslateRequest>,ITranslateRequestRepository
	{
		public TranslateRequestRepository(ApplicationDbContext context):base(context)
		{

		}
	}
}

