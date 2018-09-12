# Digital Mirror API

# API

RESTful API written in cross platform .NET Core 2.0

# Data 

Using PostgreSQL a Npgsql DB via Entity Framework Core provider

# Hosting on Azure

The API is hosted on Azure

# Upcoming features 
	1. Security - Encrypted JWT/Oauth 2.0 flow 
	2. Introduce Docker
	3. Use Domain Drive Design best practices to decompose the monolithic API into microservices on Azure



Databaswe
1. Initial Migration
Look through custom context and find the DbSets, create database and tables
	dotnet ef migrations add InitialMigration
Apply Migration
	dotnet ef database update