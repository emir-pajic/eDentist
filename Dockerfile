FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000
ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
COPY eDentist.WebAPI/Files ./Files
FROM build AS publish
RUN dotnet publish "eDentist.WebAPI/eDentist.WebAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY eDentist.WebAPI/Files /app/Files

COPY --from=publish /app .

ENTRYPOINT ["dotnet", "eDentist.WebAPI.dll"]