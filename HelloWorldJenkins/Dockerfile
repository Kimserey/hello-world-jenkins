FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["HelloWorldJenkins/HelloWorldJenkins.csproj", "HelloWorldJenkins/"]
RUN dotnet restore "HelloWorldJenkins/HelloWorldJenkins.csproj"
COPY . .
WORKDIR "/src/HelloWorldJenkins"
RUN dotnet build "HelloWorldJenkins.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "HelloWorldJenkins.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HelloWorldJenkins.dll"]