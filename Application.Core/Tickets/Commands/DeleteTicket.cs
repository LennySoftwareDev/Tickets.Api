using Application.Dto.Base;
using Application.Dto.Tickets.Commands;
using MediatR;
using System.Net;
using Tickets.Domain.Tickets;

namespace Application.Core.Tickets.Commands;

public class DeleteTicket : IRequestHandler<DeleteTicketRequestDto, GenericResponseDto<bool>>
{
    private readonly ITicketRepository _ticketRepository;

    public DeleteTicket(ITicketRepository ticketRepository)
    {
        _ticketRepository = ticketRepository;
    }

    public async Task<GenericResponseDto<bool>> Handle(DeleteTicketRequestDto request, CancellationToken cancellationToken)
    {
        var listErrors = new List<string>();

        var result = false;

        try
        {
            var entity = await _ticketRepository.GetById(request.TicketId);
            result = await _ticketRepository.Delete(entity);
        }
        catch (Exception ex)
        {
            listErrors.Add("Error Tickets-Delete-Ticket");
            if (string.IsNullOrEmpty(ex.InnerException?.Message))
                listErrors.Add(ex.Message);
            else
                listErrors.Add(ex.InnerException.Message);
        }

        if (!result)
            listErrors.Add("Error Tickets-Delete-Ticket-false");

        return new GenericResponseDto<bool>()
        {
            Result = result,
            StatusCode = listErrors.Count == 0 ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
            StatusDescription = listErrors.Count == 0 ? "Correcto" : "Error",
            Errors = listErrors.Count == 0 ? null : listErrors,
        };
    }
}
