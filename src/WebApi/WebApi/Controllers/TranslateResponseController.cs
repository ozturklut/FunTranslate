using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Commands.TranslateRequest;
using Application.Features.Commands.TranslateResponse;
using Application.Features.Queries.TranslateRequest;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TranslateResponseController : Controller
    {
        private readonly IMediator _mediator;

        public TranslateResponseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var query = new GetAllTranslateResponseQuery();
        //    return Ok(await _mediator.Send(query));
        //}

        [HttpPost]
        public async Task<IActionResult> Post(CreateTranslateResponseCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}

