<header>

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://bootswatch.com/4/cerulean/bootstrap.css" media="screen">
<link rel="stylesheet" href="https://bootswatch.com/_assets/css/custom.min.css">
<link rel="stylesheet" href="./vocareum.css">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

</header>

# Lab assignment 3: MVC

## Goal

Your assignment is to convert a dynamically-typed view using ViewBag to a strongly-typed view.

## Technologies

- ASP.NET Core

## Directory structure

```
assignment/
    assignment.sln
    BindViews/
        Controllers/
            HomeController.cs
        Properties/
        Views/
            Home/
                Index.cshtml
        wwwroot/
        BindViews.csproj
        Program.cs
        Startup.cs
```

You will be responsible for modifying the HomeController and the Home/Index view. Don't alter the routing or the location of the view file, or the grader tests may be unable to find them.

## Running the app

Go to the *BindViews* directory and run:

```
dotnet run
```

The app will be listening on `http://localhost:5000`. Press the **desktop** button and open the web browser to interact with it.

## Submitting your work

Your code will be run against a hidden test project named *BindViews.Grader*. All tests must pass to receive a passing score.

When you are ready, click the **Submit** button.

Please wait a minute or two, then click **Grade** to see your score.

You may also click **Grading Report** to get additional details.
