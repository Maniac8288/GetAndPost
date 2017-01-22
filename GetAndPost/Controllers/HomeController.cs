using GetAndPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetAndPost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Author author)
        {

            return View(author);
        }
        [HttpPost]
        public string Array(List<string> names)
        {
            string fin = "";
            for (int i = 0; i < names.Count; i++)
            {
                fin += names[i] + ";  ";
            }
            return fin;
        }
      
       
    //Передача сложных объектов методом GET
            public string Square(Geometry geometry)
            {
                return $"Площадь треугольника с основанием {geometry.Altitude} и высотой {geometry.Height} равна {geometry.GetSquare()}";
            }
        // чтобы перейти на данный метод: /Home/Sum?geoms[0].altitude=10&geoms[0].height=3&geoms[1].altitude=16&geoms[1].height=2
        public string Sum(Geometry[] geoms)
        {
            return $"Сумма площадей равна {geoms.Sum(g => g.GetSquare())}";
        }


    }
    public class Geometry
        {
            public int Altitude { get; set; } // основание
            public int Height { get; set; } // высота

            public double GetSquare() // вычисление площади треугольника
            {
                return Altitude * Height / 2;
            }
        }


    }


       