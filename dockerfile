#Get base SDK Image from Microsoft
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build-env
WORKDIR /app

#Copy the CSPROJ file and restore any dependencies (via NUGET)
COPY *.csproj ./
RUN dotnet restore

#Copy the project files and build our release 
COPY . ./
RUN dotnet publish -c Release -o out

#Generate Routine Image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet","UserService.dll"]