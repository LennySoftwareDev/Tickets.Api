using Application.Dto.Base;
using Application.Dto.Tickets;
using Application.Dto.Tickets.Queries;
using AutoMapper;
using MediatR;
using System.Net;
using Tickets.Domain.Tickets;

namespace Application.Core.Tickets.Queries;

public class GetTickets : IRequestHandler<GetTicketsRequestDto, GenericResponseDto<ListTicketResponseDto>>
{
    private readonly IMapper _mapper;
    private readonly ITicketRepository _ticketRepository;

    public GetTickets(IMapper mapper, ITicketRepository ticketRepository)
    {
        _mapper = mapper;
        _ticketRepository = ticketRepository;
    }

    public async Task<GenericResponseDto<ListTicketResponseDto>> Handle(GetTicketsRequestDto request, CancellationToken cancellationToken)
    {
        var listErrors = new List<string>();

        var result = new ListTicketResponseDto();

        List<TicketDto>? resultList = null;
        try
        {
            var actualPage = (request.Page - 1) * request.RecordPage;
            resultList = _mapper.Map<List<TicketDto>>(await _ticketRepository
            .SearchMatching(x => x.TicketId != 0, actualPage, request.RecordPage));
            var totalRecords = (await _ticketRepository.SearchMatching(x => x.TicketId != 0).ConfigureAwait(false)).Count();
            result.ActualPage = request.Page;
            result.RecordsPage = request.RecordPage;
            result.TotalRecords = totalRecords;
            result.ListTicketsDto = resultList;
        }
        catch (Exception ex)
        {
            listErrors.Add("Error Tickets-GetTickets-GetAll");
            listErrors.Add(ex.Message);
        }
        if (resultList == null)
            listErrors.Add("Error Tickets-GetFotoDetecciones-Null");
        return new GenericResponseDto<ListTicketResponseDto>()
        {
            Result = result,
            StatusCode = listErrors.Count == 0 ? HttpStatusCode.OK : HttpStatusCode.BadRequest,
            StatusDescription = listErrors.Count == 0 ? "Correcto" : "Error",
            Errors = listErrors.Count == 0 ? null : listErrors,
        };
    }
}
