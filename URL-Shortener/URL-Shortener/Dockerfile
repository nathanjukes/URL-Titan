FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["URL-Shortener/URL-Shortener.csproj", "URL-Shortener/"]
RUN dotnet restore "URL-Shortener/URL-Shortener.csproj"
COPY . .
WORKDIR "/src/URL-Shortener"
RUN dotnet build "URL-Shortener.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "URL-Shortener.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "URL-Shortener.dll"]