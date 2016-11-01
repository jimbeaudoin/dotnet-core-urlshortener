# .NET Core URL Shortener 

This project uses MSSQL, `Code First Migrations` and is still a work in progress.

You need to execute the command `Update-Database` before launching the API for the first time. 

### Development Stage: Alpha

This project is in alpha stage and can drastically change at anytime. The initial database schema can also change at anytime.

This project can now shorten URLs and redirect users who use them.

### Project folders

  * [Url Shortener API](src/UrlShortenerApi)
  * [Url Shortener Lib](src/UrlShortenerLib)
  * [Url Shortener Web Client](src/UrlShortenerApi/wwwroot)

### How to run the project

To run the project, clone this repo and open the solution in Visual Studio 2015.

Execute the command `Update-Database` from the Package Manager Console before launching the project for the first time.

For this development stage, the API also act as a static assets server and the web client is currently serve 
from the API wwwroot folder.

You can start the project like usual and enter new URLs using the web client and your browser.
This project is configured to launch the web client in a web browser automatically.
