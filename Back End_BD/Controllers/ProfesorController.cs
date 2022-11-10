using Back_End_BD.Models;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_End_BD.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Alumnos
        public ActionResult IndexProfe()
        {
            using (ProfesorDbContext dbProfesor = new ProfesorDbContext())
                //select * from profesores;
                return View(dbProfesor.Profesores.ToList());
        }
    }
}