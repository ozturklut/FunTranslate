using System;
using Application.Interfaces.Repository;
using Domain.Entities;
using Persistence.Context;

namespace Persistence.Repositories
{
	public class TranslateResponseRepository : GenericRepository<TranslateResponse>,ITranslateResponseRepository
	{
		public TranslateResponseRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}

