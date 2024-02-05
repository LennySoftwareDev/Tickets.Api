using Application.Dto.Base;
using Application.Dto.Tickets;
using Application.Dto.Tickets.Commands;
using AutoMapper;
using MediatR;
using System.Net;
using Tickets.Domain.Tickets;

namespace Application.Core.Tickets.Commands;

public class CreateTicket : IRequestHandler<CreateTicketRequestDto, GenericResponseDto<TicketDto>>
{
    private readonly IMapper _mapper;
    private readonly ITicketRepository _ticketRepository;

    public CreateTicket(IMapper mapper, ITicketRepository ticketRepository)
    {
        _mapper = mapper;
        _ticketRepository = ticketRepository;
    }

    public async Task<GenericResponseDto<TicketDto>> Handle(CreateTicketRequestDto request, CancellationToken cancellationToken)
    {
        var listErrors = new List<string>();

        TicketDto? result = null;

        try
        {
            result = _mapper.Map<TicketDto>(await _ticketRepository.Create(_mapper.Map<TicketEntity>(request)));
        }
        catch (Exception ex)
        {
            listErrors.Add("Error Ticket-TicketEntity-Create");
            if (string.IsNullOrEmpty(ex.InnerException?.Message))
                listErrors.Add(ex.Message);
            else
                listErrors.Add(ex.InnerException.Message);
        }

        if (result == null)
            listErrors.Add("Error Ticket-TicketEntity-Null");

        return new GenericResponseDto<TicketDto>()
        {
            Result = result,
            StatusCode = listErrors.Count == 0 ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
            StatusDescription = listErrors.Count == 0 ? "Correcto" : "Error",
            Errors = listErrors.Count == 0 ? null : listErrors,
        };
    }
}
