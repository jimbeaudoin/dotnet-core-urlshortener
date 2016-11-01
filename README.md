# .NET Core URL Shortener 

This project uses `Code First Migrations` and is still a work in progress.

You need to execute the command `Update-Database` before launching the API for the first time.

### Development Stage: Alpha

This project is in alpha stage and can drastically change at anytime. The initial database schema can also change at anytime.

### Project folders

  * [Url Shortener API](src/UrlShortenerApi)
  * [Url Shortener Lib](src/UrlShortenerLib)
  * [Url Shortener Web Client](src/UrlShortenerApi/wwwroot)

### How to add URLs

With Postman, `POST` the following raw data as `JSON (application/json)` to `api/urls`:
```
{
	"longFormat": "https://google.com"	
}
```
