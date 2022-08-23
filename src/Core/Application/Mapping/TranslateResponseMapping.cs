using System;
using Application.Features.Commands.TranslateResponse;
using AutoMapper;

namespace Application.Mapping
{
	public class TranslateResponseMapping : Profile
	{
		public TranslateResponseMapping()
		{
			CreateMap<Domain.Entities.TranslateResponse, CreateTranslateResponseCommand>().ReverseMap();
			CreateMap<Domain.Entities.TranslateResponse, Dtos.TranslateRequestViewDto>().ReverseMap();
		}
	}
}

