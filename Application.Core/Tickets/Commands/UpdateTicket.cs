using Application.Dto.Base;
using Application.Dto.Tickets.Commands;
using AutoMapper;
using MediatR;
using System.Net;
using Tickets.Domain.Tickets;

namespace Application.Core.Tickets.Commands;

public class UpdateTicket : IRequestHandler<UpdateTicketRequestDto, GenericResponseDto<bool>>
{
    private readonly IMapper _mapper;
    private readonly ITicketRepository _ticketRepository;

    public UpdateTicket(IMapper mapper, ITicketRepository ticketRepository)
    {
        _mapper = mapper;
        _ticketRepository = ticketRepository;
    }

    public async Task<GenericResponseDto<bool>> Handle(UpdateTicketRequestDto request, CancellationToken cancellationToken)
    {
        var listErrors = new List<string>();

        var result = false;

        try
        {
            result = await _ticketRepository.Update(_mapper.Map<TicketEntity>(request));
        }
        catch (Exception ex)
        {
            listErrors.Add("Error Ticket-Update");
            listErrors.Add(ex.Message);
        }

        if (!result)
            listErrors.Add("Error Ticket-Update-False");

        return new GenericResponseDto<bool>()
        {
            Result = result,
            StatusCode = listErrors.Count == 0 ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
            StatusDescription = listErrors.Count == 0 ? "Correcto" : "Error",
            Errors = listErrors.Count == 0 ? null : listErrors,
        };
    }
}
