#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 2189
EXPOSE 44387

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["BB.DigitalMirror.API/BB.DigitalMirror.API.csproj", "BB.DigitalMirror.API/"]
RUN dotnet restore "BB.DigitalMirror.API/BB.DigitalMirror.API.csproj"
COPY . .
WORKDIR "/src/BB.DigitalMirror.API"
RUN dotnet build "BB.DigitalMirror.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BB.DigitalMirror.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BB.DigitalMirror.API.dll"]