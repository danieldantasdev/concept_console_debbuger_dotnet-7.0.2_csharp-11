FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Debugger/Debugger.csproj", "Debugger/"]
RUN dotnet restore "Debugger/Debugger.csproj"
COPY . .
WORKDIR "/src/Debugger"
RUN dotnet build "Debugger.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Debugger.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Debugger.dll"]
