#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["CompanyEmployees.API/CompanyEmployees.API.csproj", "CompanyEmployees.API/"]
COPY ["CanisMajoris.Contracts/CanisMajoris.Contracts.csproj", "CanisMajoris.Contracts/"]
COPY ["CanisMajoris.Domain/CanisMajoris.Entities.csproj", "CanisMajoris.Domain/"]
COPY ["CanisMajoris.LoggerService/CanisMajoris.LoggerService.csproj", "CanisMajoris.LoggerService/"]
COPY ["CanisMajoris.Repository/CanisMajoris.Repository.csproj", "CanisMajoris.Repository/"]
COPY ["CanisMajoris.Services.Contracts/CanisMajoris.Services.Contracts.csproj", "CanisMajoris.Services.Contracts/"]
COPY ["CanisMajoris.Shared/CanisMajoris.Shared.csproj", "CanisMajoris.Shared/"]
COPY ["CanisMajoris.Services/CanisMajoris.Services.csproj", "CanisMajoris.Services/"]
RUN dotnet restore "./CompanyEmployees.API/./CompanyEmployees.API.csproj"
COPY . .
WORKDIR "/src/CompanyEmployees.API"
RUN dotnet build "./CompanyEmployees.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CompanyEmployees.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CompanyEmployees.API.dll"]