# Animal Shelter API

### A RESTful Asp.Net Core Web API that keeps track of Animals at a shelter

### By Shaun Kent

## Technologies Used

* C#

* .NET 5.0

* Git/Github

* AspNet Core Web Api

* MySQL

* EntityCore Framework

* Swashbuckle

* Swagger

* XML Comments

## Description

An API built using Asp.Net core and C# that keeps track animals (dogs, cats, birds, etc.) at the animal shelter. The API complies with Rest design standards and offers full CRUD capabilities to the user. The API uses Swagger to show the capabilities of the API in a user friendly UI.

GET/POST: 

* `api/animals`

GET Search Query's

* Single Query search: `api/animals/?searchparam="parameter"`
* Multiple Query search: `api/animals/?firstparam="parameter"&secondparam="paramater"`

GET{id}/PUT/DELETE: 

* `api/animals/{id}`

## Setup/Instillation Requirements

* Download .NET 5.0 SDK for Windows:`https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer` 

* Download .NET 5.0 SDK for Mac: `https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer`

* Open command line in directory where you want the project stored.

* In the command line enter: `git clone https://github.com/SKona306/Animal-Shelter-Api.git`

* Open the newly cloned project directory in code editor of choice.

* Create you own database by:

1. If Needed download dotnet entityframework and Dotnet ef tool 

    * `$ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0 `
    * `$ dotnet tool install --global dotnet-ef --version 5.0.10`

2. To recreate the database enter `dotnet ef database update` in command line

* Navigage to `AnimalShelterApi` directory and create a file named `appsettings.json`

* Navigate to the `appsettings.json` file and enter: 

![Screenshot](appsettings.PNG)

* Run Application:
1. `cd` to root directory
2. In console enter: `cd AnimalShelterApi`
4. To run the project in the console enter: `dotnet run`
5. To see SwaggerUI in browser press CTRL + click http link
6. To exit program press CTRL + c

## Feature

* SwaggerUI
* XML Comments: offers ability to increase documentation about each controller path

![Screenshot](SwaggerUI.PNG)

## Future Updates

* Add PATCH route to allow partial updates to resource

* Add Authorization and Authentication capabilities (Admin and user)

## License 

[MIT](https://choosealicense.com/licenses/mit/)

## Contact Information

* shaunkent81@gmail.com