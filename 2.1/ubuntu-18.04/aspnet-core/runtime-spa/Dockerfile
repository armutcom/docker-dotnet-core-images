FROM armutcom/aspnet-core:2.1.1-bionic

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

LABEL authors="Armut.com <dev@armut.com>"