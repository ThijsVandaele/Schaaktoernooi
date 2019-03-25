using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Schaaktoernooi
{
    public class Users
    {
      [Key]
      public int ID { get; set; }
      public bool Type { get; set;}
      public string Login { get; set;}
      public string Paswoord { get; set; }

    }
}
