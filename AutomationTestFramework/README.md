# WEBSITE AUTOMATION TEST FRAMEWORK

The automation test framework aims to test the specific features for The Modern Milkman website, in line with Gherkin syntax for test cases and automated test scripts. Allure framework is utilized for reporting alongside Jenkins CL tool.

To view the website visit:
https://themodernmilkman.co.uk/ 

To submit bug reports, feature suggestions, or track changes:
https://github.com/JayMackay/AutomationTestFrameworkModernMilkman 


### CONTENTS OF THIS FILE

•	Requirements
•	Recommended modules
•	Installation
•	Configuration
•	Troubleshooting
•	Maintainers

### Requirements

This project is built using .Net Framework Version 4.7.2 through Visual Studios 2019. The framework requires:

```
NUnit 3 Test Adapter
Specflow Extensions to run
```

### Recommended Modules

Scoop Command Line Tool (Run commands in terminal):

```
Set-ExecutionPolicy RemoteSigned -scope CurrentUser
iwr -useb get.scoop.sh | iex
```

Allure Reporting (Run commands in terminal):

```
scoop install allure
```

Node.js:
https://nodejs.org/en/download/ 

Allure Command Line Tool (Run commands in terminal):

```
npm install -g allure-commandline --save-dev
```
All further required packages will install during initial start up of the program. Check projects packages.config and save an initial copy before updating.

### Installation

To install ensure you have the latest version of Visual Studios 2019 and Firefox web browser downloaded. Clone the project from the GitHub repository using the “Open with Visual Studios” option. Navigate into the projects solution directory and you will be prompted to install the required packages. Build the solution and navigate into Test Explorer to run the tests.

### Configuration

Utilize the following parameters for testing:

```
First Name: TestUserFirstName
Surname: TestUserLastName
Email: TestUser@admin.com
Mobile Number: 07987654320
Password: adminPassoword
```

The framework has no additional modifiable settings. There is no configuration.

### Troubleshooting

There is a known defect with Chrome Driver Instance not running. Steps to resolve:

•	Install the latest Chrome Driver
	https://chromedriver.chromium.org/downloads 
•	Add chromedriver.exe to a folder withing your C:// drive
•	Add the Chrome Driver directory to your Environment Variables
•	Install WebDriverManager package and input the following code within your SeleniumDriverConfig file
	
```
public void SetChromeDriver()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver();
        }
```

https://www.browserstack.com/guide/run-selenium-tests-using-selenium-chromedriver 

## Authors

Jared Mackay - https://github.com/JayMackay