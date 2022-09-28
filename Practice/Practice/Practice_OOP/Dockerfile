FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Practice_OOP/Practice_OOP.csproj", "Practice_OOP/"]
RUN dotnet restore "Practice_OOP/Practice_OOP.csproj"
COPY . .
WORKDIR "/src/Practice_OOP"
RUN dotnet build "Practice_OOP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Practice_OOP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Practice_OOP.dll"]
