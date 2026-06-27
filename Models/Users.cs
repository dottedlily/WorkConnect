namespace WorkConnect.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Users
{
    [Key]
    [Column("id")]
    public int id { get; set; }
    public required string email { get; set; }

}