# BapApiSqlite

## Overview

This is a simple Visual Studio API Project for the Belfast Met Microsoft Academy.

* The project was created using [this article](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio). 
* The default models and Startup.cs were updated to support [Sqlite](https://www.sqlite.org/index.html).
* A sqlite database was added, storeapps.db.
* A scaffolding controller was added to handle HTTP requests.

## What needs to be updated?

* The Models and Controller will need updated to build a workable API.
* The API uses the [Entity Framework](https://docs.microsoft.com/en-us/ef/) to manage the database connection.
* This page has good examples of [Entity Framework Querying](https://www.entityframeworktutorial.net/querying-entity-graph-in-entity-framework.aspx). 

## How do you publish the project as an Azure Web Service?

Using Sqlite complicates the process of publishing to an Azure App Service.

The following steps will get your Azure App up and running.

* These instructions were taken from [here](https://www.halldorstefans.com/using-sqlite-in-net-core-azure-web-app/).
* Run this command in the same folder as your '.sln' file, 'dotnet publish -c Release -o ./publish'.
* Copy the Sqlite database, storeapps.db, to the publish folder if it is not there already.
* Install the [Azure App Service](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azureappservice) extension for Visual Studio Code.
* Right click on your publish folder and select, 'Deploy to Web App'.
* Deploy to an App you have already setup on Azure.
* Make sure you setup a Free Tier (F1) App.
* You will need a working Azure account with credit to publish the App.