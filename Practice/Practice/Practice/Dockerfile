﻿FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Practice/Practice.csproj", "Practice/"]
RUN dotnet restore "Practice/Practice.csproj"
COPY . .
WORKDIR "/src/Practice"
RUN dotnet build "Practice.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Practice.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Practice.dll"]
