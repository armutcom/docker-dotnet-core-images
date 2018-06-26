FROM armutcom/dotnet-core-runtime:2.1.1-deps-bionic

RUN apt-get update \
    && apt-get install -y --no-install-recommends \
        curl \
    && rm -rf /var/lib/apt/lists/*

# Install .NET Core
ENV DOTNET_VERSION 2.1.1
ENV DOTNET_DOWNLOAD_URL https://dotnetcli.blob.core.windows.net/dotnet/Runtime/$DOTNET_VERSION/dotnet-runtime-$DOTNET_VERSION-linux-x64.tar.gz
ENV DOTNET_DOWNLOAD_SHA 39737997bc10de06b8fcae448f1c740dd422d9f6e4f71a61f364b5643adfade3f3902ea07eebf38c6505e5262312d05cbc9f295d3ec5f8d5830f4ab73236a5a5

RUN curl -SL $DOTNET_DOWNLOAD_URL --output dotnet.tar.gz \
    && echo "$DOTNET_DOWNLOAD_SHA dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -zxf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz \
    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet
	
LABEL authors="Armut.com <dev@armut.com>"