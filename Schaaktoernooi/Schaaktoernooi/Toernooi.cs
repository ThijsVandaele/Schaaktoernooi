using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schaaktoernooi
{
    public class Toernooi
    {
        [Key]
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public DateTime TournamentStartDate { get; set; }
        public DateTime TournamentEndDate { get; set; }
        public string TournamentDetails { get; set; }

        public IList<TournamentsForEachClub> TournamentsForEachClubs { get; set; }
            = new List<TournamentsForEachClub>();
    }
}
