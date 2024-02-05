using Application.Dto.Base;
using Application.Dto.Tickets;
using Application.Dto.Tickets.Queries;
using AutoMapper;
using MediatR;
using System.Net;
using Tickets.Domain.Tickets;

namespace Application.Core.Tickets.Queries;

public class GetTicketById : IRequestHandler<GetTicketByIdRequestDto, GenericResponseDto<TicketDto>>
{
    private readonly IMapper _mapper;
    private readonly ITicketRepository _ticketRepository;

    public GetTicketById(IMapper mapper, ITicketRepository ticketRepository)
    {
        _mapper = mapper;
        _ticketRepository = ticketRepository;
    }

    public async Task<GenericResponseDto<TicketDto>> Handle(GetTicketByIdRequestDto request, CancellationToken cancellationToken)
    {
        var listErrors = new List<string>();

        var result = new TicketDto();

        try
        {
            result = _mapper.Map<TicketDto>(await _ticketRepository
                .FirstBySearchMatching(x => x.TicketId == request.TicketId));
        }
        catch (Exception ex)
        {
            listErrors.Add(ex.Message);
        }

        if (result == null)
            listErrors.Add("Error Tickets-GetByIdTicket-Null");

        return new GenericResponseDto<TicketDto>()
        {
            Result = result,
            StatusCode = listErrors.Count == 0 ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
            StatusDescription = listErrors.Count == 0 ? "Correcto" : "Error",
            Errors = listErrors.Count == 0 ? null : listErrors,
        };
    }
}
