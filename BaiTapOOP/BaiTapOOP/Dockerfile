FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BaiTapOOP/BaiTapOOP.csproj", "BaiTapOOP/"]
RUN dotnet restore "BaiTapOOP/BaiTapOOP.csproj"
COPY . .
WORKDIR "/src/BaiTapOOP"
RUN dotnet build "BaiTapOOP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BaiTapOOP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BaiTapOOP.dll"]
