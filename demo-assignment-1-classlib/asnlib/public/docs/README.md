<header>

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://bootswatch.com/4/cerulean/bootstrap.css" media="screen">
<link rel="stylesheet" href="https://bootswatch.com/_assets/css/custom.min.css">
<link rel="stylesheet" href="./vocareum.css">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

</header>

# C# Lab Assignment

## Intro to cloud lab environment

Each assignment entered from RevaturePro via the **Go to lab** button will take you to an environment like this one. Each assignment's environment is separate from the next, so it's fine to work on more than one before finishing the first.

Here you have access to the files you need to create or edit via an Ubuntu Linux virtual machine. There is an IDE for developing your solutions, as well as a desktop environment when some visual output is important (like for ASP.NET Core MVC), and both use the same file system. The assignment will usually be completed in the `~/assignment` directory.

As long as your files are saved, you can safely close the tab and the files will be available the next time you visit the assignment from RevaturePro.

Unless the readme says otherwise, you can submit an assignment as many times as you like. Each time, it will take ~20-30 seconds for the grade and grading report to be updated. Your most recent submission is the one that counts.

### Interface

On the right is this readme. It can be accessed again at any time from the **Readme** button at top right. It will contain the directions for the selected assignment.

On the left is [Theia](https://theia-ide.org/). This is an IDE running in the browser based on [Visual Studio Code](https://code.visualstudio.com/). The basics of the interface are the same as in VS Code, and you can expect keyboard shortcuts to work similarly, even in the browser, so long as the editor is in focus. The editor has the home directory `~` open.

At the top left, the **desktop** button allows you to enter a desktop environment. This allows you to use other applications as part of your development, including a web browser and VS Code itself.

## Goal

Your assignment is to implement an `IsPrime` method and unit tests for it.

Code coverage should be 100% for the `Prime.Service` project based on the `Prime.Tests` test project.

## Technologies

- .NET Core
- xUnit

## Directory structure

Our starter code contains the skeleton source and test projects:
```
assignment/
    assignment.sln
    Prime.Service/
        PrimeService.cs
        Prime.Service.csproj
    Prime.Tests/
        PrimeServiceTests.cs
        Prime.Tests.csproj
```

You will be responsible for completing the implementation in `PrimeService.cs` and adding unit tests to `PrimeServiceTests.cs`.

## Running your tests

Go to the `assignment` directory and run:

```
dotnet test --collect "xplat code coverage"
```

This uses the [coverlet.collector](https://github.com/coverlet-coverage/coverlet) package to calculate code coverage. The code coverage results will be generated in an XML file in a `Prime.Tests/TestResults` subdirectory. The line-rate given on the second line of that file is what counts.

## Submitting your work

Your code will be run against both your test project and a hidden test project named `Prime.Grader`. All tests must pass to receive a passing score. Code coverage will be computed based on the `Prime.Tests` project only.

When you are ready, click the **SUBMIT** button.

Please wait a minute or two, then click "Grade" to see your score.

You may also click "Grading Report" to get additional details.
