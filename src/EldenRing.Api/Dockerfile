#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["EldenRing/EldenRing.csproj", "EldenRing/"]
RUN dotnet restore "EldenRing/EldenRing.csproj"
COPY . .
WORKDIR "/src/EldenRing"
RUN dotnet build "EldenRing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EldenRing.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EldenRing.dll"]