ARG RUNTIME_IMAGE
FROM ${RUNTIME_IMAGE}

# set up network
ARG DOTNET_RUNTIME_VERSION
ENV ASPNETCORE_URLS http://+:80
ENV ASPNETCORE_PKG_VERSION ${DOTNET_RUNTIME_VERSION}


RUN curl -o /tmp/runtimestore.tar.gz https://dotnetcli.blob.core.windows.net/dotnet/aspnetcore/Runtime/$ASPNETCORE_PKG_VERSION/aspnetcore-runtime-$ASPNETCORE_PKG_VERSION-linux-x64.tar.gz \
    && export DOTNET_HOME=$(dirname $(readlink $(which dotnet))) \
    && tar -x -C $DOTNET_HOME -f /tmp/runtimestore.tar.gz \
    && rm /tmp/runtimestore.tar.gz; \
    done
	
LABEL authors="Armut.com <dev@armut.com>"