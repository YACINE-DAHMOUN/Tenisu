FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ./TenisuApi ./TenisuApi
WORKDIR /src/TenisuApi
RUN dotnet restore Tenisu.csproj
RUN dotnet publish Tenisu.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Tenisu.dll"]
