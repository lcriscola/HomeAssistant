#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 8099

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY AmcrestMQTT.csproj .
RUN dotnet restore "AmcrestMQTT.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "AmcrestMQTT.csproj" -c Debug -o /app/build

FROM build AS publish
RUN dotnet publish "AmcrestMQTT.csproj" -c Debug -o /app/publish

FROM base AS final
EXPOSE 8099
ENV ASPNETCORE_URLS=http://+:8099
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AmcrestMQTT.dll"]