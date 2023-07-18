using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public class Student
        {
            //假model
            public string id { get; set; }
            public string name { get; set; }
            public int score { get; set; }

            //預設的建構子，在宣告物件的時候就帶入值
            public Student()
            {
                id = string.Empty;
                name = string.Empty;
                score = 0;
            }

            //建構子，在宣告物件的時候就帶入值
            public Student(string _id, string _name, int _score)
            {
                id = _id;
                name = _name;
                score = _score;
            }

            //宣告ToString()方法，在C#當中所有的物件都可以使用ToString()方法
            //將原本定義的ToString()覆蓋過去，就可以按自己要的方式來顯示內容
            public override string ToString()
            {
                return $"學號:{id}, 姓名:{name}, 分數:{score}.";
            }
        }

        public ActionResult Index()
        {

            //ViewBag總共傳了三個物件，第一個是C#預設的DateTime物件
            DateTime date = DateTime.Now;
            ViewBag.Date = date;

            //ViewBag第二個傳送物件
            Student data = new Student();
            ViewBag.Student = data;

            //ViewBag第三個傳送物件
            List<Student> list = new List<Student>();
            list.Add(new Student("1", "小明", 80));
            list.Add(new Student("2", "小華", 70));
            list.Add(new Student("3", "小英", 60));
            list.Add(new Student("4", "小李", 50));
            list.Add(new Student("5", "小張", 90));
            ViewBag.List = list;




            return View();
        }
    }
}