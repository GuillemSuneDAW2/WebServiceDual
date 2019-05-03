using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSServer.Models.ClassesDAO
{
    public class InscripcioDAO
    {
        public int Id { get; set; }
        public int Sessio_Id { get; set; }
        public int Soci_Id { get; set; }

        public InscripcioDAO(Inscripcions1 a)
        {
            this.Id = a.Id;
            Sessio_Id = a.Sessio_Id;
            Soci_Id = a.Soci_Id;
        }
    }
}