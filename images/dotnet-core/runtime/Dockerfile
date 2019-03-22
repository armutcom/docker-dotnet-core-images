ARG RUNTIME_DEPS_IMAGE
FROM ${RUNTIME_DEPS_IMAGE}

RUN apt-get update \
    && apt-get install -y --no-install-recommends \
        curl \
    && rm -rf /var/lib/apt/lists/*

# Install .NET Core
ARG DOTNET_RUNTIME_VERSION
ARG DOTNET_RUNTIME_SHA
ENV DOTNET_DOWNLOAD_URL https://dotnetcli.blob.core.windows.net/dotnet/Runtime/$DOTNET_RUNTIME_VERSION/dotnet-runtime-$DOTNET_RUNTIME_VERSION-linux-x64.tar.gz

RUN curl -SL $DOTNET_DOWNLOAD_URL --output dotnet.tar.gz \
    && echo "$DOTNET_RUNTIME_SHA dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -zxf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz \
    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet
	
LABEL authors="Armut.com <dev@armut.com>"