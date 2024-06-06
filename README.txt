Akhil Jose(0852792)
Web app created on C#.NET


1335
After running the program, we confirmed that the default program is working
https://localhost:7093/
The index.cshtml is modified title to MVC MOVIE by replacing the default title WELCOME
README.txt is created for documentation.
Ran the application again to confirm the changes


1340
Confirmed Part1 is completed and Part 2 is started
Part2 - Addinng a Controller

1350
Put the default index method in comment
A new index method is added and modified the content to "This is my default action..."
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld

1405
Another method welcome is addded and the content is modified as "This is the Welcome action method..."
Ran the machine and we confirmed that the change was successfull.
URL 
https://localhost:7093/HelloWorld/Welcome

1413
Modified the Welcome method to with two parameters(name,numtimes)
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld/Welcome?name=Akhil&numtimes=4

1435
Modified the Welcome method and changed the parameters(name,id)
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld/Welcome/10?name=akhil

2024/23/05
1340
Changing welcome method without sending any parameter through URL
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld/welcome/

1400
Part 2 is completed and  Part 3 is initiated
In the HelloWorldController class, modify the Index method to return a view.
A new folder named HelloWorld is added under the Views folder.
Added  Razor View - Empty page called Index.cshtml under HelloWorld folder
Modified the contents of the Views/HelloWorld/Index.cshtml
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld

1430
Open the Views/Shared/_Layout.cshtml file
Replaced the MvcMovie to Movie App.
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld

1445
Checked working of Privacy link. The title on the browser tab displays Privacy Policy - Movie App instead of Privacy Policy - MvcMovie
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/Home/Privacy

1500
Changed the Viewdata Title from Movie App to Movie List
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld

1600
Created a Welcome view template named Views/HelloWorld/Welcome.cshtml
Then modified the Welcome.cshtml with a welcome message.
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/HelloWorld/Welcome?name=Akhil&numtimes=18

2100
Part 3 is completed and Part 4 is started
Adding a data model class named Movie.cs
Adding a new Scaffolded Item MVC Controller with views.
The scaffolding tool is used to produce Create, Read, Update, and Delete pages for the movie model.
Confirmed the pages and methods created(A movies controller:MoviesController.cs; View Pages: Create, Delete, Details, Edit, and Index; database context class: Data/MvcMovieContext.cs)

2024/23/05
1337
Created the database by adding Migrations feature
Checked the generated database connection string in appsettings.json file
Checked the Migrations 20240530052822_InitialCreate.cs migration file:
Confirmed with table creation called Movie.
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/Movies
https://localhost:7093/Movies/Create
https://localhost:7093/Movies/Edit/6
https://localhost:7093/Movies/Delete/6
https://localhost:7093/Movies/Details/6


1440
Starting part5
Checked the database by opening SQL Server Object Explorer (SSOX).
Create a new class named SeedData in movie model
Replace the contents of Program.cs
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/Movies

1500
Starting part6
add a blank space in Release data heading by editing Movie model class called Movie
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/Movies


2024/30/05
Starting part7
1350
Adding Filter tab to the Index action method that lets to search movies by name.
Index method is updated which found inside Controllers/MoviesController.cs
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/Movies/Index?searchString=Ghost

1402
Change the search parameter to id and change all occurrences of searchString to id.
The updated Index method inside Controllers/MoviesController.cs with id parameter
https://localhost:7093/Movies/Index/ghost

1410
add UI elements to help filter movies.
Added the <form> markup in the Views/Movies/Index.cshtml file
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/Movies

1415
Filter form submited with HTTP GET method
Observed the changes in the URL
Ran the machine and we confirmed that the change was successfull.
URL
https://localhost:7093/Movies?SearchString=ghost

1430
Completed Part 7 and Part 8 is initiated
A new field called Rating  is added to the Movie model.
In MoviesController.cs, [Bind] attribute is updated for both the Create and Edit action methods for the Rating property
Updated the view templates for display, create, and edit the new Rating property 
The SeedData class is updated aand the value for the new column is created
The Migrations/20240530183241_Rating.cs for the Rating field is checked
Ran the machine and we confirmed that the change was successfull.
URL
URL :Index page for the Updation of Rating field
https://localhost:7093/Movies
Display Create page for the Updation of Rating field
https://localhost:7093/Movies/Create
Display Edit page for the Updation of Rating field
https://localhost:7093/Movies/Edit/7
Display deatils page for the Updation of Rating 
https://localhost:7093/Movies/Details/7
 Part 8 is completed

 2024/06/06
1210
Part 9 started
Created advanced validation in the create field.
Ran the application and tested for validation and it was successfull
URL:
https://localhost:7093/Movies/Create
Part 9 completed.
In Part 10  we have examined the Details and Delete methods of this application as sid in the tutorial

1410
Github account is created and cloned the project Mvc Movie to the Github
