FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base    
CMD ["sh", "-c", "echo '8080:8080' >> /etc/docker/daemon.json"]
WORKDIR /app
COPY . .  
EXPOSE 80
ENTRYPOINT ["dotnet", "./bin/Debug/net6.0/MyWeb.dll"]
