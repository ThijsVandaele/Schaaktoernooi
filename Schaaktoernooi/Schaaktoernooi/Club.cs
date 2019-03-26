using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Schaaktoernooi
{
    public class Club
    {
        [Key]
        public int Id { get; set; }

        public IList<TournamentsForEachClub> TournamentsForEachClubs { get; set; }
            = new List<TournamentsForEachClub>();
    }
}
