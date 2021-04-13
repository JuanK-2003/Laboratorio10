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
    public partial class Contact : Page
    {
        static List<University> universities = new List<University>();
        string universityFiles = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            universityFiles = Server.MapPath("Control de alumnos.json");

            if( validateFiles() )
            {
                using ( StreamReader rd = new StreamReader(universityFiles) )
                {
                    universities = JsonConvert.DeserializeObject<List<University>>(rd.ReadToEnd());
                }
            }
            else
            {
                File.Create(universityFiles);
            }
            if (universities == null)
            {
                universities = new List<University>();
            }
            GridView1.DataSource = universities;
            GridView1.DataBind();
        }
        protected bool validateFiles()
        {
            return File.Exists(universityFiles);
        }

        protected void ButtonCargar_Click(object sender, EventArgs e)
        {
            int selection = GridView1.SelectedIndex;

            GridView2.DataSource = universities[selection].Students;
            GridView2.DataBind();
        }
    }
}