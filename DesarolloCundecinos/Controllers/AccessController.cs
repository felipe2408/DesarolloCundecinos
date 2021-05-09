using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesarolloCundecinos.Models;
namespace _12.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

        public ActionResult Ingresar(string usuario, string password)
        {

            try
            {
                using (CundecinosEntities db = new CundecinosEntities())
                {
                    var lst = from d in db.usuarios
                              where d.email  ==  usuario && d.password  ==  password && d.IdState==1
                              select d;
                    if (lst.Count()>0)
                    {

                        Session["User"] = lst.First();

                        return Content("1");
                    }
                    else
                    {

                        return Content("¡Ouch al parecer tu clave o usuario es incorrecto! :(");
                    }
                }
                    return Content("1");
                 
            }
            catch (Exception ex)
            {

                return Content("¡Ouch! lo sentimos " + ex.Message);

            }

        }

        public ActionResult IraRegistrar()
        {
            return Content("1");
        }
        public ActionResult iralogin()
        {
            return Content("1");
        }
    }
}