#!/usr/bin/env bash

#exit if any command fails
set -e

DOTNET_VERSION=$1
OS_VERSION=$2
DOTNET_SDK_VERSION=$3
DOTNET_RUNTIME_VERSION=$4

REPO=armutteknoloji
TAG_RUNTIME_DEPS=$REPO/$OS_VERSION-dotnet:runtime-deps-$DOTNET_RUNTIME_VERSION
TAG_RUNTIME=$REPO/$OS_VERSION-dotnet:runtime-$DOTNET_RUNTIME_VERSION
TAG_SDK=$REPO/$OS_VERSION-dotnet:$DOTNET_RUNTIME_VERSION-sdk-$DOTNET_SDK_VERSION

TAG_ASPNET_RUNTIME=$REPO/$OS_VERSION-aspnet:runtime-$DOTNET_RUNTIME_VERSION
TAG_ASPNET_BUILD=$REPO/$OS_VERSION-aspnet:build-$DOTNET_RUNTIME_VERSION

TAG_RUNTIME_LATEST=$REPO/$OS_VERSION-dotnet:latest
TAG_ASPNET_RUNTIME_LATEST=$REPO/$OS_VERSION-aspnet:latest

docker build -f ./$DOTNET_VERSION/$OS_VERSION/dotnet-core/runtime-deps/Dockerfile -t $TAG_RUNTIME_DEPS ./$DOTNET_VERSION/$OS_VERSION/dotnet-core/runtime-deps/
docker build -f ./$DOTNET_VERSION/$OS_VERSION/dotnet-core/runtime/Dockerfile -t $TAG_RUNTIME ./$DOTNET_VERSION/$OS_VERSION/dotnet-core/runtime/
docker build -f ./$DOTNET_VERSION/$OS_VERSION/dotnet-core/sdk/Dockerfile -t $TAG_SDK ./$DOTNET_VERSION/$OS_VERSION/dotnet-core/sdk/

docker build -f ./$DOTNET_VERSION/$OS_VERSION/aspnet-core/runtime/Dockerfile -t $TAG_ASPNET_RUNTIME ./$DOTNET_VERSION/$OS_VERSION/aspnet-core/runtime/
docker build -f ./$DOTNET_VERSION/$OS_VERSION/aspnet-core/build/Dockerfile -t $TAG_ASPNET_BUILD ./$DOTNET_VERSION/$OS_VERSION/aspnet-core/build/

docker tag $TAG_RUNTIME $TAG_RUNTIME_LATEST
docker tag $TAG_ASPNET_RUNTIME $TAG_ASPNET_RUNTIME_LATEST

docker login -u "$(DOCKER_USER)" -p "$(DOCKER_PASS)"

docker push $TAG_RUNTIME_DEPS
docker push $TAG_RUNTIME
docker push $TAG_SDK

docker push $TAG_ASPNET_RUNTIME
docker push $TAG_ASPNET_BUILD

docker push $TAG_RUNTIME_LATEST
docker push $TAG_ASPNET_RUNTIME_LATEST