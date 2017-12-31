using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageGallery
{
    public partial class GalleryDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                Literal1.Text += "<div class='col-sm-4 col-xs-6 col-md-3 col-lg-3'>";
                Literal1.Text += "<a data-fancybox data-caption='" + i + "' rel='ligthbox' href='https://placehold.it/500x500?text=" + i +"'>";
                Literal1.Text += "<img class='thumbnail img-responsive' alt='' src='https://placehold.it/500x500?text=" + i + "' />";
                Literal1.Text += "</a></div>";
            }
        }
    }
}