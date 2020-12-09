# DotNetMicroService 

Project Version .Net 5.0

#### What are Microservices?
Microservices are a design pattern in which applications are composed of small, independent modules that communicate with each other using well-defined contracts. Each microservice focuses on a single concept.

#### Why Microservices?
Microservices make it easier to develop, test, and deploy isolated parts of your application. Once deployed, each microservice can be independently scaled as needed.

#### Microservices and containers
Containers combine an app plus its configuration and dependencies into a single, independently deployable unit. Containers are an excellent fit for bundling and deploying independent microservices.

#### Build microservices with .NET
ASP.NET, the web framework for .NET, makes it easy to create the APIs that become your microservices. ASP.NET comes with built-in support for developing and deploying your microservices using Docker containers.

## Services Used
Services and 3rd Party Packages Used In This Project.

#### Secret Manager
The Secret Manager tool stores sensitive data during the development of an ASP.NET Core project. In this context, a piece of sensitive data is an app secret. App secrets are stored in a separate location from the project tree. The app secrets are associated with a specific project or shared across several projects. The app secrets aren't checked into source control. 

https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-5.0&tabs=windows

#### Poly
Polly is a .NET resilience and transient-fault-handling library that allows developers to express policies such as Retry, Circuit Breaker, Timeout, Bulkhead Isolation, and Fallback in a fluent and thread-safe manner.
https://github.com/App-vNext/Polly
