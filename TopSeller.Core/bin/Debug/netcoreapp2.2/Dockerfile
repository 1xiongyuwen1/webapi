FROM microsoft/dotnet
MAINTAINER TopSeller
RUN apt-get update 
RUN apt-get install -y git
RUN git clone  https://github.com/1xiongyuwen1/webapi.git
WORKDIR webapi/
RUN  dotnet restore
EXPOSE 5888

CMD ["dotnet","run"]