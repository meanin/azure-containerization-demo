# Azure Containerization Demo
Repository consist of number of functions. First of all, here you can find two simple WebApi written in ASP.NET Core 2.2. Both projects are wrapped of docker files.

## Docker compose
Within the third file `docker-compose.yml` you can run the whole solution on you machine with distinguished containers for each project. The public API call private one which is available only on docker network, when the original is published to localhost.
Open visual studio and run the project :)

## Kubernetes
Connect to you cluster through kubectl. Here you can find few files for deploying containers and access them through services.