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
        public int TournamentID { get; set; }
        public string TournamentName { get; set; }
        public DateTime TournamentStartDate { get; set; }
        public DateTime TournamentEndDate { get; set; }
        public string TournamentDetails { get; set; }

        [ForeignKey("Club")]
        public int ClubID { get; set; }
        public Club Club { get; set; }

        public IList<TournamentsForEachClub> tournamentsForEachClubs { get; set; }
        = new List<TournamentsForEachClub>();





    }
}
