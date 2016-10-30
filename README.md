# .NET Core URL Shortener 

This project uses `Code First Migrations` and is still a work in progress.

You need to execute the command `Update-Database` before launching the API for the first time.

### Development Stage: Alpha

This project is in alpha stage and can drastically change at anytime. The initial database schema can also change at anytime.

### How to add URLs

With Postman, `POST` the following raw data as `JSON (application/json)` to `api/urls`:
```
{
	"longFormat": "https://google.com"	
}
```