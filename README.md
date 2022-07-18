# DemoMVC

## Folder Structure
```
Application Folder
├── Controllers
├── Models
├── Views
└── wwwroot
    ├── css
    ├── js
    └── images
```

## Controllers
Process incoming requests, perform operations on data provided through Models, and selects Views to render on the browser

## Models
The model classes represents domain-specific data and business logic in the MVC application. It represents the shape of the data as public properties and business logic as methods.

## Views
A view is an HTML template with embedded Razor markup. Razor markup is code that interacts with HTML markup to produce a webpage that's sent to the client. In ASP.NET Core MVC, views are .cshtml files that use the C# programming language in Razor markup.

### wwwroot
Default directory to serve static files is wwwroot
[More Information](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-6.0)

## startup.cs
Use Middleware to add more functions in the project in startup.cs
To serve static files use = app.UseStaticFiles();