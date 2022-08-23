using System;
using Application.Dtos;
using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Features.Queries.TranslateRequest
{
	public class GetAllTranslateRequestQuery : IRequest<ServiceResponse<List<TranslateRequestViewDto>>>
	{
        public class GetAllTranslateReuestQueryHandler : IRequestHandler<GetAllTranslateRequestQuery, ServiceResponse<List<TranslateRequestViewDto>>>
        {
            private readonly ITranslateRequestRepository _translateRequestRepository;
            private readonly IMapper _mapper;

            public GetAllTranslateReuestQueryHandler(IMapper mapper, ITranslateRequestRepository translateRequestRepository)
            {
                _mapper = mapper;
                _translateRequestRepository = translateRequestRepository;
            }

            public async Task<ServiceResponse<List<TranslateRequestViewDto>>> Handle(GetAllTranslateRequestQuery request, CancellationToken cancellationToken)
            {
                var translateRequests = await _translateRequestRepository.GetAllAsync();

                var viewModel = _mapper.Map<List<TranslateRequestViewDto>>(translateRequests);

                return new ServiceResponse<List<TranslateRequestViewDto>>(viewModel);
            }
        }
    }
}

