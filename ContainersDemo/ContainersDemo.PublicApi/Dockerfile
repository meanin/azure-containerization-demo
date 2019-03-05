FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["ContainersDemo.PublicApi/ContainersDemo.PublicApi.csproj", "ContainersDemo.PublicApi/"]
RUN dotnet restore "ContainersDemo.PublicApi/ContainersDemo.PublicApi.csproj"
COPY . .
WORKDIR "/src/ContainersDemo.PublicApi"
RUN dotnet build "ContainersDemo.PublicApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ContainersDemo.PublicApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ContainersDemo.PublicApi.dll"]