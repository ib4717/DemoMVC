# DemoMVC, ASP.NET Core

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
└── Shared
```

## Controllers
Process incoming requests, perform operations on data provided through Models, and selects Views to render on the browser.
Every controller class name must end with a word "Controller".
For example, the home page controller name must be HomeController.

## Models
The model classes represents domain-specific data and business logic in the MVC application. It represents the shape of the data as public properties and business logic as methods.
Model class name is same as controller without "Controller" at the end.
For example, the home page model name must be Home.


## Views
A view is an HTML template with embedded Razor markup. Razor markup is code that interacts with HTML markup to produce a webpage that's sent to the client. In ASP.NET Core MVC, views are .cshtml files that use the C# programming language in Razor markup.

Create folder inside the "Views" folder with same name as controller without "Controller" at the end.
All Views of this controller will be inside this folder.
View class name is same as action in the controller.

### wwwroot
Default directory to serve static files is wwwroot
[More Information](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-6.0)

## startup.cs
Use Middleware to add more functions in the project in startup.cs
To serve static files use = app.UseStaticFiles();

## MVC Request life cycle
![MVC Request life cycyle](https://media.geeksforgeeks.org/wp-content/uploads/20220218094015/RequestLifeCycle-660x246.png)
