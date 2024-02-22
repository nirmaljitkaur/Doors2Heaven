Group Project: Doors2Heaven
Group name: Lambda
Group Members:3 
Saiyyam Shah- 0850021
Nirmaljit kaur- 0847848
Kinjalben Gherawada -0848290

1430
2024-02-15 

Project work Started
We all team members select the name for the Project that is Doors2Heaven. 
All team members started to gather information related to the top Doors manufactering companies in Canada. 
So, the team leader suggests combining the information of all members and selecting the top companies.

List of referred companies.
1.Jeld-Wen Windows & Doors – $288.56M | Canada. (https://www.jeld-wen.com/en-us/products/exterior-doors/browse)
2.Weather Shield Windows & Doors – $413.45M | United States. (https://weathershield.com/products/multi-slide-door-contemporary-collection/)
3.Pella Windows & Doors. (https://www.pella.com/shop/doors/patio-doors/reserve/traditional/multi-slide-patio-doors/)

1330
2024-02-16
The next step is to select the entities for the project field. After the team discussion, we decided to enter the below entities in the project which is
1. Types of doors
2. Style of doors
3. Features
4. Price
5. Material
6. Rating
7. ID


1910
2024-02-18

### Project Title:Doors2Heaven
##Part 1: Added a Controller to ASP.NET Core MVC App
Create a web application named as Doors2Heaven. After following all the steps, We run the application with ctrl+f5 button.
It successfully runs the application and displays the welcome page.


1935
2024-02-18
##Part 2: Added a Controller to ASP.NET Core MVC App....
Add a controller to an ASP.NET Core Model, Controller, View.
In Solution Explorer, right-click Controllers > Add > Controller and name it as DoorsController.cs

1945
2024-02-18
##Part 3: Added a view to an ASP.NET Core MVC app.....
Add a view to an ASP.NET Core
In this section we modify the DoorsController class to use the razor view files. To add the view we follow the following steps:
Add new item> Show all templates> Add New Item - Doors2Heaven> Razor View - Empty> Index.cshtml> Add.

Added Image and changed the welcome message with Doors2Heaven
Change views and layout pages


Passing Data from the Controller to the View

1955
2024-02-18
##Part 4: Add a model to an ASP.NET Core MVC app


Add a data model class
Right-click the Models folder > Add > Class. Name the file Doors.cs.

Add NuGet packages

In Solution Explorer, right-click the Controllers folder and select Add > New Scaffolded Item.
MVC Controller with views, using Entity Framework>Selected and Added Doors2HeavenController.cs

To get the Migration folder, select NuGet Package Manager From the Tools menu and give required command under Package Manager Console 
Then Run the app and select the Doors2Heaven and modified the data


2015
2024-02-18
##Part 5:Work with a database in an ASP.NET Core MVC app
Explored database interactions in ASP.NET Core MVC.
Worked with database and From the View menu, opened SQL Server Object Explorer (SSOX).
Right-clicked on the Doors table under dbo.Doors expanded View Designer to 
Then connected an application to a database and perform CRUD operations.
Created a new class named SeedData in the Models folder and added the necessary code

1405
2024-02-19
##Part 6: Controller Actions and Views
Get into controller actions and views. 
Then processed and displayed data in the appropriate views and Edit, Details, and Delete links are generated.

1415
2024-02-19
##Part 7:Add Search to filter:
I added a search button to check records by filter.
Then Navigated to /Doors2Heaven/Index to display filtered different kinds of doors.
Opened the Views/Doors/Index.cshtml file, and added the form markup to get the Title filter option for easy search.

1425
2024-02-19
##Part 8: Add a New Field named Rating:
Firstly, added the types of doors, styles, features, price, material and rating Property in Models/Doors.cs. 
Later, Edited the /Views/Doors/Index.cshtml file and added a Rating field inside view templates in order to display.
Updated the SeedData class so that it provides all values.
From the Tools menu, selected NuGet Package Manager > Package Manager Console In the PMC, enter the commands: add-migration -context Doors2Heaven to examine the current Doors model. 

1440
2024-02-19
##Part 9:Add Validation:
Decided applied validation to confirm data accuracy by ensuring user input and handling validation errors.
to examine the current Doors model.
Confirmed that in the Doors class required attributes exist.
In Next step, updated existing Doors list with top 5 types of Doors.

1510
2024-02-19
##Part 10: Examine Details and Delete methods:
Explored the details to check view and deletion operation.
Displayed detailed information and performed delete action.
At the end,varified the functionality of filter option by filtering specific types.

1250
2024-2-22

Added image in the background of the homepage
Added more items to the list (10)
Included product ID field
Added product column in the header and removed Door2Heaven column.
