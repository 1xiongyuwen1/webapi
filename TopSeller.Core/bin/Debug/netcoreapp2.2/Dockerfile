FROM microsoft/dotnet
MAINTAINER TopSeller
RUN apt-get update && apt-get install -y \
  git
RUN git clone -q https://github.com/1xiongyuwen1/webapi.git
WORKDIR webapi/
RUN  dotnet restore
EXPOSE 5000

CMD ["dotnet","run"]