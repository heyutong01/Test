FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base   
WORKDIR /app
COPY . .  
EXPOSE 80 
ENTRYPOINT ["dotnet", "./bin/Debug/net6.0/MyWeb.dll"]
