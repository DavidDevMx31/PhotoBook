# Photo albums
This is a web app that shows a collection of photo albums.

# Introduction
This is a web app to showcase photos. The user can look all the photos uploaded or check them by album.

The code is organized in a 3-tier architecture:
* The AlbumsWebAppMVC project contains the UI of the solution.
* The AlbumsWebAppMVC.Domain project contains the business logic. It also defines the interfaces that the UI and data repositories must implement in order to communicate with the business layer.
* The AlbumsWebAppMVC.Data contains the data. In this case, the list of albums and photos is hard-coded.

All the dependencies needed by a class in order to show the information are provided via its constructor. Since this is a simple example, I'm not using any IoC Container to implement DI. Both controllers constructors create all the required dependencies.

# Technologies
* C#
* Javascript
* HTML
* CSS
* Bootstrap
* MVC

# Requirements
The destination framework of the solution is .Net 4.6
