using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Schaaktoernooi
{
    public class Club
    {
        [Key]
        public int ClubID { get; set; }

        public IList<TournamentsForEachClub> tournamentsForEachClubs { get; set; }
        = new List<TournamentsForEachClub>();
    }
}
