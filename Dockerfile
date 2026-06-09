# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["Todo-Backend/Todo-Backend.csproj", "Todo-Backend/"]
RUN dotnet restore "Todo-Backend/Todo-Backend.csproj"

# Copy everything else and build
COPY . .
WORKDIR "/src/Todo-Backend"
RUN dotnet build "Todo-Backend.csproj" -c Release -o /app/build

# Publish
FROM build AS publish
RUN dotnet publish "Todo-Backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Expose port
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "Todo-Backend.dll"]
