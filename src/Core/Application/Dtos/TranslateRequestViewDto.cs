using System;
namespace Application.Dtos
{
	public class TranslateRequestViewDto
	{
        public string? Text { get; set; }

        public Guid RequestUrlId { get; set; }
    }
}

