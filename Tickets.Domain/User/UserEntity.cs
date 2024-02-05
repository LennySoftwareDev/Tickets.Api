using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tickets.Domain.Base;

namespace Tickets.Domain.User;

public class UserEntity : EntityBase
{
    [Key]
    [Column("IdUser")]
    public int UserId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}
