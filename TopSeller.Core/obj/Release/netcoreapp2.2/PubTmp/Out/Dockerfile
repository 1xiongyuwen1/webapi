FROM microsoft/dotnet
MAINTAINER TopSeller
RUN apt-get update && apt-get install -y \
  git
RUN git clone -q https://github.com/1xiongyuwen1/webapi.git
WORKDIR webapi/
RUN  dotnet TopSeller.Core.dll
EXPOSE 5888

CMD ["dotnet","run"]