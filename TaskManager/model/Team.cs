using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.model;

public class Team(string name)
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    private int TeamId { get; set; }
    
    [Required]
    [StringLength(30)]
    private string Name { get; set; } = name;
}
