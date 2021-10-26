#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["pryRentaCarros.WebApiHttps/pryRentaCarros.WebApiHttps.csproj", "pryRentaCarros.WebApiHttps/"]
COPY ["pryRentaCarros.Model/pryRentaCarros.Model.csproj", "pryRentaCarros.Model/"]
COPY ["pryRentaCarros.BusinessRule/pryRentaCarros.BusinessRule.csproj", "pryRentaCarros.BusinessRule/"]
COPY ["pryRentaCarros.Broker/pryRentaCarros.Broker.csproj", "pryRentaCarros.Broker/"]
RUN dotnet restore "pryRentaCarros.WebApiHttps/pryRentaCarros.WebApiHttps.csproj"
COPY . .
WORKDIR "/src/pryRentaCarros.WebApiHttps"
RUN dotnet build "pryRentaCarros.WebApiHttps.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "pryRentaCarros.WebApiHttps.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "pryRentaCarros.WebApiHttps.dll"]