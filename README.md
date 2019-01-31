# SpecFlow.Selenium

The goal of this project is to provide a good starting point for those looking to use SpecFlow and Selenium together. It 
is also intended to demonstrate how to implement design patterns in a test framework, where many test frameworks will 
violate many different principles like SOLID, Static Cling (this one is always the most common), 
and Explicit Dependencies.

**Resources**
- [Selenium](http://www.seleniumhq.org/)
- [SpecFlow](http://specflow.org/)
- [FluentAssertions](https://fluentassertions.com/)
- [SOLID in Testing](http://www.absofttrainings.com/use-solid-principles-to-become-better-automation-tester/)
- [The Wrong Abstraction](https://www.sandimetz.com/blog/2016/1/20/the-wrong-abstraction)
- [Basic Programming Principles](https://www.makeuseof.com/tag/basic-programming-principles/)
- [Principles of Test Automation](http://xunitpatterns.com/Principles%20of%20Test%20Automation.html)
- [Software Testing Anti-patterns](http://blog.codepipes.com/testing/software-testing-antipatterns.html)
- [Overreliance on End to End Testing](https://testing.googleblog.com/2015/04/just-say-no-to-more-end-to-end-tests.html)
- [Cyclomatic and Cognitive Complexity](https://blog.sonarsource.com/cognitive-complexity-because-testability-understandability)



### TODO
- [x] .NET Framework
- [x] Mac setup
- [ ] Build scripts (cake?)
- [ ] Windows setup
- [ ] .NET Standard
- [ ] Visual Studio guide
- [ ] Appium
- [ ] Docker Selenium Grid execution



### Setup - OSx

Download and install [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

The required .net frameworks should download/install with your IDE of choice.

#### JetBrains Rider

No extra setup necessary

#### Visual Studio

Visual Studio needs a little extra configuration. Install these extensions;
- xUnit.NET 2
- SpecFlow

#### Install Homebrew
```
$ ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
```

After installation:
```
$ brew doctor
Your system is ready to brew
```

#### Mono
```
$ brew install mono
```

#### Git
```
$ brew install git
```

### Setup - Windows

Download and install [Visual Studio](https://visualstudio.microsoft.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

The required .net frameworks should download/install with your IDE of choice.

#### JetBrains Rider

No extra setup necessary

#### Visual Studio

Visual Studio needs a little extra configuration. Install these extensions;
- xUnit.NET 2
- SpecFlow

#### Install Scoop (Windows Homebrew alternative)

**Requirements**
- [PowerShell 3](https://www.microsoft.com/en-us/download/details.aspx?id=34595)
- PowerShell must be enabled for User account

```
$ set-executionpolicy unrestricted -s cu
```

Install:
```
$ iex (new-object net.webclient).downloadstring('https://get.scoop.sh')
```

#### Git
```
$ scoop install git
```

### Clone
``
$ git clone https://github.com/jukafah/csharp-specflow-selenium.git
``

#### IDE - Rider

As of writing this guide, generating the code-behind `feature.cs` files requires invoking the generator separately.
Ken Bonny wrote a couple good articles for generating those and how to configure it with File Watcher. The guide will
also walk you through associating the files together.

[Generating SpecFlow Files in Rider](https://kenbonny.net/2018/05/28/generating-specflow-files-in-rider/)

[SpecFlow Steps Generation](https://kenbonny.net/2018/07/23/specflow-steps-generation-and-general-rider-changes/)


Restore dependencies
```
$ nuget restore
```

From solution directory
```
$ mono "packages/SpecFlow.2.4.1/tools/specflow.exe" GenerateAll -p SpecFlow.Selenium/SpecFlow.Selenium.csproj
```

Import the generated `feature.cs` files to the same directory as your features.

Tests will now show in the Unit Tests / Test Explorer.

#### IDE - Visual Studio

TODO

#### Running Tests
You can run them in the Unit Test explorer of your chosen IDE or via command line

Build
```
$ msbuild
```

Run tests
```
$ mono "packages/xunit.runner.console.2.4.1/tools/net452/xunit.console.exe" SpecFlow.Selenium/bin/Debug/SpecFlow.Selenium.dll -xml ./TestResults/xunit.xml
```

Selection of browser is through an environment variable. Defaults to Chrome if unprovided.
```
$ BROWSER=firefox mono "packages/xunit.runner.console.2.4.1/tools/net452/xunit.console.exe" SpecFlow.Selenium/bin/Debug/SpecFlow.Selenium.dll -xml ./TestResults/xunit.xml
```

Then you can generate a nice html report via Pickles
```
$ mono "packages/Pickles.CommandLine.2.20.1/tools/pickles.exe" --feature-directory=SpecFlow.Selenium/Features/ --output-directory=./TestResults/pickles --link-results-file=./TestResults/xunit.xml --documentation-format=dhtml --test-results-format=xunit2
```
