# Specflow(Cucumber) with C# Project

### Overview

 Specflow (cucumber) testing framework in c# using Page Object Pattern
 
### Motivation

* For browser automation, I’ve decided to go with Selenium WebDriver because is the go-to standard for browser automation. Most important benefits are Advanced Browser Interactions, Mouse and Keyboard simulation, Cross Browser compability, Cross Device compability, easy to extend with personalized extensions.
* For test and test data specification, I’ve chosen SpecFlow, which is Cucumber for .NET, because I really wanted to use an editor I know and Specflow was the answer for Visual Studio.
* Visual Studio because provides code completion, code understanding and navigation also includes an interactive debugger and easy to use. Most of all I've decided to go with VS because I was most confortable with and wanted to use C#.
* For running tests and performing assertions, I decided to go with NUnit and it integrates very nicely with SpecFlow.

### Environment Setup

1. Global Dependencies
     * MS Visual Studio 2017 or later.
     * Install the SpecFlow extension in Visual Studio. The easiest way to install the SpecFlow Visual Studio extension method is to select Tools | Extensions and Updates from the menu in Visual Studio, switch to the Online search on the left and enter “SpecFlow” in the search field at the top right. Click on the Download button to install the extension.
    ```
2. Installation

     * Open the Solution Explorer
     * Right-click on the solution.
     * Click on Manage NuGet Packages...
     * Install the following nugget packages checking both projects
          * Microsoft.NET.Test.Sdk
          * NUnit
          * NUnit3TestAdapter
          * Selenium.Chrome.WebDriver
          * Selenium.Support
          * Selenium.WebDriver
          * SpecFlow.Tools.MsBuild.Generation
    
3. Setup
     * Clone the repo
	  * Open the solution `InterviewSolution.sln` in Visual Studio 2017 or higher
	  * Build the solution

    ```

### Running your tests from Test Explorer via NUnit Test Adapter
- To run a single test, run test by right click and Run Selected Test
- To run all tests, run tests by Run All button

### Resources
##### [SpecFlow Documentation](https://specflow.org/docs/)
