#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["01_cmdline.csproj", "."]
RUN dotnet restore "./01_cmdline.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "01_cmdline.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "01_cmdline.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "01_cmdline.dll"]