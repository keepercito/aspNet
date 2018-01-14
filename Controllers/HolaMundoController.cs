using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HolaMundo.Controllers
{
    public class HolaMundoController : Controller
    {
        //GET: /HolaMundo/
        public IActionResult index(){
            return View();
        }

        //GET: /HolaMundo/Welcome
        //Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1){
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}