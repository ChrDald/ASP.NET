using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Student> studentList = new List<Student>
            {
                new Student {First="Bob", Last="Jones", ID=111, Age=15, Scores= new List<int> {69, 92, 81, 60}},
                new Student {First="Claire", Last="Simpson", ID=112, Age=17, Scores= new List<int> {75, 84, 83, 39}},
                new Student {First="John", Last="Feetham", ID=113, Age=21, Scores= new List<int> {65, 94, 65, 91}},
                new Student {First="Jonathan", Last="Potts", ID=114, Age=10, Scores= new List<int> {97, 83, 85, 62}},
                new Student {First="Pepe", Last="Garcia", ID=115, Age=20, Scores= new List<int> {35, 72, 91, 70}},
                new Student {First="Samantha", Last="Fakhouri", ID=116, Age=17, Scores= new List<int> {99, 86, 90, 54}},
                new Student {First="Roger", Last="Song", ID=117, Age=19, Scores= new List<int> {60, 72, 64, 45}},
                new Student {First="Hugo", Last="Garcia", ID=118, Age=15, Scores= new List<int> {92, 90, 83, 78}},
                new Student {First="Richard", Last="Ammerman", ID=119, Age=14, Scores= new List<int> {68, 79, 81, 92}},
                new Student {First="Kevin", Last="Adamson", ID=120, Age=11, Scores= new List<int> {68, 71, 81, 79}},
                new Student {First="Jeet", Last="Singh", ID=121, Age=12, Scores= new List<int> {96, 85, 91, 60}}

            };


        List<Staff> teacherList = new List<Staff>
            {
                new Staff {First="Jeet", Last="Singh", ID=900},
                new Staff {First="Richard", Last="Potter", ID=901},
                new Staff {First="Terry", Last="Woodward", ID=902},
                new Staff {First="Bob", Last="Feetham", ID=903},
                new Staff {First="Jane", Last="Feetham", ID=904},
                new Staff {First="Oliver", Last="Jones", ID=905},
                new Staff {First="Rafael", Last="Sacramento", ID=906},
                new Staff {First="John", Last="Smith", ID=907},
                new Staff {First="Pepe", Last="Garcia", ID=908}
            };

        List<Course> courseList = new List<Course>
            {
                new Course{Code="100AB",Name="Intro To Computers",Semester="Fall",Duration=15},
                new Course{Code="101AB",Name="Programming I",Semester="Winter",Duration=15},
                new Course{Code="102AB",Name="Programming II",Semester="Fall",Duration=15},
                new Course{Code="103AB",Name="Database I",Semester="Summer",Duration=5},
                new Course{Code="104AB",Name="Database II",Semester="Summer",Duration=5},
                new Course{Code="303ER",Name="Applied Mathematics",Semester="Summer",Duration=5},
                new Course{Code="304ER",Name="Pure Mathematics",Semester="Fall",Duration=15},
                new Course{Code="588A",Name="English Language",Semester="Winter",Duration=10},
                new Course{Code="589A",Name="English Literature",Semester="Winter",Duration=10},
                new Course{Code="588B",Name="More English Language",Semester="Fall",Duration=10},
                new Course{Code="589B",Name="More English Literatute",Semester="Fall",Duration=10},
                new Course{Code="123Z",Name="Basic Biology",Semester="Winter",Duration=15},
                new Course{Code="123Y",Name="Basic Chemistry",Semester="Fall",Duration=15},
                new Course{Code="123X",Name="Basic Physics",Semester="Summer",Duration=8}
            };
    
    protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
            }    
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                GridView1.DataSource = studentList;
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                GridView1.DataSource = teacherList;
            }
            else
            {
                GridView1.DataSource = courseList;
            }
            GridView1.DataBind();
        }


        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == 1)
            {
                // students under 18
                var underageStudents = from s in studentList where s.Age < 18 orderby s.Age select s;
                GridView1.DataSource = underageStudents;
                GridView1.DataBind();
            }
            else if (ListBox1.SelectedIndex == 2)
            {
                // students under 18
                var teenageStudents = from s in studentList where s.Age < 18 && s.Age > 10 orderby s.First select s;
                GridView1.DataSource = teenageStudents;
                GridView1.DataBind();
            }
            else if (ListBox1.SelectedIndex == 3)
            {
                // students who are also teachers *** not working atm
                var students80LastTest = from s in studentList where s.Scores[3] > 80 select s;
                GridView1.DataSource = students80LastTest;
                GridView1.DataBind();
            }
            else if (ListBox1.SelectedIndex == 4)
            {
                // students who are also teachers *** not working atm
                var students320Total = from s in studentList where (s.Scores[0] + s.Scores[1] + s.Scores[2] + s.Scores[3]) > 320 select s;
                GridView1.DataSource = students320Total;
                GridView1.DataBind();
            }
            else if (ListBox1.SelectedIndex == 5)
            {
                // students with at least 60 all tests
                var students60Min = from s in studentList where s.Scores[0] > 60 && s.Scores[1] > 60 && s.Scores[2] > 60 && s.Scores[3] > 60 select s;
                GridView1.DataSource = students60Min;
                GridView1.DataBind();
            }
            else if (ListBox1.SelectedIndex == 6)
            {
                // Students grouped by first letter of their last name 
                var studentsGrouped = from s in studentList group s.Last[0] by s.Last into sGroup orderby sGroup.Key select sGroup;
                GridView1.DataSource = studentsGrouped;
                GridView1.DataBind();
            }
            else if (ListBox1.SelectedIndex == 10)
            {
                // students who are also teachers *** not working atm
                var studentTeachers = from s in studentList join t in teacherList on s.Last equals t.Last select s;
                GridView1.DataSource = studentTeachers;
                GridView1.DataBind();
            }
        }
    }
}