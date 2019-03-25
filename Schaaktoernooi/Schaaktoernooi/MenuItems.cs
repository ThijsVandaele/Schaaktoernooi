using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Schaaktoernooi
{
    public class MenuItem
    {
        [Key]
        public int MenuID { get; set; }
        public int Nummer { get; set; }
        public string Omschrijving { get; set; }

    }
}
