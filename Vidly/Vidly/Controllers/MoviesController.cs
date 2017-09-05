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
        // More about Action Results   

        // GET: movies/random
        public ActionResult random()
        {
            var movie = new Movie() { Name = "Otoman" };

            // return View(movie);
            // return Content("Hello world");
            //return HttpNotFound();
            //return new EmptyResult();

            return RedirectToAction("index", "home", new { page = "users", orderby = "date" });

        }


        /* More about Action Parameter  
         *    Parameter sources(Parametr binding)
         *    
         *   In the URL : movies/edit/1
         *   
         *   In the query string: /movies/edit/?id=1
         *   
         *   In the form data: id=1
         * 
         */
        public ActionResult Edit(int id)
        {

            return Content("id=" + id);
        }


        /* More about optional Parameter  
         *    Parameter sources(Parametr binding)
         *    
         *   In the URL : movies/edit/1
         *   
         *   In the query string: /movies/edit/?id=1
         *   
         *   In the form data: id=1
         * 
         */
        public ActionResult Index(int? pageIndex, string sortby)
        {

            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(String.Format("pageIndex={0}&sortby={1}", pageIndex, sortby));
        }
        /* More about custom url Parameters  
         *    Parameter sources(Parametr binding)
         *    
         *   In the URL : movies/edit/1
         *   
         *   In the query string: /movies/edit/?id=1
         *   
         *   In the form data: id=1
         * 
         */
          


        //Without contrains
        //[Route("movies/released/{year}/{month}")]

        /*With contraints 
         * (
         *    For more contraints google "ASP.NET MVC Attribute Route Contraints"        
         * )       
         */
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]       
        public ActionResult ByReleaseDate(int year, int month){

           
              if(month.ToString().Length > 2){
                  return HttpNotFound();
              }

            return Content(String.Format("year={0}&month={1}", year, month));
        }

        public ActionResult List(){

            var movie = new Movie() { Name = "Otoman" };
           return View(movie);
        }

    }
}