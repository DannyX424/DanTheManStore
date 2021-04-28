![icon](https://github.com/DannyX424/DanTheManStoreSln)
[url](https://CampingStuff.azurewebsites.net)

# DanTheManSln
This is a build of the demo MVC app from Adam Freeman's ASP.NET Core 3 textbook. This is for demonstration purpose.

## link
[https://www.apress.com/gp/book/9781484254394.](https://www.apress.com/gp/book/9781484254394.)

## Build Script

    dotnet new globaljson --sdk-version 5.0.201 --output DanTheManSln/CampingStuff
    dotnet new web --no-https --output DanTheManSln/CampingStuff --framework net5.0
    dotnet new sln -o DanTheManSln
    dotnet sln DanTheManSln add DanTheManSln/CampingStuff
    dotnet new xunit -o DanTheManSln/CampingStuff.Tests --framework net5.0
    dotnet sln DansStoreSln add DanTheManSln/CampingStuff.Tests 
    dotnet add DanTheManSln/CampingStuff.Tests reference DanTheManSln/CampingStuff
    

