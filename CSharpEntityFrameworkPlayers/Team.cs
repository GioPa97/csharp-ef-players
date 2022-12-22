using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpEntityFrameworkPlayers
{
    [Table("team")]
    [Index(nameof(Name), IsUnique = true)]
    public class Team
    {
        [Key]
        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Coach { get; set; }
        [Required]
        public string Colours { get; set; }

        public List<Team> Teams { get; set;}
    }

}
