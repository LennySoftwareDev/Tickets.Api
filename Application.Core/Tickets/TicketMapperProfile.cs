using Application.Dto.Tickets;
using Application.Dto.Tickets.Commands;
using AutoMapper;
using Tickets.Domain.Tickets;

namespace Application.Core.Tickets;

public class TicketMapperProfile : Profile
{
    public TicketMapperProfile()
    {
        CreateMap<TicketEntity, TicketDto>().ReverseMap();
        CreateMap<TicketEntity, CreateTicketRequestDto>().ReverseMap();
        CreateMap<TicketEntity, UpdateTicketRequestDto>().ReverseMap();
    }
}