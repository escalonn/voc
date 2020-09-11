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

Your assignment is to complete the implementation of two REST APIs which interact together as client and server in a layered system.

The server API allows creating and accessing grocery store resources:

```
GET /api/store:
    status 200 with all the grocery stores.
    (already implemented)
POST /api/store:
    should create a store based on the request body.
    status 201 with Location header and a copy of the created store.
GET /api/store/{id}:
    status 200 with the store with the given unique integer ID.
    (already implemented)
```

The client API does not store data itself, but exposes some extra grocery store operations by communicating with the server API:

```
GET /api/store/count:
    status 200 with the number of stores existing on the server API.
    status 502 if the server API fails or is not running.
POST /api/store/createthree:
    should create three stores on the server API. no request body needed; client API can hardcode the store details.
    status 204 on success.
    status 502 if the server API fails or is not running.
```

Use media type application/json for request and response bodies.

## Technologies

- ASP.NET Core

## Directory structure

Our starter code contains one ASP.NET Core web API, the server-side, partially implemented.

```
assignment/
    assignment.sln
    ServerSide/
```

You will need to finish implementing necessary functionality in `ServerSide`, as well as create another API (`ClientSide/ClientSide.csproj`) to fulfill the requirements. Don't forget to add it to the solution.

## Running the server API

Go to the *ServerSide* directory and run:

```
dotnet run
```

The server will be listening on `http://localhost:5001`.

## Submitting your work

Your code will be run against a hidden test project named *Assignment.Grader*. All tests must pass to receive a passing score.

When you are ready, click the **Submit** button.

Please wait a minute or two, then click **Grade** to see your score.

You may also click **Grading Report** to get additional details.
