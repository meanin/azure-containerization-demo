FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ContainersDemo.PrivateApi/ContainersDemo.PrivateApi.csproj ContainersDemo.PrivateApi/
RUN dotnet restore ContainersDemo.PrivateApi/ContainersDemo.PrivateApi.csproj
COPY . .
WORKDIR /src/ContainersDemo.PrivateApi
RUN dotnet build ContainersDemo.PrivateApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ContainersDemo.PrivateApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ContainersDemo.PrivateApi.dll"]
