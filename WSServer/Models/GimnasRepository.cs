using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSServer.Models.ClassesDAO;

namespace WSServer.Models
{
    public class GimnasRepository
    {
        private static GimnasAppEntities dataContext = new GimnasAppEntities();
        #region GET
        // GET ActivitatDirigida
        public static ActivitatDirigida GetActivitatDirigida(int id)
        {
            ActivitatDirigida c = dataContext.ActivitatDirigidas.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<ActivitatDirigida> GetAllActivitatsTot()
        {
            List<ActivitatDirigida> lc = dataContext.ActivitatDirigidas.ToList();
            return lc;
        }
        public static List<ActivitatDirigida> GetActivitatFiltre(string nom)
        {
            List<ActivitatDirigida> lc = dataContext.ActivitatDirigidas.Where(x => x.nom.Contains(nom)).ToList();
            return lc;
        }
        public static List<ActivitatDirigidaDAO> GetActivitatDirigidasAndroid()
        {
            List<ActivitatDirigidaDAO> lc = dataContext.ActivitatDirigidas.ToList().Select(a => new ActivitatDirigidaDAO(a)).ToList();
            return lc;
        }
        // GET Admin
        public static Admin GetAdmin(int id)
        {
            Admin c = dataContext.Admins.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static Admin GetAdminLogin(string usuari, string password)
        {
            Admin c = dataContext.Admins.Where(x => x.usuari.Equals(usuari) && x.contrasenya.Equals(password)).SingleOrDefault();
            return c;
        }
        // GET Benefici
        public static Benefici GetBenefici(int id)
        {
            Benefici c = dataContext.Beneficis.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<Benefici> GetAllBeneficiTot()
        {
            List<Benefici> lc = dataContext.Beneficis.ToList();
            return lc;
        }
        public static List<Benefici> GetBeneficiFiltre(string text)
        {
            List<Benefici> lc = dataContext.Beneficis.Where(x => x.descripcio.Contains(text)).ToList();
            return lc;
        }
        public static List<Benefici> GetBeneficisActivitat(int id)
        {
            ActivitatDirigida a = dataContext.ActivitatDirigidas.Where(x => x.Id == id).SingleOrDefault();
            List<Benefici> lc = a.Beneficis.ToList();
            return lc;
        }
        public static List<BeneficiDAO> GetBeneficisAndroid()
        {
            List<BeneficiDAO> lc = dataContext.Beneficis.ToList().Select(a => new BeneficiDAO(a)).ToList();
            return lc;
        }
        // GET CategoriaActivitat
        public static CategoriaActivitat GetCategAct(int id)
        {
            CategoriaActivitat c = dataContext.CategoriaActivitats.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<CategoriaActivitat> GetAllCategActTot()
        {
            List<CategoriaActivitat> lc = dataContext.CategoriaActivitats.ToList();
            return lc;
        }
        public static List<CategoriaActivitat> GetCategActFiltre(string nom)
        {
            List<CategoriaActivitat> lc = dataContext.CategoriaActivitats.Where(x => x.nom.Contains(nom)).ToList();
            return lc;
        }
        public static List<CategoriaActivitatDAO> GetCategoriaActivitatsAndroid()
        {
            List<CategoriaActivitatDAO> lc = dataContext.CategoriaActivitats.ToList().Select(a => new CategoriaActivitatDAO(a)).ToList();
            return lc;
        }
        // GET CategoriaProfesional
        public static CategoriaProfesional GetCategProf(int id)
        {
            CategoriaProfesional c = dataContext.CategoriaProfesionals.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<CategoriaProfesional> GetAllCategProfTot()
        {
            List<CategoriaProfesional> lc = dataContext.CategoriaProfesionals.ToList();
            return lc;
        }
        public static List<CategoriaProfesional> GetCategProfFiltre(string nom)
        {
            List<CategoriaProfesional> lc = dataContext.CategoriaProfesionals.Where(x => x.nom.Contains(nom)).ToList();
            return lc;
        }
        // GET Dia
        public static Dia GetDia(int id)
        {
            Dia c = dataContext.Dias.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<Dia> GetAllDiaTot()
        {
            List<Dia> lc = dataContext.Dias.ToList();
            return lc;
        }
        // GET DiaNoHabil
        public static DiaNoHabil GetDiaNoHabil(int id)
        {
            DiaNoHabil c = dataContext.DiaNoHabils.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<DiaNoHabil> GetAllDiaNoHabilTot()
        {
            List<DiaNoHabil> lc = dataContext.DiaNoHabils.ToList();
            return lc;
        }
        public static List<DiaNoHabil> GetDiaNoHabilFiltre(string motiu)
        {
            List<DiaNoHabil> lc = dataContext.DiaNoHabils.Where(x => x.motiu.Contains(motiu)).ToList();
            return lc;
        }
        // GET Esdeveniment
        public static Esdeveniment GetEsdeveniment(int id)
        {
            Esdeveniment c = dataContext.Esdeveniments.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<Esdeveniment> GetAllEsdevenimentTot()
        {
            List<Esdeveniment> lc = dataContext.Esdeveniments.ToList();
            return lc;
        }
        public static List<Esdeveniment> GetEsdevenimentFiltre(string titol)
        {
            List<Esdeveniment> lc = dataContext.Esdeveniments.Where(x => x.titol.Contains(titol)).ToList();
            return lc;
        }
        // GET Hora
        public static Hora GetHora(int id)
        {
            Hora c = dataContext.Horas.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<Hora> GetAllHoraTot()
        {
            List<Hora> lc = dataContext.Horas.ToList();
            return lc;
        }
        // GET Inscripcions
        public static List<InscripcioDAO> GetInscripcionsAndroid()
        {
            List<InscripcioDAO> lc = dataContext.Inscripcions1.ToList().Select(a => new InscripcioDAO(a)).ToList();
            return lc;
        }
        // GET Sala
        public static Sala GetSala(int id)
        {
            Sala c = dataContext.Salas.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<Sala> GetAllSalaTot()
        {
            List<Sala> lc = dataContext.Salas.ToList();
            return lc;
        }
        public static List<Sala> GetSalaFiltre(string nom)
        {
            List<Sala> lc = dataContext.Salas.Where(x => x.nom.Contains(nom)).ToList();
            return lc;
        }
        public static List<SalaDAO> GetSalasAndroid()
        {
            List<SalaDAO> lc = dataContext.Salas.ToList().Select(a => new SalaDAO(a)).ToList();
            return lc;
        }
        // GET Sessio
        public static Sessio GetSessio(int id)
        {
            Sessio c = dataContext.Sessios.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<SessioView> GetAllSessioTot()
        {
            List<SessioView> lc = dataContext.SessioViews.ToList();
            return lc;
        }
        public static List<SessioView> GetSessiosDia(string dia)
        {
            List<SessioView> lc = dataContext.SessioViews.Where(x => x.dia.Equals(dia)).ToList();
            return lc;
        }
        // GET Soci
        public static Soci GetSoci(int id)
        {
            Soci c = dataContext.Socis.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<Soci> GetAllSociTot()
        {
            List<Soci> lc = dataContext.Socis.ToList();
            return lc;
        }
        public static List<Soci> GetSociFiltre(string nomCognom)
        {
            List<Soci> lc = dataContext.Socis.Where(x => x.cognoms.Contains(nomCognom) || x.nom.Contains(nomCognom)).ToList();
            return lc;
        }
        public static List<SociDAO> GetSocisAndroid()
        {
            List<SociDAO> lc = dataContext.Socis.ToList().Select(a => new SociDAO(a)).ToList();
            return lc;
        }
        // GET Treballador
        public static Treballador GetTreballador(int id)
        {
            Treballador c = dataContext.Treballadors.Where(x => x.Id == id).SingleOrDefault();
            return c;
        }
        public static List<Treballador> GetAllTreballadorTot()
        {
            List<Treballador> lc = dataContext.Treballadors.ToList();
            return lc;
        }
        public static List<Treballador> GetTreballadorFiltre(string nomCognom)
        {
            List<Treballador> lc = dataContext.Treballadors.Where(x => x.cognoms.Contains(nomCognom) || x.nom.Contains(nomCognom)).ToList();
            return lc;
        }
        #endregion
        #region PUT
        // PUT ActivitatDirigida
        public static ActivitatDirigida UpdateActivitatDirigida(ActivitatDirigida c)
        {
            try
            {
                ActivitatDirigida c0 = dataContext.ActivitatDirigidas.Where(x => x.Id == c.Id).SingleOrDefault();
                if (!String.IsNullOrEmpty(c.nom)) c0.nom = c.nom;
                if (!String.IsNullOrEmpty(c.descripcio)) c0.descripcio = c.descripcio;
                if (!String.IsNullOrEmpty(c.tipologia)) c0.tipologia = c.tipologia;
                if (!String.IsNullOrEmpty(c.intensitat)) c0.intensitat = c.intensitat;
                if (!String.IsNullOrEmpty(c.image)) c0.image = c.image;
                c0.Category_Id = c.Category_Id;

                dataContext.SaveChanges();
                return GetActivitatDirigida(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT ActivitatDirigida add Benefici
        public static ActivitatDirigida UpdateActivitatDirigidaAddBenefici(int c, int b)
        {
            try
            {
                ActivitatDirigida c0 = dataContext.ActivitatDirigidas.Where(x => x.Id == c).SingleOrDefault();
                Benefici b0 = dataContext.Beneficis.Where(x => x.Id == b).SingleOrDefault();

                c0.Beneficis.Add(b0);
                
                dataContext.SaveChanges();
                return GetActivitatDirigida(c);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT ActivitatDirigida delete Benefici
        public static ActivitatDirigida UpdateActivitatDirigidaDeleteBenefici(int c, int b)
        {
            try
            {
                ActivitatDirigida c0 = dataContext.ActivitatDirigidas.Where(x => x.Id == c).SingleOrDefault();
                Benefici b0 = dataContext.Beneficis.Where(x => x.Id == b).SingleOrDefault();

                c0.Beneficis.Remove(b0);

                dataContext.SaveChanges();
                return GetActivitatDirigida(c);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT Benefici
        public static Benefici UpdateBenefici(Benefici c)
        {
            try
            {
                Benefici c0 = dataContext.Beneficis.Where(x => x.Id == c.Id).SingleOrDefault();
                if (!String.IsNullOrEmpty(c.descripcio)) c0.descripcio = c.descripcio;

                dataContext.SaveChanges();
                return GetBenefici(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT DiaNoHabil
        public static DiaNoHabil UpdateDiaNoHabil(DiaNoHabil c)
        {
            try
            {
                DiaNoHabil c0 = dataContext.DiaNoHabils.Where(x => x.Id == c.Id).SingleOrDefault();
                if (!String.IsNullOrEmpty(c.data)) c0.data = c.data;
                if (!String.IsNullOrEmpty(c.motiu)) c0.motiu = c.motiu;
                if (!String.IsNullOrEmpty(c.horari)) c0.horari = c.horari;

                dataContext.SaveChanges();
                return GetDiaNoHabil(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT Esdeveniments
        public static Esdeveniment UpdateEsdeveniment(Esdeveniment c)
        {
            try
            {
                Esdeveniment c0 = dataContext.Esdeveniments.Where(x => x.Id == c.Id).SingleOrDefault();
                if (!String.IsNullOrEmpty(c.titol)) c0.titol = c.titol;
                if (!String.IsNullOrEmpty(c.data)) c0.data = c.data;
                if (!String.IsNullOrEmpty(c.descripcio)) c0.descripcio = c.descripcio;
                if (!String.IsNullOrEmpty(c.lloc)) c0.lloc = c.lloc;
                if (!String.IsNullOrEmpty(c.tipus)) c0.tipus = c.tipus;
                if (!String.IsNullOrEmpty(c.image)) c0.image = c.image;

                dataContext.SaveChanges();
                return GetEsdeveniment(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT Sala
        public static Sala UpdateSala(Sala c)
        {
            try
            {
                Sala c0 = dataContext.Salas.Where(x => x.Id == c.Id).SingleOrDefault();
                if (!String.IsNullOrEmpty(c.nom)) c0.nom = c.nom;
                if (!String.IsNullOrEmpty(c.codi)) c0.codi = c.codi;
                if (!String.IsNullOrEmpty(c.image)) c0.image = c.image;
                c0.aforament = c.aforament;

                dataContext.SaveChanges();
                return GetSala(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT Sessio
        public static Sessio UpdateSessio(Sessio c)
        {
            try
            {
                Sessio c0 = dataContext.Sessios.Where(x => x.Id == c.Id).SingleOrDefault();
                c0.Hora_Id = c.Hora_Id;
                c0.Dia_Id = c.Dia_Id;
                c0.Treballador_Id = c.Treballador_Id;
                c0.ActivitatsDirigide_Id = c.ActivitatsDirigide_Id;
                c0.Sale_Id = c.Sale_Id;

                dataContext.SaveChanges();
                return GetSessio(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT Soci
        public static Soci UpdateSoci(Soci c)
        {
            try
            {
                Soci c0 = dataContext.Socis.Where(x => x.Id == c.Id).SingleOrDefault();
                if (!String.IsNullOrEmpty(c.nom)) c0.nom = c.nom;
                if (!String.IsNullOrEmpty(c.cognoms)) c0.cognoms = c.cognoms;
                if (!String.IsNullOrEmpty(c.dni)) c0.dni = c.dni;
                if (!String.IsNullOrEmpty(c.correu)) c0.correu = c.correu;
                if (!String.IsNullOrEmpty(c.naixement)) c0.naixement = c.naixement;

                dataContext.SaveChanges();
                return GetSoci(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // PUT Treballador
        public static Treballador UpdateTreballador(Treballador c)
        {
            try
            {
                Treballador c0 = dataContext.Treballadors.Where(x => x.Id == c.Id).SingleOrDefault();
                if (!String.IsNullOrEmpty(c.nom)) c0.nom = c.nom;
                if (!String.IsNullOrEmpty(c.cognoms)) c0.cognoms = c.cognoms;
                if (!String.IsNullOrEmpty(c.dni)) c0.dni = c.dni;
                if (!String.IsNullOrEmpty(c.correu)) c0.correu = c.correu;
                if (!String.IsNullOrEmpty(c.naixement)) c0.naixement = c.naixement;
                if (!String.IsNullOrEmpty(c.image)) c0.image = c.image;
                c0.CategoriaProfesional_Id = c.CategoriaProfesional_Id;

                dataContext.SaveChanges();
                return GetTreballador(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion
        #region POST
        // POST ActivitatDirigida
        public static ActivitatDirigida InsertActivitatDirigida(ActivitatDirigida c)
        {
            try
            {
                dataContext.ActivitatDirigidas.Add(c);
                dataContext.SaveChanges();
                return GetActivitatDirigida(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST Admin
        public static Admin InsertAdmin(Admin c)
        {
            try
            {
                dataContext.Admins.Add(c);
                dataContext.SaveChanges();
                return GetAdmin(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST Benefici
        public static Benefici InsertBenefici(Benefici c)
        {
            try
            {
                dataContext.Beneficis.Add(c);
                dataContext.SaveChanges();
                return GetBenefici(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST CategoriaActivitat
        public static CategoriaActivitat InsertCategAct(CategoriaActivitat c)
        {
            try
            {
                dataContext.CategoriaActivitats.Add(c);
                dataContext.SaveChanges();
                return GetCategAct(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST CategoriaProfesional
        public static CategoriaProfesional InsertCategProf(CategoriaProfesional c)
        {
            try
            {
                dataContext.CategoriaProfesionals.Add(c);
                dataContext.SaveChanges();
                return GetCategProf(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST DiaNoHabil
        public static DiaNoHabil InsertDiaNoHabil(DiaNoHabil c)
        {
            try
            {
                DiaNoHabil s = dataContext.DiaNoHabils.Where(x => x.data.Equals(c.data)).SingleOrDefault();
                if (s == null)
                {
                    dataContext.DiaNoHabils.Add(c);
                    dataContext.SaveChanges();
                    return GetDiaNoHabil(c.Id);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST Esdeveniment
        public static Esdeveniment InsertEsdeveniment(Esdeveniment c)
        {
            try
            {
                dataContext.Esdeveniments.Add(c);
                dataContext.SaveChanges();
                return GetEsdeveniment(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST Sala
        public static Sala InsertSala(Sala c)
        {
            try
            {
                dataContext.Salas.Add(c);
                dataContext.SaveChanges();
                return GetSala(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST Sessio
        public static Sessio InsertSessio(Sessio c)
        {
            try
            {
                Sessio s = dataContext.Sessios.Where(x => x.Dia_Id == c.Dia_Id && x.Hora_Id == c.Hora_Id && (x.Sale_Id == c.Sale_Id || x.Treballador_Id == c.Treballador_Id)).SingleOrDefault();
                if (s == null)
                {
                    dataContext.Sessios.Add(c);
                    dataContext.SaveChanges();
                    return GetSessio(c.Id);
                }
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST Soci
        public static Soci InsertSoci(Soci c)
        {
            try
            {
                dataContext.Socis.Add(c);
                dataContext.SaveChanges();
                return GetSoci(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        // POST Treballador
        public static Treballador InsertTreballador(Treballador c)
        {
            try
            {
                dataContext.Treballadors.Add(c);
                dataContext.SaveChanges();
                return GetTreballador(c.Id);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        #endregion
        #region DELETE
        // DELETE ActivitatDirigida
        public static void DeleteActivitatDirigida(int id)
        {
            ActivitatDirigida c = dataContext.ActivitatDirigidas.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.ActivitatDirigidas.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE Admin
        public static void DeleteAdmin(int id)
        {
            Admin c = dataContext.Admins.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.Admins.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE Benefici
        public static void DeleteBenefici(int id)
        {
            Benefici c = dataContext.Beneficis.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.Beneficis.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE CategoriaActivitat
        public static void DeleteCategAct(int id)
        {
            CategoriaActivitat c = dataContext.CategoriaActivitats.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.CategoriaActivitats.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE CategoriaProfesional
        public static void DeleteCategProf(int id)
        {
            CategoriaProfesional c = dataContext.CategoriaProfesionals.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.CategoriaProfesionals.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE DiaNoHabil
        public static void DeleteDiaNoHabil(int id)
        {
            DiaNoHabil c = dataContext.DiaNoHabils.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.DiaNoHabils.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE Esdeveniment
        public static void DeleteEsdeveniment(int id)
        {
            Esdeveniment c = dataContext.Esdeveniments.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.Esdeveniments.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE Sala
        public static void DeleteSala(int id)
        {
            Sala c = dataContext.Salas.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.Salas.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE Sessio
        public static void DeleteSessio(int id)
        {
            Sessio c = dataContext.Sessios.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.Sessios.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE Soci
        public static void DeleteSoci(int id)
        {
            Soci c = dataContext.Socis.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.Socis.Remove(c);
                dataContext.SaveChanges();
            }
        }
        // DELETE Treballador
        public static void DeleteTreballador(int id)
        {
            Treballador c = dataContext.Treballadors.Where(x => x.Id == id).SingleOrDefault();
            if (c != null)
            {
                dataContext.Treballadors.Remove(c);
                dataContext.SaveChanges();
            }
        }
        #endregion
    }
}