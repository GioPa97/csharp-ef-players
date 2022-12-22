using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpEntityFrameworkPlayers
{
    [Table("player")]
    [Index(nameof(PlayerID), IsUnique = true)]
    public class Player
    {

        public int PlayerID { get; set; }

        [Required]
        public int MatchAttended { get; set; }

        public int MatchWon { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
       
        public Team TeamId { get; set; }

    }
}
