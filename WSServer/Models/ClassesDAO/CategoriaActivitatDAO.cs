using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSServer.Models.ClassesDAO
{
    public class CategoriaActivitatDAO
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string image { get; set; }

        public CategoriaActivitatDAO(CategoriaActivitat a)
        {
            this.Id = a.Id;
            this.nom = a.nom;
            this.image = a.image;
        }
    }
}