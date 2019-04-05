# Selenium Basics

A Simple C# program using .NET core that show cases selenium using firefox driver(a.k.a gecko driver)

## Run selenium test

cd to the project's directory and run using the command `dotnet run`

## Tool used

IDE                 - Visual studio code
Framework           - Dot NET core

## What running this program does

Running this invokes a firefox browser, loads the Nordstrom website(fashion retailer in the US) and closes the browser.

## Firefox driver and Selenium nuget dependency

1. You may want to update the [firefox driver binary](resources/drivers) with the latest version so that the driver is compatible with version of firefox browser you are using. Search it in google and download the appropriate binary for your operating system.
2. Update the selenium version using dotnet CLI if you see any error. `dotnet add package Selenium.WebDriver --version <version_number>`
