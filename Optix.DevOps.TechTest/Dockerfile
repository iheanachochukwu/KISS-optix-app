# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY ["Optix.TechTest/Optix.TechTest.csproj", "Optix.TechTest/"]
COPY ["Optix.TechTest.Tests/Optix.TechTest.Tests.csproj", "Optix.TechTest.Tests/"]
RUN dotnet restore "Optix.TechTest/Optix.TechTest.csproj"
COPY . .
WORKDIR "/app/Optix.TechTest"
RUN dotnet build "Optix.TechTest.csproj" -c Release -o /app/build

# Test stage
FROM build AS test
WORKDIR "/app"
RUN dotnet test --results-directory /testresults --logger "trx;LogFileName=tests.trx" /p:CollectCoverage=true /p:CoverletOutputFormat=json%2cCobertura /p:CoverletOutput=/testresults/coverage/ -p:MergeWith=/testresults/coverage/coverage.json  Optix.TechTest.Tests/Optix.TechTest.Tests.csproj

# Publish stage
FROM build AS publish
WORKDIR "/app/Optix.TechTest"
RUN dotnet publish "Optix.TechTest.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "Optix.TechTest.dll"]
