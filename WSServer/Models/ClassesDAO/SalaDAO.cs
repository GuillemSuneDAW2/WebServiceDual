using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSServer.Models.ClassesDAO
{
    public class SalaDAO
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string codi { get; set; }
        public short aforament { get; set; }
        public string descripcio { get; set; }
        public string image { get; set; }

        public SalaDAO(Sala a)
        {
            this.Id = a.Id;
            this.nom = a.nom;
            this.codi = a.codi;
            this.aforament = a.aforament;
            this.descripcio = a.descripcio;
            this.image = a.image;
        }
    }
}