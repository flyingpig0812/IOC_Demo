#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
EXPOSE 80
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["CTS.Track.Api/CTS.Track.Api.csproj", "CTS.Track.Api/"]
COPY ["CTS.Track.Common/CTS.Track.Common.csproj", "CTS.Track.Common/"]
COPY ["CTS.Track.Model/CTS.Track.Model.csproj", "CTS.Track.Model/"]
COPY ["CTS.Track.IService/CTS.Track.IService.csproj", "CTS.Track.IService/"]
COPY ["CTS.Track.IRepository/CTS.Track.IRepository.csproj", "CTS.Track.IRepository/"]
COPY ["CTS.Track.Service/CTS.Track.Service.csproj", "CTS.Track.Service/"]
COPY ["CTS.Track.Repository/CTS.Track.Repository.csproj", "CTS.Track.Repository/"]
RUN dotnet restore "CTS.Track.Api/CTS.Track.Api.csproj"
COPY . .

WORKDIR "/src/CTS.Track.Repository"
RUN dotnet build "CTS.Track.Repository.csproj" -c Release -o /app
WORKDIR "/src/CTS.Track.Service"
RUN dotnet build "CTS.Track.Service.csproj" -c Release -o /app

WORKDIR "/src/CTS.Track.Api"
RUN dotnet build "CTS.Track.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CTS.Track.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CTS.Track.Api.dll"]