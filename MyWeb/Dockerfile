FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base   
FROM ubuntu:latest  
  
# ÐÞ¸ÄÈÝÆ÷¶Ë¿ÚºÅ  
CMD ["sh", "-c", "echo '8080:8080' >> /etc/docker/daemon.json"]
WORKDIR /app
COPY . .  
EXPOSE 8089
ENTRYPOINT ["dotnet", "./bin/Debug/net6.0/MyWeb.dll"]
