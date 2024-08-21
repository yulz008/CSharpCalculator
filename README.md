# CSharpCalculator

A simple c# console calculator with CI

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
