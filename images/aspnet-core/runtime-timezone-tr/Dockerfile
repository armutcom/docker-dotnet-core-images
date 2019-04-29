ARG ASPNETCORE_RUNTIME_IMAGE
FROM ${ASPNETCORE_RUNTIME_IMAGE}

ENV TZ 'Turkey'
RUN echo $TZ > /etc/timezone && \
    apt-get update && apt-get install -y tzdata && \
    rm /etc/localtime && \
    ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && \
    dpkg-reconfigure -f noninteractive tzdata && \
    apt-get clean
	
LABEL authors="Armut.com <dev@armut.com>"