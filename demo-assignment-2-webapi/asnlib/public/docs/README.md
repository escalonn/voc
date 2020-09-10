<header>

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://bootswatch.com/4/cerulean/bootstrap.css" media="screen">
<link rel="stylesheet" href="https://bootswatch.com/_assets/css/custom.min.css">
<link rel="stylesheet" href="./vocareum.css">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

</header>

# Lab assignment 2: API

## Goal

Your assignment is to implement a Web API which interacts with another Web API.

## Technologies

- ASP.NET Core

## Directory structure

Our starter code contains two applications implementing REST APIs, one acting as a client and the other as a server. The server is already implemented.
```
assignment/
    assignment.sln
    ClientSide/
    ServerSide/
```

You will be responsible for updating the code in *ClientSide/*.

## Running the server-side API

Go to the *ServerSide* directory and run:

```
dotnet run
```

The server will be listening on `http://localhost:61106`.

## Submitting your work

Your code will be run against a hidden test project named *ClientSide.Grader*. All tests must pass to receive a passing score.

When you are ready, click the **Submit** button.

Please wait a minute or two, then click **Grade** to see your score.

You may also click **Grading Report** to get additional details.
