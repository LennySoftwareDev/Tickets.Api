using Application.Dto.Base;
using Application.Dto.User;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Application.Dto.Tickets.Commands;

public class UpdateTicketRequestDto : IRequest<GenericResponseDto<bool>>
{
    public int TicketId { get; set; }

    [Required(ErrorMessage = "El campo CreationDate es obligatorio")]

    public DateTime CreationDate { get; set; }

    [Required(ErrorMessage = "El campo DateUpdate es obligatorio")]

    public DateTime DateUpdate { get; set; }

    [Required(ErrorMessage = "El campo Status es obligatorio")]

    public bool Status { get; set; }

    [Required(ErrorMessage = "El campo UserId es obligatorio")]

    public int UserId { get; set; }
    public UserDto User { get; set; }
}
