# CSharpCalculator

A simple c# console calculator to demonstrate Continuous Integration via Github Workflow Action see .github/workflows.
Each PR will trigger an action to build and tests the PR. This uses the Github's hosted machine to run the builds.

## Building and testing the project

In your project directory (where your .csproj file is located), run the following command to restore packages:


### For build:

 ```bash
    > cd CsharpCalculator
    > dotnet restore
    > dotnet build

```

### For testing:

```bash
   > cd "CsharpCalculator Tests"
   > dotnet restore
   > dotnet build
   > dotnet test
```

### deleting files:

```bash
   > del /q /s CSharpCalculator\bin
   > del /q /s CSharpCalculator\obj
```
