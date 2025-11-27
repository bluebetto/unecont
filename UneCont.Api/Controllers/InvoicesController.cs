using System.Xml;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UneCont.Application.Dto;
using UneCont.Application.Extensions;
using UneCont.Application.Invoices.Commands;
using UneCont.Application.Invoices.Queries;

namespace UneCont.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var result = await mediator.Send(new GetInvoicesQuery());
            return Ok(result);
        }

        [HttpPost]
        [Consumes("application/xml", "text/xml", "text/plain")]
        public async Task<IActionResult> CreateAsync([FromBody] XmlElement xmlString)
        {
            try
            {
                CreateInvoiceCommand command = new(xmlString.ConvertToDto<InvoiceDto>());
                await mediator.Send(command);
                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
