using System;
using Application.Features.Commands.TranslateRequest;
using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Features.Commands.TranslateResponse
{
	public class CreateTranslateResponseCommand : IRequest<ServiceResponse<Guid>>
	{
        public string? TranslatedText { get; set; }

        public Guid TranslateRequestId { get; set; }

        public class CreateTranslateResponseCommandHandler : IRequestHandler<CreateTranslateResponseCommand, ServiceResponse<Guid>>
        {
            private readonly ITranslateResponseRepository _translateResponseRepository;
            private readonly IMapper _mapper;

            public CreateTranslateResponseCommandHandler(IMapper mapper, ITranslateResponseRepository translateResponseRepository)
            {
                _mapper = mapper;
                _translateResponseRepository = translateResponseRepository;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateTranslateResponseCommand request, CancellationToken cancellationToken)
            {
                var translateResponse = _mapper.Map<Domain.Entities.TranslateResponse>(request);
                await _translateResponseRepository.AddAsync(translateResponse);

                return new ServiceResponse<Guid>(translateResponse.Id);
            }
        }
    }
}

