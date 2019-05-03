using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSServer.Models.ClassesDAO
{
    public class SociDAO
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string cognoms { get; set; }
        public string dni { get; set; }
        public string correu { get; set; }
        public string naixement { get; set; }

        public SociDAO(Soci a)
        {
            this.Id = a.Id;
            this.nom = a.nom;
            this.cognoms = a.cognoms;
            this.dni = a.dni;
            this.correu = a.correu;
            this.naixement = a.naixement;
        }
    }
}