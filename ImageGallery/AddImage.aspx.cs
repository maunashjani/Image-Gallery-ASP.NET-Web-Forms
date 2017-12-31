using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageGallery
{
    public partial class AddImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;";

            con.Open();

            string query = "insert into Images (ImageURL, ImageCaption, ImageCategory) values ('" + Image1.ImageUrl + "', '" + txtCaption.Text + "', '" + txtCategory.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);

            int i = cmd.ExecuteNonQuery();

            if(i>0)
            {
                ClientScript.RegisterStartupScript(GetType(), "Popup", "successalert();", true);
            }
            else
            {
                lblInfo.Text = "There was error submitting the data. Try again.";
            }

            cmd.Dispose();

            con.Close();
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.PostedFile.FileName;
                string folder = "images/";
                string destination = Path.Combine(Server.MapPath(folder), fileName);

                FileUpload1.PostedFile.SaveAs(destination);

                Image1.ImageUrl = folder + fileName;
            }
            else
            {
                lblInfo.Text = "No file selected";
            }
        }
    }
}