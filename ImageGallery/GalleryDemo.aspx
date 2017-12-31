<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GalleryDemo.aspx.cs" Inherits="ImageGallery.GalleryDemo" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Gallery Demo</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <link href="plugins/fancybox/jquery.fancybox.min.css" rel="stylesheet" />
    <script src="plugins/fancybox/jquery.fancybox.min.js"></script>

    <style>
        .gallery {
            display: inline-block;
            margin-top: 20px;
        }
    </style>

    <script>
        $(document).ready(function () {
            $(".fancybox").fancybox();
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">

        <!-- Gallery Start -->

        <div class="container">
            <div class="row">

                <div class="text-center col-md-12">
                    <h1>Gallery</h1>
                </div>

                <!-- list-group Start -->
                <div class='list-group gallery'>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </div>
                <!-- list-group End -->
            </div>
        </div>
        <!-- Gallery End -->
    </form>
</body>
</html>
