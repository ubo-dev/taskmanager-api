using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.model;

public class User(string firstName, string lastName, Team team)
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private int UserId { get; set; }   
    
    [Required]
    [StringLength(30)]
    private string FirstName { get; set; } = firstName;
    
    [Required]
    [StringLength(30)]
    private string LastName { get; set; } = lastName;

    private Team Team { get; set;  } = team;
}