using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class ArticalsViewComponent :ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            var articals = new List<Artical>
            { 
              new Artical(id:1,title:"آموزش c#",description:"آموزش زبان برنامه نویسی",image:"blog-post-thumb-1.jpg"),
              new Artical(id:2,title:" Asp.netCoreآموزش ",description:"آموزش زبان برنامه نویسی",image:"blog-post-thumb-2.jpg"),
              new Artical(id:3,title:"آموزش Asp.Net Mvc",description:"آموزش زبان برنامه نویسی",image:"blog-post-thumb-3.jpg"),
              new Artical(id:4,title:"آموزش Flutter",description:"آموزش زبان برنامه نویسی",image:"blog-post-thumb-4.jpg"),
            };
            return View("_Artical", articals);
        }
    }
}
