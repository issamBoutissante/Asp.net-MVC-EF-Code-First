using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.net_MVC_Code_First
{
        public partial class Stagiaire
        {
            public int id { get; set; }
            public string nom { get; set; }
            public string prenom { get; set; }
            public int age { get; set; }
            Filiere Filiere { get; set; }
        }

}