#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /App

COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /App
COPY --from=build /App/out .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "DotnetWebApp.dll"]