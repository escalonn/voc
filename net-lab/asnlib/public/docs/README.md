<header>

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
<link rel="stylesheet" href="https://bootswatch.com/4/cerulean/bootstrap.css" media="screen">
<link rel="stylesheet" href="https://bootswatch.com/_assets/css/custom.min.css">
<link rel="stylesheet" href="./vocareum.css">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

</header>

# Unit testing C# in .NET Core using dotnet test and xUnit

(Adapted from https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)


## Goal

Your assignment is to implement an IsPrime method.


## Directory structure

Our starter code contains the skeleton source and test projects: 
```
/assignment
    assignment.sln
    /PrimeService
        PrimeService.cs
        PrimeService.csproj
    /PrimeService.Tests
        PrimeService_IsPrimeShould.cs
        PrimeServiceTests.csproj
```

You will be responsible for updating the code in *PrimeService.cs*.  You should update the xUnit test harness to check your work.

## Running the test

Go to the *assignment* directory and run:

```
dotnet test
```

## Submitting your work

When you are ready, click the **SUBMIT** button.  

Please wait a minute or two, then click "Grade" to see your score.

You may also click "Grading Report" to get additional details.



## ANSWER

```
using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
```