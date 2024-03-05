FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Bank-Kata_Voxel/Bank-Kata_Voxel.csproj", "Bank-Kata_Voxel/"]
RUN dotnet restore "Bank-Kata_Voxel/Bank-Kata_Voxel.csproj"
COPY . .
WORKDIR "/src/Bank-Kata_Voxel"
RUN dotnet build "Bank-Kata_Voxel.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Bank-Kata_Voxel.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bank-Kata_Voxel.dll"]
