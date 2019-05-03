using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSServer.Models.ClassesDAO
{
    public class BeneficiDAO
    {
        public int Id { get; set; }
        public string descripcio { get; set; }

        public BeneficiDAO(Benefici a)
        {
            this.Id = a.Id;
            this.descripcio = a.descripcio;
        }
    }
}