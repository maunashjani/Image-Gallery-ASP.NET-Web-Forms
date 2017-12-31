<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GalleryWithFilterDemo.aspx.cs" Inherits="ImageGallery.GalleryWithFilterDemo" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Gallery With Filter Demo</title>
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


            $(".btn-filter").click(function () {
                var value = $(this).attr('data-filter');

                if (value == "all") {
                    $('.filter').show('1000');
                }
                else {
                    $(".filter").not('.' + value).hide('3000');
                    $('.filter').filter('.' + value).show('3000');

                }
            });
        });
    </script>

</head>
<body>
    <form id="form1" runat="server">

        <!-- Gallery Start -->

        <div class="container">

            <div class="row">

                <div class="text-center col-md-12">
                    <h1>Gallery With Filter</h1>
                </div>

                <div class="text-center col-md-12">
                    <a href="#" class="btn btn-default btn-filter" data-filter="all">All</a>
                    <a href="#" class="btn btn-default btn-filter" data-filter="four">1 to 4</a>
                    <a href="#" class="btn btn-default btn-filter" data-filter="eight">5 to 8</a>
                    <a href="#" class="btn btn-default btn-filter" data-filter="twelve">9 to 12</a>
                </div>
                <br />

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
