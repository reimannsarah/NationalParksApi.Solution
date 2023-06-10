# National Parks Api

### By Sarah Reimann

## Description

lorem ipsum

## Technologies User

* C#
* .NET
* .ASP.NET CORE
* MVC
* Entity Framework Core
* EF Core Migrations
* Swashbuckle
* Swagger
* MySQL

## Database Structure
![photo of SQL designer](./NationalParksAPI/wwwroot/imgs/schema.png)

## Instructions to set up database
1. Clone this repo.
2. Open your terminal (e.g. Terminal or GitBash) and navigate to this project's directory called "NationalParksApi".
3. Set up the project:
  * Create a file called 'appsettings.json' in NationalParksApi.Solution/NationalParksApi directory
  * Add the following code to the appsettings.json file:
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=[YOUR_SQL_USER_ID];pwd=[YOUR_SQL_PASSWORD];"
    }
  }
  ```
  * Make sure to plug in your SQL user id and password at ```[YOUR_SQL_USER_ID]``` and ```[YOUR_SQL_PASSWORD]```
4. Set up the database:
  * Make sure EF Core Migrations is installed on your computer by running ```dotnet tool install --global dotnet-ef --version 6.0.0```
  * In the production folder of the project (NationalParksApi.Solution/NationalParksApi) run:
  ```
  dotnet ef database update
  ```
  * You should see the new schema in your _Navigator > Schemas_ tab of your MySql Workbench on refresh called ```national_parks```


## Using This Api

* Endpoints for **v1.0** are as follows:

```
National Parks:
GET https://localhost:7158/api/v1/natlparks/
GET https://localhost:7158/api/v1/natlparks/{id}
PUT https://localhost:7158/api/v1/natlparks/{id}
DELETE https://localhost:7158/api/v1/natlparks/{id}

States:
GET https://localhost:7158/api/v1/states/
GET https://localhost:7158/api/v1/states/{id}
PUT https://localhost:7158/api/v1/states/{id}
DELETE https://localhost:7158/api/v1/states/{id}

```

* Endpoints for **v2.0** are as follows:
```
National Parks (same as v1):
GET https://localhost:7158/api/v2/natlparks/
GET https://localhost:7158/api/v2/natlparks/{id}
PUT https://localhost:7158/api/v2/natlparks/{id}
DELETE https://localhost:7158/api/v2/natlparks/{id}

States:
GET https://localhost:7158/api/v2/states/
GET https://localhost:7158/api/v2/states/{id}
PUT https://localhost:7158/api/v2/states/{id}
DELETE https://localhost:7158/api/v2/states/{id}

```

* In your terminal, navigate to the project directory and run ```dotnet watch run``` 
* In your broswer, open https://localhost:7292/swagger/index.html
* user the GUI to navigate the API

* Query Parameters for a GET Request on **Countries**: 

| Parameter  | Type   | Required     | Description                                      | Sample Url  |
|----------- |-----   | ---------    | -------------                                    | ----------  |
| NatlParks | Name | not required | Returns State with a matching name value and includes all National Parks in that state | https://localhost:5001/api/countries |

## Known bugs

## License

MIT License

Copyright (c) 2023 Sarah Reimann

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.