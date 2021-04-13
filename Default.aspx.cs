using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlEmpleados
{
    public partial class _Default : Page
    {
        static List<University> universities = new List<University>();
        static List<Student> students = new List<Student>();

        string universityFiles = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if( !IsPostBack)
            {
                universityFiles = Server.MapPath("Control de alumnos.json");
                if( validateFiles() )
                {
                    using( StreamReader rd = new StreamReader(universityFiles) )
                    {
                        universities = JsonConvert.DeserializeObject<List<University>>(rd.ReadToEnd());
                    }
                }
                else
                {
                    File.Create(universityFiles);
                }
            }
            if (universities == null)
            {
                universities = new List<University>();
            }
        }

        protected bool validateFiles()
        {
            return File.Exists(universityFiles);
        }

        protected void saveAll()
        {
            universityFiles = Server.MapPath("Control de alumnos.json");
            using( StreamWriter sr = new StreamWriter(universityFiles) )
            {
                sr.Write(JsonConvert.SerializeObject(universities));
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = TextBox1.Text;

            students.Add(student);
            TextBox1.Text = "";
        }

        protected void ButtonUniversidad_Click(object sender, EventArgs e)
        {
            University university = new University();
            university.university = DropDownList1.SelectedValue;
            university.Students = students.ToList();

            universities.Add(university);
            saveAll();
            students.Clear();
        }
    }
}