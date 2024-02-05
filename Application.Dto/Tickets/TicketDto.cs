using Application.Dto.User;

namespace Application.Dto.Tickets;

public class TicketDto
{
    public int TicketId { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DateUpdate { get; set; }
    public bool Status { get; set; }

    public int UserId { get; set; }
    public UserDto User { get; set; }
}
