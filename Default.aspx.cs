using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adsdaasdaddasdsamrnjau
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Serve s = new Serve();
            TextBox2.Text=s.LatinicaUcirilicu(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Serve s = new Serve();
            TextBox1.Text=s.CirilicaULatinicu(TextBox2.Text);
        }
    }
}