ARG IMAGE_NAME
FROM IMAGE_NAME

RUN apt-get update \
    && apt-get install -y --no-install-recommends \
        ca-certificates \
        \
# .NET Core dependencies
        libc6 \
        libcurl4 \
        libgcc1 \
        libgssapi-krb5-2 \
        libicu60 \
        liblttng-ust0 \
        libssl1.0.0 \
        libstdc++6 \
        libunwind8 \
        libuuid1 \
        zlib1g \
    && rm -rf /var/lib/apt/lists/*

# Enable detection of running in a container
ENV DOTNET_RUNNING_IN_CONTAINER=true

LABEL authors="Armut.com <dev@armut.com>"