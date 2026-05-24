FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["SecurePlatformLab.Frontend/SecurePlatformLab.Frontend.csproj", "SecurePlatformLab.Frontend/"]
RUN dotnet restore "SecurePlatformLab.Frontend/SecurePlatformLab.Frontend.csproj"

COPY . .

WORKDIR "/src/SecurePlatformLab.Frontend"
RUN dotnet publish "SecurePlatformLab.Frontend.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "SecurePlatformLab.Frontend.dll"]