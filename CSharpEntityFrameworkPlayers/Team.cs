using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpEntityFrameworkPlayers
{
    [Table("team")]
 
    public class Team
    {
       
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Coach { get; set; }
        [Required]
        public string Colours { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();
    }

}
