# CodingChallenge
Coding Challenge for GreenSlate

Deployment instructions:
1 - Run Database script to create Project Management database.
    File is located in root directory. Filename: ProjectManagement.Database.publish.sql
2 - After Database deployment, please change connection string.
    Connection String is located in ProjectManagement project.
    Locate file appsettings.json.
    Inside appsettings.json, find section "ConnectionStrings". Replace the connection string with the necessary information.


Solution Descrition
Project is divided in the following projects:

1 - ProjectManagement: Main Website for application
2 - ProjectManagement.BusinessLogic: Project containing all calculations for each domain (Users, Projects)
3 - ProjectManagement.BusinessLogic.Tests: Project contains all unit tests to verify Domain Logic behaviour.
4 - ProjectManagement.Common: Contains all DTO Objects and Interfaces used for Domains and Repositories
5 - ProjectManagement.Repositories: Entity Framework for SQL implementation of repository interfaces.
6 - ProjectManagement.Database: This project contains all scripts used define and publish the main SQL Server Deployment Script. (This project is not required to run the application. Can be ignored if needed depending on Visual Studio Version)
