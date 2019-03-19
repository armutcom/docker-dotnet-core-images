ARG IMAGE_NAME
FROM IMAGE_NAME

# set up environment
# this fields will be used in packagescache.csproj
ARG VERSION
ARG NETCOREAPP_VERSION
ENV ASPNETCORE_URLS http://+:80
ENV ASPNETCORE_PKG_VERSION VERSION
ENV TARGET_FRAMEWORK NETCOREAPP_VERSION

# set up node
ENV NODE_VERSION 8.11.2
ENV NODE_DOWNLOAD_SHA 67dc4c06a58d4b23c5378325ad7e0a2ec482b48cea802252b99ebe8538a3ab79
ENV NODE_DOWNLOAD_URL https://nodejs.org/dist/v$NODE_VERSION/node-v$NODE_VERSION-linux-x64.tar.gz

RUN curl -SL "$NODE_DOWNLOAD_URL" --output nodejs.tar.gz \
    && echo "$NODE_DOWNLOAD_SHA nodejs.tar.gz" | sha256sum -c - \
    && tar -xzf "nodejs.tar.gz" -C /usr/local --strip-components=1 \
    && rm nodejs.tar.gz \
    && ln -s /usr/local/bin/node /usr/local/bin/nodejs \
    # set up bower and gulp
    && npm install -g bower gulp \
    && echo '{ "allow_root": true }' > /root/.bowerrc

# warmup NuGet package cache
COPY packagescache.csproj /tmp/warmup/
RUN dotnet restore /tmp/warmup/packagescache.csproj \
        --source https://api.nuget.org/v3/index.json \
        --verbosity quiet \
    && rm -rf /tmp/warmup/

WORKDIR /
	
LABEL authors="Armut.com <dev@armut.com>"