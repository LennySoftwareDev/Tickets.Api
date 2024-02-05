using Application.Dto.Base;
using Application.Dto.Tickets;
using Application.Dto.Tickets.Commands;
using Application.Dto.Tickets.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Tickets.WebApi.Base;

namespace Tickets.WebApi.Controllers;

[Route("Ticket/[controller]")]

public class TicketController : TicketControllerBase
{
    private readonly IMediator _mediator;

    public TicketController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(nameof(GetTicketById))]
    public async Task<ActionResult<GenericResponseDto<TicketDto>>> GetTicketById(int id)
    {
        try
        {
            var result = await _mediator
                .Send(new GetTicketByIdRequestDto
                {
                    TicketId = id
                })
                .ConfigureAwait(false);

            return result.StatusCode == HttpStatusCode.OK
                ? Ok(result)
                : BadRequest(result);
        }
        catch (Exception ex)
        {
            var listError = new List<string>()
            {
                ex.Message
            };
            return BadRequest(new GenericResponseDto<TicketDto>
            {
                Errors = listError.Count > 0 ? listError : null,
                StatusCode = listError.Count > 0 ? HttpStatusCode.BadRequest : HttpStatusCode.OK,
                StatusDescription = listError.Count > 0 ? "Sin resultados" : "Correcto",
                Result = null
            });
        }
    }
    [HttpGet(nameof(GetTickets))]
    public async Task<ActionResult<GenericResponseDto<ListTicketResponseDto>>> GetTickets(int page = 0, int recordPage = 0)
    {
        try
        {
            var result = await _mediator
                .Send(new GetTicketsRequestDto()
                {
                    Page = page,
                    RecordPage = recordPage,
                })
                .ConfigureAwait(false);

            return result.StatusCode == HttpStatusCode.OK
                ? Ok(result)
                : BadRequest(result);
        }
        catch (Exception ex)
        {
            var listError = new List<string>()
            {
                ex.Message
            };
            return BadRequest(new GenericResponseDto<ListTicketResponseDto>
            {
                Errors = listError.Count > 0 ? listError : null,
                StatusCode = listError.Count > 0 ? HttpStatusCode.BadRequest : HttpStatusCode.OK,
                StatusDescription = listError.Count > 0 ? "Sin resultados" : "Correcto",
                Result = null
            });
        }
    }

    [HttpPut(nameof(UpdateTicketById))]
    public async Task<ActionResult<GenericResponseDto<bool>>> UpdateTicketById(UpdateTicketRequestDto entity)
    {
        try
        {
            var result = await _mediator
                .Send(entity)
                .ConfigureAwait(false);

            return result.StatusCode == HttpStatusCode.OK
                ? Ok(result)
                : BadRequest(result);
        }
        catch (Exception ex)
        {
            var listError = new List<string>()
            {
                ex.Message
            };
            return BadRequest(new GenericResponseDto<bool>
            {
                Errors = listError.Count > 0 ? listError : null,
                StatusCode = listError.Count > 0 ? HttpStatusCode.BadRequest : HttpStatusCode.OK,
                StatusDescription = listError.Count > 0 ? "Sin resultados" : "Correcto",
                Result = false
            });
        }
    }

    [HttpPost(nameof(CreateTicket))]
    public async Task<ActionResult<GenericResponseDto<TicketDto>>> CreateTicket(CreateTicketRequestDto entity)
    {
        try
        {
            var result = await _mediator
                .Send(entity)
                .ConfigureAwait(false);

            return result.StatusCode == HttpStatusCode.OK
                ? Ok(result)
                : BadRequest(result);
        }
        catch (Exception ex)
        {
            var listError = new List<string>()
            {
                ex.Message
            };
            return BadRequest(new GenericResponseDto<TicketDto>
            {
                Errors = listError.Count > 0 ? listError : null,
                StatusCode = listError.Count > 0 ? HttpStatusCode.BadRequest : HttpStatusCode.OK,
                StatusDescription = listError.Count > 0 ? "Sin resultados" : "Correcto",
                Result = null
            });
        }
    }

    [HttpDelete(nameof(DeleteTicket))]
    public async Task<ActionResult<GenericResponseDto<bool>>> DeleteTicket(DeleteTicketRequestDto entity)
    {
        try
        {
            var result = await _mediator
                .Send(entity)
                .ConfigureAwait(false);

            return result.StatusCode == HttpStatusCode.OK
                ? Ok(result)
                : BadRequest(result);
        }
        catch (Exception ex)
        {
            var listError = new List<string>()
            {
                ex.Message
            };
            return BadRequest(new GenericResponseDto<bool>
            {
                Errors = listError.Count > 0 ? listError : null,
                StatusCode = listError.Count > 0 ? HttpStatusCode.BadRequest : HttpStatusCode.OK,
                StatusDescription = listError.Count > 0 ? "Sin resultados" : "Correcto",
                Result = false
            });
        }
    }
}
