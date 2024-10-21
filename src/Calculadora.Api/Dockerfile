# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source

# Copia o csproj e restaura dependências
COPY . .
RUN dotnet restore "src/Calculadora.Api/GestaoServico.Api.csproj"

# Compila o projeto
RUN dotnet build "src/Calculadora.Api/GestaoServico.Api.csproj" -c Release -o /app/build

# Etapa 2: Publicação
FROM build AS publish
RUN dotnet publish "src/Calculadora.Api/GestaoServico.Api.csproj" -c Release -o /app/publish

# Etapa 3: Final
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Calculadora.Api.dll"]

# Exponha a porta 80 para o tráfego HTTP
EXPOSE 80