using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSServer.Models.ClassesDAO
{
    public class ActivitatDirigidaDAO
    {
        public int Id { get; set; }
        public string nom { get; set; }
        public string descripcio { get; set; }
        public string tipologia { get; set; }
        public string intensitat { get; set; }
        public string image { get; set; }
        public int Category_Id { get; set; }

        public ActivitatDirigidaDAO(ActivitatDirigida a)
        {
            this.Id = a.Id;
            this.nom = a.nom;
            this.descripcio = a.descripcio;
            this.tipologia = a.tipologia;
            this.intensitat = a.intensitat;
            this.image = a.image;
            this.Category_Id = a.Category_Id;
        }
    }
}