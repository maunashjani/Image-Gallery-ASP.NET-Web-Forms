using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageGallery
{
    public partial class GalleryWithPagination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= CountTotalRows(); i++)
            {
                //NumberedLinkButton
                LinkButton lbtn = new LinkButton();
                lbtn.ID = "btn" + i;
                lbtn.Text = i.ToString();
                lbtn.Click += new EventHandler(lbtn_Click);

                this.Panel1.Controls.Add(new LiteralControl("<li>"));

                this.Panel1.Controls.Add(lbtn);

                this.Panel1.Controls.Add(new LiteralControl("</li>"));
            }
            
            if (!IsPostBack)
            {
                LoadImages(1);
            }
        }

        protected void lbtn_Click(object sender, EventArgs e)
        {
            LinkButton lbtn = (LinkButton)sender;

            LoadImages(Convert.ToInt32(lbtn.Text));
        }



        private int CountTotalRows()
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;";

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM dbo.Images", con);

            int rows = Convert.ToInt32(cmd.ExecuteScalar());

            Decimal d = Decimal.Divide(rows, 5);

            rows = (int)Math.Ceiling(d);

            cmd.Dispose();

            con.Close();

            return rows;
        }

        private void LoadImages(int pn)
        {
            int PageNumber = pn;
            int PageSize = 5;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;";

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Images ORDER BY ImageID OFFSET " + PageSize + " * (" + PageNumber + " - 1) ROWS FETCH NEXT " + PageSize + " ROWS ONLY OPTION (RECOMPILE);", con);
            SqlDataReader dr = cmd.ExecuteReader();

            Literal1.Text = "";

            while (dr.Read())
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