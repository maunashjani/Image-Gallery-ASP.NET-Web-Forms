<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddImage.aspx.cs" Inherits="ImageGallery.AddImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Image</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script>
        function successalert() {
            swal({
                title: 'Add Image!',
                text: 'Image Added Successfully.',
                type: 'success'
            }).then(() => {
                window.location.href = "Gallery.aspx";
            });

        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="text-center">Add Image</h1>
            <br />
            <br />

            <div class="row">

                <div class="col-md-9">
                    <div class="row">
                        <div class="col-md-2">Image File:</div>
                        <div class="col-md-5">
                            <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                        </div>
                        <div class="col-md-5">
                            <asp:Button ID="btnUpload" CssClass="btn btn-primary" runat="server" Text="Upload" OnClick="btnUpload_Click" />
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-2">Image Caption:</div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtCaption" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-2">Image Category:</div>
                        <div class="col-md-6">
                            <asp:TextBox ID="txtCategory" CssClass="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-2">
                            <asp:Button ID="btnSubmit" CssClass="btn btn-success" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                </div>

                <div class="col-md-3">
                    <asp:Image ID="Image1" Width="300px"  Height="300px" ImageUrl="https://placehold.it/300x300?text=NoImage" runat="server" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
