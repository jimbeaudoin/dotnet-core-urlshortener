# .NET Core URL Shortener 

This project uses `Code First Migrations` and is still a work in progress.

You need to execute the command `Update-Database` before launching the API for the first time.

### How to add URLs

With Postman, `POST` the following raw data as `JSON (application/json)` to `api/urls`:
```
{
	"longFormat": "https://google.com"	
}
```