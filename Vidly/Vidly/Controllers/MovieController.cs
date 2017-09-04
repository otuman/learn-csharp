using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

/*                               Action Results   
 * 
 *           Type                                    Helper Methods
 *           
 *           ViewResult                             View()
 *           PartialViewResult                      PartialView()
 *           ContentResult                          Content()
 *           RedirectResult                         Redirect()
 *           RedirectToRouteResult                  RedirectToAction()
 *           JsonResult                             Json()
 *           FileResult                             File()
 *           HttpNotFoundResult                     HttpNotFound()
 *           EmptyResult
 * 
 */

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: movies/random
        public ActionResult random(){
            var movie = new Movie() { Name = "Otoman" };

           // return View(movie);
           // return Content("Hello world");
            return HttpNotFound();

        }
    } 
}