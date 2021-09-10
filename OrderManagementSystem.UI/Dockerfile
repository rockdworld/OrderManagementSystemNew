#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["OrderManagementSystem.UI/OrderMgmtSystem.UI.fsproj", "OrderManagementSystem.UI/"]
RUN dotnet restore "OrderManagementSystem.UI/OrderMgmtSystem.UI.fsproj"
COPY . .
WORKDIR "/src/OrderManagementSystem.UI"
RUN dotnet build "OrderMgmtSystem.UI.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OrderMgmtSystem.UI.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OrderMgmtSystem.UI.dll"]