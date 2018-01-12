Image Gallery - ASP.NET Web Forms

Table:

CREATE TABLE [dbo].[Images1](
	[ImageID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[ImageURL] [nvarchar](max) NULL,
	[ImageCaption] [nvarchar](50) NULL,
	[ImageCategory] [nvarchar](50) NULL
)

1. For Add Image to database the URL of the image is stored in table Images.

2. File Upload control of ASP.NET is used to upload the file.

3. When the upload button is clicked the selected image is saved in the projects root under a folder named "images" and 
displayed in the Image control.

4. Here a jquery plugin "fancybox" is used to display image. Refer - http://fancyapps.com/fancybox/3/

5. The images are displayed with 4 image thumbnails each row using bootstrap css - col-md-3

6. There is a class named gallery with css properties display: inline-block is applied. 


