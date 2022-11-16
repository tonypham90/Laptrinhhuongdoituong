FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ManageStore/ManageStore.csproj", "ManageStore/"]
RUN dotnet restore "ManageStore/ManageStore.csproj"
COPY . .
WORKDIR "/src/ManageStore"
RUN dotnet build "ManageStore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ManageStore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ManageStore.dll"]
