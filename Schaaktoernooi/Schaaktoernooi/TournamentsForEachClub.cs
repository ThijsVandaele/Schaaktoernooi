using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schaaktoernooi
{
    public class TournamentsForEachClub
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Club")]
        public int ClubId { get; set; }
        public Club Club { get; set; }

        [ForeignKey("Toernooi")]
        public int ToernooiId { get; set; }
        public Toernooi Toernooi { get; set; }
    }
}
