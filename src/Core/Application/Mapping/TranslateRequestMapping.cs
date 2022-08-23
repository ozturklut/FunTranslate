using System;
using Application.Features.Commands.TranslateRequest;
using AutoMapper;

namespace Application.Mapping
{
	public class TranslateRequestMapping : Profile
	{
		public TranslateRequestMapping()
		{
			CreateMap<Domain.Entities.TranslateRequest, CreateTranslateRequestCommand>().ReverseMap();
			CreateMap<Domain.Entities.TranslateRequest, Dtos.TranslateRequestViewDto>().ReverseMap();
		}
	}
}

