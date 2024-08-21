# Use the official .NET runtime as a parent image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build and publish the app
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Kreshnik.Api.csproj", "./"]
RUN dotnet restore "./Kreshnik.Api.csproj"
COPY . .
RUN dotnet publish "Kreshnik.Api.csproj" -c Release -o /app/publish

# Copy the app to the base image and set the entry point
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Kreshnik.Api.dll"]
