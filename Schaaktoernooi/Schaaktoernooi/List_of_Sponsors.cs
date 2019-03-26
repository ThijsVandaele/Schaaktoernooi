using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Schaaktoernooi
{
    class List_of_Sponsors
    {
        [Key]
        public int sponsorID { get; set; }

        public string SponsorName { get; set; }
        public string SponsorPhone { get; set; }
        public string OtherSponsorDetails { get; set; }


    }
}
