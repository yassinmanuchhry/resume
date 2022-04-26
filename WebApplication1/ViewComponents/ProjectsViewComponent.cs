using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class ProjectsViewComponent  : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(id:1,name:"نرم افزار  حسابداری",description:"برای ثبت فاکتور و مشتری در انواع فروشگاه",image:"project-1.jpg",client:"اولین پروژه من"),
                new Project(id:2,name:"تاکسی",description:"درخواست تاکسی برای سفرهای درون شهری",image:"project-2.jpg",client:"همسایه"),
                new Project(id:3,name:"نرم افزار  حسابداری",description:"برای ثبت فاکتور و مشتری در انواع فروشگاه",image:"project-3.jpg",client:"اولین پروژه من"),
                new Project(id:4,name:"شبکه پیام رسان",description:"شبکه پیام رسان اجتماعی",image:"project-4.jpg",client:"اولین پروژه من"),

            };
            return View("_Projects",projects);
        }
    }
}
