FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
COPY ./publish .
ENTRYPOINT ["dotnet", "MoviesAPIWebApp.dll"]