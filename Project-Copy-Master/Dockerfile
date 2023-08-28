FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
LABEL maintainer="Faisal Shahzad <faisalshahzad.ciit@gmail.com>"
LABEL description="It will install dotnet core api server"
WORKDIR /app
EXPOSE 80
EXPOSE 443
ENV ASPNETCORE_URLS=http://*:4040

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Project-Copy-Master/Project-Copy-Master.csproj", "Project-Copy-Master/"]
RUN dotnet restore "Project-Copy-Master/Project-Copy-Master.csproj"
COPY . .
WORKDIR "/src/Project-Copy-Master"
RUN dotnet build "Project-Copy-Master.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Project-Copy-Master.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Project-Copy-Master.dll"]
