using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ImageGallery
{
    public partial class Gallery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;";

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Images",con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                Literal1.Text += "<div class='col-sm-4 col-xs-6 col-md-3 col-lg-3'>";
                Literal1.Text += "<a data-fancybox data-caption='" + dr[2] + "' rel='ligthbox' href='" + dr[1] + "'>";
                Literal1.Text += "<img class='thumbnail img-responsive' alt='' src='" + dr[1] + "' />";
                Literal1.Text += "</a></div>";
            }

            dr.Close();

            cmd.Dispose();

            con.Close();
        }
    }
}