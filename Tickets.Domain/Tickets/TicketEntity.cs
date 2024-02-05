using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tickets.Domain.Base;
using Tickets.Domain.User;

namespace Tickets.Domain.Tickets;

public class TicketEntity : EntityBase
{
    [Key]
    [Column("IdTicket")]
    public int TicketId { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime DateUpdate { get; set; }
    public bool Status { get; set; }

    [Column("IdUser")]
    [ForeignKey("User")]
    [Required(ErrorMessage = "El campo UserId es obligatorio")]
    public int UserId { get; set; }
    public UserEntity User { get; set; }
}
