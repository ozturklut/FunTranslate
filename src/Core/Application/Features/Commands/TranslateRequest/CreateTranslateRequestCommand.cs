using System;
using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using MediatR;

namespace Application.Features.Commands.TranslateRequest
{
	public class CreateTranslateRequestCommand : IRequest<ServiceResponse<Guid>>
	{
		public string? Text { get; set; }
		public Guid RequestUrlId { get; set; }

        public class CreateTranslateRequestCommandHandler : IRequestHandler<CreateTranslateRequestCommand, ServiceResponse<Guid>>
        {
            private readonly ITranslateRequestRepository _translateRequestRepository;
            private readonly IMapper _mapper;

            public CreateTranslateRequestCommandHandler(IMapper mapper, ITranslateRequestRepository translateRequestRepository)
            {
                _mapper = mapper;
                _translateRequestRepository = translateRequestRepository;
            }

            public async Task<ServiceResponse<Guid>> Handle(CreateTranslateRequestCommand request, CancellationToken cancellationToken)
            {
                var translateRequest = _mapper.Map<Domain.Entities.TranslateRequest>(request);
                await _translateRequestRepository.AddAsync(translateRequest);

                return new ServiceResponse<Guid>(translateRequest.Id);
            }
        }
    }
}

