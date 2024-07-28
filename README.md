# Reqnroll Test Projects for Exploratory Testing

This repository contains sample projects to support exploratory testing of Reqnroll or its components (e.g. Visual Studio extension).

The test projects in this repository are simple and typically focus on one particular aspect. For a more realistic sample project, check out the [ReqOverflow sample](https://github.com/reqnroll/Sample-ReqOverflow/).

The Reqnroll version to be used in the samples is set to the current local version (e.g. `2.1.0-local`), but can be changed as needed for testing. It does not use `Directory.Build.props` file to set the version globally on purpose, because we wanted to use the approach (fixed versions in project files) that is normally used by end users. To update the version in projects, there is a script: `update-versions.ps1`, that replaces the Reqnroll versions in all project files to the one provided as a parameter. Usage: `update-versions.ps1 1.2.3`.

The repository contains the following test project sets:

* [ReqnrollCalculator](ReqnrollCalculator): This is a simple generic default go-to project to test Reqnroll.
* [CleanReqnrollProject](CleanReqnrollProject): Fresh Reqnroll projects (not migrated from SpecFlow) for different target frameworks and test execution frameworks.
* [SpecFlowCompatibilityProject](SpecFlowCompatibilityProject): Projects migrated from SpecFlow using the `Reqnroll.SpecFlowCompatibility` package.
* [ReqnrollPlugins](ReqnrollPlugins): Sample projects for every plugin that is maintained by the Reqnroll organization.
* [BigReqnrollProject](BigReqnrollProject): A project with 5000 scenarios (500 feature files, 10 scenarios each) for testing performance. You can reduce the size by deleting feature files.
* [SpecFlowProject](SpecFlowProject): SpecFlow project for testing migration or Visual Studio extension SpecFlow project support.
* [TestFrameworkSamples](TestFrameworkSamples): A sample project for each supported test execution framework (MsTest, NUnit, xUnit), showing the capabilities of the framework itself. Useful for considering support for these capabilities or for testing the test framework behavior with different versions.
