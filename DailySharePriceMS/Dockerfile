#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
#copy
#FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
#WORKDIR /src
#COPY ["DailySharePriceMS/DailySharePriceMS.csproj", "DailySharePriceMS/"]
#RUN dotnet restore "DailySharePriceMS/DailySharePriceMS.csproj"
#COPY . .
#WORKDIR "/src/DailySharePriceMS"
#RUN dotnet build "DailySharePriceMS.csproj" -c Release -o /app/build
COPY * .csproj ./
RUN dotnet restore
#FF
COPY . ./
#DD
RUN dotnet publish -c Release -o out
#DD
FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "DailySharePriceMS.dll"]


#
#FROM build AS publish
#RUN dotnet publish "DailySharePriceMS.csproj" -c Release -o /app/publish
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
