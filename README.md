# AzParse

Welcome to AzParse! This is a small library which helps you translate region names and resource provider names to friendly display names.

For example, _uksouth_ would now become _UK South_. The resource name _Microsoft.Compute/virtualMachines_ would become _Virtual Machines_.

![Nuget](https://img.shields.io/nuget/v/AzParse) ![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/martyncoup/azparse-csharp/publish.yml?branch=main)

## Installation
Installation via Package Management is recommended. Instructions for NuGet and the .NET CLI are below.

### NuGet
```
Install-Package AzParse -Version 0.0.1-alpha
```

### DotNet CLI
```
dotnet add package AzParse --version 0.0.1-alpha
```

## Usage
Using the package is simple, string extensions are provided to convert both region names and resources.

```csharp
// Region
var region = "uksouth";
Console.WriteLine(region.ConvertRegionToFriendlyName());

// Resource
var region = "Microsoft.Compute/virtualMachines";
Console.WriteLine(region.ConvertResourceToFriendlyName());
```

## Issues
Feel free to open an issue if you find any problems such as missing regions or missing resource provider namespaces.