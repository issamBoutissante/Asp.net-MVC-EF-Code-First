using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.net_MVC_Code_First
{
    public class Filiere
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Stagiaire> Stagiaires { get; set; }
    }
}