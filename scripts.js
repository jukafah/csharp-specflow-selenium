const commandLineArgs     = require('command-line-args');
const shell	              = require('shelljs');
const fs                  = require('fs');
const path                = require('path');
const os                  = require('os').platform();

const test 				  = process.env.TEST;
const device 			  = process.env.DEVICE;

const dirLogs			  = path.join(__dirname, './logs');
const dirTestResults	  = path.join(__dirname, './testResults');
const dirScreenshots      = path.join(dirTestResults, 'screenshots');
const dirTestDLL          = path.join(__dirname, 'SpecFlow.Selenium', 'bin', 'Debug', 'SpecFlow.Selenium.dll')

const scriptOptions = commandLineArgs (
    [
        { name: 'build',       type: Boolean },
        { name: 'test',        type: Boolean },
        { name: 'pickles',     type: Boolean}
    ]
)

if (scriptOptions.build) {
	build();
}

if (scriptOptions.test) {
    createDirectories();
	checkParameters();
	run();
}

if (scriptOptions.pickles) {
	pickles();
}

function build() {
	if (os.indexOf('darwin') > -1 || os.indexOf('linux') > -1) {
		shell.exec('xbuild SpecFlow.Selenium/SpecFlow.Selenium.csproj')
	} else {
		throw Error('Build command only implemented for darwin and linux based os')
	}
}

function run() {
	if (os.indexOf('darwin') > -1 || os.indexOf('linux') > -1) {
		shell.exec(`DEVICE=${device} nunit-console -labels -xml=${dirTestResults}/${device}.xml -include=${test} ${dirTestDLL}`)
	} else {
		throw Error('Run command only implemented for darwin and linux based os')
	
	}
}

// TODO: fix this - will also need to add nuget package for `pickles` to the project
function pickles() {
	if (os.indexOf('darwin') > -1 || os.indexOf('linux') > -1) {
		shell.exec('mono ./packages/Pickles.CommandLine.2.11.1/tools/pickles.exe --feature-directory=./SpecFlow.Appium/Features/ --output-directory=./testResults/pickles --link-results-file=./testResults/testResults.xml --system-under-test-name=SpecFlow.Appium --documentation-format=dhtml --test-results-format=nunit')
	} else {
		throw Error('npm run pickles not yet implemented for Windows!')
	}
}

function checkParameters() {
	if (!test) {
		throw Error('TEST not set!')
	}
}

function createDirectories() {
	if (!fs.existsSync(dirLogs)) {
    	fs.mkdirSync(dirLogs);
	}

	if (!fs.existsSync(dirTestResults)) {
		fs.mkdirSync(dirTestResults);
	}
}