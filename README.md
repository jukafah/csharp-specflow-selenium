# SpecFlow.Selenium

**Resources**
- [SpecFlow](http://specflow.org/)
- [Appium](http://appium.io/)
- [Selenium](http://www.seleniumhq.org/)

## Setup - OSx

Download and install [Xamarin Studio](https://www.xamarin.com/studio)

Download and install [Xcode](https://developer.apple.com/xcode/)
- After installation, be sure to open and accept the license agreements


### Xamarin Studio Config

Open Xamarin Studio and configure the following;

#### Install Add-ins

Xamarin Studio => Add-ins
- Testing => NUnit support
- Gallery => SpecFlow support

#### Configure SDKs

Xamarin Studio => Preferences => Projects => SDK Locations

Ensure Android SDK locations;
- Android SDK: _path/to/android/sdk_
- Java SDK: _path/to/java/sdk_
- Android NDK: _path/to/android/ndk_

Ensure Apple SDK locations;
- Apple SDK: _path/to/xcode.app_

### ENV Config

#### ENV Vars

Open a terminal and execute
```
$ open ~/.bash_profile
```

Add to bash profile
```
export ANDROID_HOME=/path/to/android/sdk
export PATH=${PATH}:$ANDROID_HOME/tools:$ANDROID_HOME/platform-tools
export JAVA_HOME=$(/usr/libexec/java_home)
```

Save changes, close bash profile, close and reopen terminal.

#### Install Homebrew

Still in Terminal, execute the following commands:
```
$ ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
```

After installation:
```
$ brew doctor
Your system is ready to brew
```

#### Install Node
```
$ brew install node
```

Then
```
$ node --version
v6.3.1
```

#### Git

Still in terminal, execute
```
$ brew install git
```

Then
```
$ git --version
git version 2.9.2
```

## Setup - Windows

Download and install [Visual Studio (2015 Enterprise)](https://www.visualstudio.com/downloads/)

### Visual Studio Config

Open Visual Studio and configure the following;

#### Install Add-ins

Tools => Extensions
- NUnit 3 Test Adapter
- Xamarin Forms Player
- Xamarin for Visual Studio 
- Tools => Android => Android SDK Manager
	- for Adroid versions LATEST to 4.1.2 : install
			- SDK Platform
			- Google APIs ARM EABI v7a System Imaga
			- - - Google APIs Intel x 86 Atom System Image
			- - - Google APIs
- You may need to Create a Virtual Device under Tools => Android => Android Emulator Manager


#### Configure SDKs

Install [Android SDK](https://developer.android.com/studio/install.html)

### ENV Config

#### ENV Vars

Open environment variables and edit User Variables;

Create a new ENV var
```
ANDROID_HOME=\path\to\android\sdk
```

Append new entries to PATH
```
PATH=%ANDROID_HOME%\tools
PATH=%ANDROID_HOME%\platform-tools
```

#### Install Scoop (Windows Homebrew alternative)

**Requirements**
- [PowerShell 3](https://www.microsoft.com/en-us/download/details.aspx?id=34595)
- PowerShell must be enabled for User account

```
set-executionpolicy unrestricted -s cu
```

Install:
```
iex (new-object net.webclient).downloadstring('https://get.scoop.sh')
```

#### Install Node
```
scoop install nodejs-lts
```

#### Git
```
scoop install git
```

### Running

#### IDE

- Build
- Xamarin Studio: View => Test
- Visual Studio: Tests => Windows => Test Explorer

#### Local Execution

Install dependencies
```
$ npm install
```

Build project
```
$ npm run build
```

Run tests
```
$ TEST=<test> npm run test
```

TEST can be comma delimited list of tests: <C001,C002,C003>