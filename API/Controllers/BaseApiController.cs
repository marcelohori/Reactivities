using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : Controller
    {
        private IMediator? _mediator;
        protected IMediator Mediator => 
        _mediator ??= HttpContext.RequestServices.GetService<IMediator>()
            ?? throw new InvalidOperationException("Mediator service is not available.");
    }
}