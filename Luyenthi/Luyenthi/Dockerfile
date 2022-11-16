FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Luyenthi/Luyenthi.csproj", "Luyenthi/"]
RUN dotnet restore "Luyenthi/Luyenthi.csproj"
COPY . .
WORKDIR "/src/Luyenthi"
RUN dotnet build "Luyenthi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Luyenthi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Luyenthi.dll"]
