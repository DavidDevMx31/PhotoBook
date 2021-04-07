# PhotoBook
This is a web app that shows a collection of photo albums.

# Introduction
This is a web app to showcase photos. The user can look all the photos uploaded or check them by album.

# Overview
The main page shows the list of all the photo albums. The list displays the name of the albums, the author and the creation date.

Click on the "Álbumes" option or the "PhotoBook" label in the menu to go back to this page.

![Albums](/Images/AlbumsView.jpg)

By clicking on the "Ver álbum" button, you can take a look of all the photos in the selected album.

![Album Photos](/Images/PhotoAlbumsView.jpg)

Click on a photo to see it bigger

![Photo View](/Images/PhotoView.jpg)

Click on the "Fotos" option of the menu to show the list of all the photos.

![Photos](/Images/AllPhotosView.jpg)

### Architecture
The code is organized in a 3-tier architecture:
* The AlbumsWebAppMVC project contains the UI of the solution.
* The AlbumsWebAppMVC.Domain project contains the business logic. It also defines the interfaces that the UI and data repositories must implement in order to communicate with the business layer.
* The AlbumsWebAppMVC.Data contains the data. In this case, the list of albums and photos is hard-coded.

All the dependencies needed by a class in order to show the information are provided via its constructor. Since this is a simple example, I'm not using any IoC Container to implement DI. Both controller constructors create all the required dependencies.


# Technologies
* C#
* Javascript
* HTML
* CSS
* Bootstrap
* MVC

# Requirements
The destination framework of the solution is .Net 4.6
