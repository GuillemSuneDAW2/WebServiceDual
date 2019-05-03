using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WSServer.Models;

namespace WSServer.Controllers
{
    public class GimnasController : ApiController
    {
        #region GET
        // GET ActivitatDirigida
        [Route("api/activitatDirigida/{id?}")]
        public HttpResponseMessage GetActivitatDirigida(int id)
        {
            var resposta = GimnasRepository.GetActivitatDirigida(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/activitatDirigidasTot")]
        public HttpResponseMessage GetActivitatDirigidasTot()
        {
            var resposta = GimnasRepository.GetAllActivitatsTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/activitatDirigidaFiltre/{nom}")]
        public HttpResponseMessage GetActivitatDirigidaFiltre(string nom)
        {
            var resposta = GimnasRepository.GetActivitatFiltre(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/activitatDirigidasAndroid")]
        public HttpResponseMessage GetActivitatDirigidasAndroid()
        {
            var resposta = GimnasRepository.GetActivitatDirigidasAndroid();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET AdminLogin
        [Route("api/admin/{user}/{pass}")]
        public HttpResponseMessage GetAdmin(string user, string pass)
        {
            var resposta = GimnasRepository.GetAdminLogin(user, pass);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Benefici
        [Route("api/benefici/{id?}")]
        public HttpResponseMessage GetBenefici(int id)
        {
            var resposta = GimnasRepository.GetBenefici(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/beneficisTot")]
        public HttpResponseMessage GetBeneficisTot()
        {
            var resposta = GimnasRepository.GetAllBeneficiTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/beneficiFiltre/{text}")]
        public HttpResponseMessage GetBeneficiFiltre(string text)
        {
            var resposta = GimnasRepository.GetBeneficiFiltre(text);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/beneficiAct/{id}")]
        public HttpResponseMessage GetBeneficisActivitat(int id)
        {
            var resposta = GimnasRepository.GetBeneficisActivitat(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/beneficisAndroid")]
        public HttpResponseMessage GetBeneficisAndroid()
        {
            var resposta = GimnasRepository.GetBeneficisAndroid();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET CategoriaActivitat
        [Route("api/categAct/{id?}")]
        public HttpResponseMessage GetCategAct(int id)
        {
            var resposta = GimnasRepository.GetCategAct(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/categActsTot")]
        public HttpResponseMessage GetCategActsTot()
        {
            var resposta = GimnasRepository.GetAllCategActTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/categActFiltre/{nom}")]
        public HttpResponseMessage GetCategActNom(string nom)
        {
            var resposta = GimnasRepository.GetCategActFiltre(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/categoriaActivitatsAndroid")]
        public HttpResponseMessage GetCategoriaActivitatsAndroid()
        {
            var resposta = GimnasRepository.GetCategoriaActivitatsAndroid();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET CategoriaProfesional
        [Route("api/categProf/{id?}")]
        public HttpResponseMessage GetCategProf(int id)
        {
            var resposta = GimnasRepository.GetCategProf(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/categProfsTot")]
        public HttpResponseMessage GetCategProfsTot()
        {
            var resposta = GimnasRepository.GetAllCategProfTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/categProfFiltre/{nom}")]
        public HttpResponseMessage GetCategProfFiltre(string nom)
        {
            var resposta = GimnasRepository.GetCategProfFiltre(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Dia
        [Route("api/dia/{id?}")]
        public HttpResponseMessage GetDia(int id)
        {
            var resposta = GimnasRepository.GetDia(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/diasTot")]
        public HttpResponseMessage GetDiasTot()
        {
            var resposta = GimnasRepository.GetAllDiaTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET DiaNoHabil
        [Route("api/diaNoHabil/{id?}")]
        public HttpResponseMessage GetDiaNoHabil(int id)
        {
            var resposta = GimnasRepository.GetDiaNoHabil(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/diaNoHabilsTot")]
        public HttpResponseMessage GetDiaNoHabilsTot()
        {
            var resposta = GimnasRepository.GetAllDiaNoHabilTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/diaNoHabilFiltre/{motiu}")]
        public HttpResponseMessage GetDiaNoHabilFiltre(string motiu)
        {
            var resposta = GimnasRepository.GetDiaNoHabilFiltre(motiu);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Esdeveniment
        [Route("api/esdeveniment/{id?}")]
        public HttpResponseMessage GetEsdeveniment(int id)
        {
            var resposta = GimnasRepository.GetEsdeveniment(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/esdevenimentsTot")]
        public HttpResponseMessage GetEsdevenimentsTot()
        {
            var resposta = GimnasRepository.GetAllEsdevenimentTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/esdevenimentFiltre/{titol}")]
        public HttpResponseMessage GetEsdevenimentFiltre(string titol)
        {
            var resposta = GimnasRepository.GetEsdevenimentFiltre(titol);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Hora
        [Route("api/hora/{id?}")]
        public HttpResponseMessage GetHora(int id)
        {
            var resposta = GimnasRepository.GetHora(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/horasTot")]
        public HttpResponseMessage GetHorasTot()
        {
            var resposta = GimnasRepository.GetAllHoraTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Inscripcions
        [Route("api/inscripcionsAndroid")]
        public HttpResponseMessage GetInscripcionsAndroid()
        {
            var resposta = GimnasRepository.GetInscripcionsAndroid();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Sala
        [Route("api/sala/{id?}")]
        public HttpResponseMessage GetSala(int id)
        {
            var resposta = GimnasRepository.GetSala(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/salasTot")]
        public HttpResponseMessage GetSalasTot()
        {
            var resposta = GimnasRepository.GetAllSalaTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/salaFiltre/{nom}")]
        public HttpResponseMessage GetSalaFiltre(string nom)
        {
            var resposta = GimnasRepository.GetSalaFiltre(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/salasAndroid")]
        public HttpResponseMessage GetSalasAndroid()
        {
            var resposta = GimnasRepository.GetSalasAndroid();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Sessio
        [Route("api/sessio/{id?}")]
        public HttpResponseMessage GetSessio(int id)
        {
            var resposta = GimnasRepository.GetSessio(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/sessiosTot")]
        public HttpResponseMessage GetSessiosTot()
        {
            var resposta = GimnasRepository.GetAllSessioTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/sessiosDia/{dia}")]
        public HttpResponseMessage GetSessiosDia(string dia)
        {
            var resposta = GimnasRepository.GetSessiosDia(dia);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Soci
        [Route("api/soci/{id?}")]
        public HttpResponseMessage GetSoci(int id)
        {
            var resposta = GimnasRepository.GetSoci(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/socisTot")]
        public HttpResponseMessage GetSocisTot()
        {
            var resposta = GimnasRepository.GetAllSociTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/sociFiltre/{nom}")]
        public HttpResponseMessage GetSociFiltre(string nom)
        {
            var resposta = GimnasRepository.GetSociFiltre(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/socisAndroid")]
        public HttpResponseMessage GetSocisAndroid()
        {
            var resposta = GimnasRepository.GetSocisAndroid();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // GET Treballador
        [Route("api/treballador/{id?}")]
        public HttpResponseMessage GetTreballador(int id)
        {
            var resposta = GimnasRepository.GetTreballador(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/treballadorsTot")]
        public HttpResponseMessage GetTreballadorsTot()
        {
            var resposta = GimnasRepository.GetAllTreballadorTot();
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/treballadorFiltre/{nom}")]
        public HttpResponseMessage GetTreballadorFiltre(string nom)
        {
            var resposta = GimnasRepository.GetTreballadorFiltre(nom);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        #endregion
        #region PUT
        // PUT ActivitatDirigida
        [Route("api/activitatDirigida/{id?}")]
        public HttpResponseMessage PutActivitatDirigida([FromBody]ActivitatDirigida val)
        {
            var resposta = GimnasRepository.UpdateActivitatDirigida(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/activitatDirigidaAddBenefici/{idAct}/{idBen}")]
        public HttpResponseMessage PutActivitatDirigidaAddBenefici(int idAct, int idBen)
        {
            var resposta = GimnasRepository.UpdateActivitatDirigidaAddBenefici(idAct, idBen);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        [Route("api/activitatDirigidaDeleteBenefici/{idAct}/{idBen}")]
        public HttpResponseMessage PutActivitatDirigidaRemoveBenefici(int idAct, int idBen)
        {
            var resposta = GimnasRepository.UpdateActivitatDirigidaDeleteBenefici(idAct, idBen);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // PUT Benefici
        [Route("api/benefici/{id?}")]
        public HttpResponseMessage PutBenefici([FromBody]Benefici val)
        {
            var resposta = GimnasRepository.UpdateBenefici(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // PUT DiaNoHabil
        [Route("api/diaNoHabil/{id?}")]
        public HttpResponseMessage PutDiaNoHabil([FromBody]DiaNoHabil val)
        {
            var resposta = GimnasRepository.UpdateDiaNoHabil(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // PUT Esdeveniment
        [Route("api/esdeveniment/{id?}")]
        public HttpResponseMessage PutEsdeveniment([FromBody]Esdeveniment val)
        {
            var resposta = GimnasRepository.UpdateEsdeveniment(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // PUT Sala
        [Route("api/sala/{id?}")]
        public HttpResponseMessage PutSala([FromBody]Sala val)
        {
            var resposta = GimnasRepository.UpdateSala(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // PUT Sessio
        [Route("api/sessio/{id?}")]
        public HttpResponseMessage PutSessio([FromBody]Sessio val)
        {
            var resposta = GimnasRepository.UpdateSessio(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // PUT Soci
        [Route("api/soci/{id?}")]
        public HttpResponseMessage PutSoci([FromBody]Soci val)
        {
            var resposta = GimnasRepository.UpdateSoci(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // PUT Treballador
        [Route("api/treballador/{id?}")]
        public HttpResponseMessage PutTreballador([FromBody]Treballador val)
        {
            var resposta = GimnasRepository.UpdateTreballador(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        #endregion
        #region POST
        // POST ActivitatDirigida
        [Route("api/activitatDirigida")]
        public HttpResponseMessage PostActivitatDirigida([FromBody]ActivitatDirigida val)
        {
            var resposta = GimnasRepository.InsertActivitatDirigida(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST Admin
        [Route("api/admin")]
        public HttpResponseMessage PostAdmin([FromBody]Admin val)
        {
            var resposta = GimnasRepository.InsertAdmin(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST Benefici
        [Route("api/benefici")]
        public HttpResponseMessage PostBenefici([FromBody]Benefici val)
        {
            var resposta = GimnasRepository.InsertBenefici(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST CategoriaActivitat
        [Route("api/categAct")]
        public HttpResponseMessage PostCategAct([FromBody]CategoriaActivitat val)
        {
            var resposta = GimnasRepository.InsertCategAct(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST CategoriaProfesional
        [Route("api/categProf")]
        public HttpResponseMessage PostCategProf([FromBody]CategoriaProfesional val)
        {
            var resposta = GimnasRepository.InsertCategProf(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST DiaNoHabil
        [Route("api/diaNoHabil")]
        public HttpResponseMessage PostDiaNoHabil([FromBody]DiaNoHabil val)
        {
            var resposta = GimnasRepository.InsertDiaNoHabil(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST Esdeveniment
        [Route("api/esdeveniment")]
        public HttpResponseMessage PostEsdeveniment([FromBody]Esdeveniment val)
        {
            var resposta = GimnasRepository.InsertEsdeveniment(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST Sala
        [Route("api/sala")]
        public HttpResponseMessage PostSala([FromBody]Sala val)
        {
            var resposta = GimnasRepository.InsertSala(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST Sessio
        [Route("api/sessio")]
        public HttpResponseMessage PostSessio([FromBody]Sessio val)
        {
            var resposta = GimnasRepository.InsertSessio(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST Soci
        [Route("api/soci")]
        public HttpResponseMessage PostSoci([FromBody]Soci val)
        {
            var resposta = GimnasRepository.InsertSoci(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        // POST Treballador
        [Route("api/treballador")]
        public HttpResponseMessage PostTreballador([FromBody]Treballador val)
        {
            var resposta = GimnasRepository.InsertTreballador(val);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, resposta);
            return response;
        }
        #endregion
        #region DELETE
        // DELETE ActivitatDirigida
        [Route("api/activitatDirigida/{id?}")]
        public HttpResponseMessage DeleteActivitatDirigida(int id)
        {
            GimnasRepository.DeleteActivitatDirigida(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE Admin
        [Route("api/admin/{id?}")]
        public HttpResponseMessage DeleteAdmin(int id)
        {
            GimnasRepository.DeleteAdmin(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE Benefici
        [Route("api/benefici/{id?}")]
        public HttpResponseMessage DeleteBenefici(int id)
        {
            GimnasRepository.DeleteBenefici(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE CategoriaActivitat
        [Route("api/categAct/{id?}")]
        public HttpResponseMessage DeleteCategAct(int id)
        {
            GimnasRepository.DeleteCategAct(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE CategoriaProfesional
        [Route("api/categProf/{id?}")]
        public HttpResponseMessage DeleteCategProf(int id)
        {
            GimnasRepository.DeleteCategProf(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE DiaNoHabil
        [Route("api/diaNoHabil/{id?}")]
        public HttpResponseMessage DeleteDiaNoHabil(int id)
        {
            GimnasRepository.DeleteDiaNoHabil(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE Esdeveniment
        [Route("api/esdeveniment/{id?}")]
        public HttpResponseMessage DeleteEsdeveniment(int id)
        {
            GimnasRepository.DeleteEsdeveniment(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE Sala
        [Route("api/sala/{id?}")]
        public HttpResponseMessage DeleteSala(int id)
        {
            GimnasRepository.DeleteSala(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE Sessio
        [Route("api/sessio/{id?}")]
        public HttpResponseMessage DeleteSessio(int id)
        {
            GimnasRepository.DeleteSessio(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE Soci
        [Route("api/soci/{id?}")]
        public HttpResponseMessage DeleteSoci(int id)
        {
            GimnasRepository.DeleteSoci(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        // DELETE Treballador
        [Route("api/treballador/{id?}")]
        public HttpResponseMessage DeleteTreballador(int id)
        {
            GimnasRepository.DeleteTreballador(id);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, id);
            return response;
        }
        #endregion
    }
}