FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["EPR_Academy/EPR_Academy.csproj", "EPR_Academy/"]
RUN dotnet restore "EPR_Academy/EPR_Academy.csproj"
COPY . .
WORKDIR "/src/EPR_Academy"
RUN dotnet build "EPR_Academy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EPR_Academy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EPR_Academy.dll"]
