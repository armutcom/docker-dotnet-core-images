# Armut.com - .NET Core docker images

This repo contains the base Docker images for working with .NET Core and the .NET Core Tools based on Ubuntu images. Since the Armut.com developer team already uses these images, they will keep the images up to date and maintain it.

## Builds status
|       | Linux |
|-------|-------|
| Build | [![Build Status](https://travis-ci.com/armutcom/docker-dotnet-core-images.svg?branch=master)](https://travis-ci.com/armutcom/docker-dotnet-core-images)     | 

# Latest Version of Common Tags

The following tags are the latest stable versions of the most commonly used images. The complete set of tags is listed further down.

- [`armutcom/aspnet-core:2.3`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.3/ubuntu-18.04/aspnet-core/runtime/Dockerfile)
- [`armutcom/dotnet-core:2.3`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.3/ubuntu-18.04/dotnet-core/runtime/Dockerfile)
- [`armutcom/dotnet-core-sdk:2.3`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.3/ubuntu-18.04/dotnet-core/sdk/Dockerfile)

- [`armutcom/aspnet-core:2.1`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/aspnet-core/runtime/Dockerfile)
- [`armutcom/dotnet-core:2.1`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/dotnet-core/runtime/Dockerfile)
- [`armutcom/dotnet-core-sdk:2.1`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/dotnet-core/sdk/Dockerfile)

- [`armutcom/aspnet-core:2.0`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/aspnet-core/runtime/Dockerfile)
- [`armutcom/dotnet-core:2.0`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/dotnet-core/runtime/Dockerfile)
- [`armutcom/dotnet-core-sdk:2.0`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/dotnet-core/sdk/Dockerfile)

# Complete set of Tags

## Ubuntu Xenial (16.04) amd64 tags
- .NET Core Runtime Deps 2.1 : [`2.1.3-deps-xenial`, `2.1.1-deps-xenial`, `2.1-deps-xenial` (*2.1/ubuntu-16.04/dotnet-core/runtime-deps/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/runtime-deps/ubuntu-16.04/Dockerfile)

### 2.1.3
- .NET Core Runtime 2.1.3 : [`2.1.3-xenial`, `xenial-latest` (*2.1/ubuntu-16.04/dotnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/dotnet-core/runtime/Dockerfile)
- .NET Core Sdk 2.1.3 : [`2.1.401-runtime-2.1.3-xenial`, `2.1.401-xenial`, `2.1-xenial` (*2.1/ubuntu-16.04/dotnet-core/sdk/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/dotnet-core/sdk/Dockerfile)
- ASP.NET Core 2.1.3 : [`2.1.3-xenial`, `2.1-xenial`, `xenial-latest` (*2.1/ubuntu-16.04/aspnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/aspnet-core/runtime/Dockerfile)
- ASP.NET Core 2.1.3 SPA : [`2.1.3-spa-node-8.11.2-xenial`, `2.1-spa-xenial`, `spa-xenial-latest`, `spa-xenial` (*2.1/ubuntu-16.04/aspnet-core/runtime-spa/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/aspnet-core/runtime-spa/Dockerfile)
- ASP.NET Core Build 2.1.3 : [`2.1.3-sdk-2.1.401-node-8.11.2-build-xenial`, `2.1.3-sdk-2.1.401-build-xenial`, `2.1-build-xenial`, `build-xenial-latest` (*2.1/ubuntu-16.04/aspnet-core/build/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/aspnet-core/build/Dockerfile)

### 2.1.1
- .NET Core Runtime 2.1.1 : [`2.1.1-xenial`, `2.1-xenial` (*2.1/ubuntu-16.04/dotnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/dotnet-core/runtime/Dockerfile)
- .NET Core Sdk 2.1.1 : [`2.1.301-runtime-2.1.1-xenial`, `2.1.301-xenial` (*2.1/ubuntu-16.04/dotnet-core/sdk/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/dotnet-core/sdk/Dockerfile)
- ASP.NET Core 2.1.1 : [`2.1.1-xenial` (*2.1/ubuntu-16.04/aspnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/aspnet-core/runtime/Dockerfile)
- ASP.NET Core 2.1.1 SPA : [`2.1.1-spa-node-8.11.2-xenial` (*2.1/ubuntu-16.04/aspnet-core/runtime-spa/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/aspnet-core/runtime-spa/Dockerfile)
- ASP.NET Core Build 2.1.1 : [`2.1.1-sdk-2.1.301-node-8.11.2-build-xenial`, `2.1.1-sdk-2.1.301-build-xenial` (*2.1/ubuntu-16.04/aspnet-core/build/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-16.04/aspnet-core/build/Dockerfile)

- .NET Core Runtime Deps 2.0 : [`2.0.7-deps-xenial`, `2.0-deps-xenial` (*2.0/ubuntu-16.04/dotnet-core/runtime-deps/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/runtime-deps/ubuntu-16.04/Dockerfile)
- .NET Core Runtime 2.0 : [`2.0.7-xenial`, `2.0-xenial` (*2.0/ubuntu-16.04/dotnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-16.04/dotnet-core/runtime/Dockerfile)
- .NET Core Sdk 2.0 : [`2.1.200-runtime-2.0.7-xenial`, `2.1.200-xenial`, `2.0-xenial` (*2.0/ubuntu-16.04/dotnet-core/sdk/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-16.04/dotnet-core/sdk/Dockerfile)
- ASP.NET Core 2.0 : [`2.0.8-xenial`, `2.0-xenial` (*2.0/ubuntu-16.04/aspnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-16.04/aspnet-core/runtime/Dockerfile)
- ASP.NET Core 2.0 SPA : [`2.0.8-spa-node-8.11.2-xenial`, `2.0-spa-xenial` (*2.0/ubuntu-16.04/aspnet-core/runtime-spa/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-16.04/aspnet-core/runtime-spa/Dockerfile)
- ASP.NET Core Build 2.0 : [`2.0.8-sdk-2.1.200-node-8.11.2-build-xenial`, `2.0.8-sdk-2.1.200-build-xenial`, `2.0-build-xenial` (*2.0/ubuntu-16.04/aspnet-core/build/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-16.04/aspnet-core/build/Dockerfile)

## Ubuntu Bionic (18.04) amd64 tags
- .NET Core Runtime Deps 2.1 : [`2.1.1-deps-bionic`, `2.1-deps-bionic`, `2.1-deps`, `deps` (*2.1/ubuntu-18.04/dotnet-core/runtime-deps/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/runtime-deps/ubuntu-16.04/Dockerfile)

### 2.1.3
- .NET Core Runtime 2.1.3 : [`2.1.3-bionic`, `2.1-bionic`, `2.1`, `bionic-latest`, `latest` (*2.1/ubuntu-18.04/dotnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/dotnet-core/runtime/Dockerfile)
- .NET Core Sdk 2.1.3 : [`2.1.401-runtime-2.1.3-bionic`, `2.1.401-bionic`, `2.1-bionic`, `2.1`, `latest`(*2.0/ubuntu-18.04/dotnet-core/sdk/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/dotnet-core/sdk/Dockerfile)
- ASP.NET Core 2.1.3 : [`2.1.3-bionic`,`2.1-bionic`, `2.1`, `bionic-latest`, `latest` (*2.1/ubuntu-18.04/aspnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/aspnet-core/runtime/Dockerfile)
- ASP.NET Core 2.1.3 SPA : [`2.1.3-spa-node-8.11.2-bionic`, `2.1-spa-bionic`, `2.1-spa`, `spa-bionic-latest`, `spa-bionic`, `spa` (*2.1/ubuntu-18.04/aspnet-core/runtime-spa/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/aspnet-core/runtime-spa/Dockerfile)
- ASP.NET Core Build 2.1.3 : [`2.1.3-sdk-2.1.401-node-8.11.2-build-bionic`, `2.1.3-sdk-2.1.401-build-bionic`, `2.1-build-bionic`, `2.1-build`, `build-bionic-latest`, `build-latest`, `build` (*2.1/ubuntu-18.04/aspnet-core/build/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/aspnet-core/build/Dockerfile)

### 2.1.1
- .NET Core Runtime 2.1.1 : [`2.1.1-bionic`, `2.1-bionic` (*2.1/ubuntu-18.04/dotnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/dotnet-core/runtime/Dockerfile)
- .NET Core Sdk 2.1.1 : [`2.1.301-runtime-2.1.1-bionic`, `2.1.301-bionic` (*2.0/ubuntu-18.04/dotnet-core/sdk/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/dotnet-core/sdk/Dockerfile)
- ASP.NET Core 2.1.1 : [`2.1.1-bionic` (*2.1/ubuntu-18.04/aspnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/aspnet-core/runtime/Dockerfile)
- ASP.NET Core 2.1.1 SPA : [`2.1.1-spa-node-8.11.2-bionic` (*2.1/ubuntu-18.04/aspnet-core/runtime-spa/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/aspnet-core/runtime-spa/Dockerfile)
- ASP.NET Core Build 2.1.1 : [`2.1.1-sdk-2.1.301-node-8.11.2-build-bionic`, `2.1.1-sdk-2.1.301-build-bionic` (*2.1/ubuntu-18.04/aspnet-core/build/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.1/ubuntu-18.04/aspnet-core/build/Dockerfile)

- .NET Core Runtime Deps 2.0 : [`2.0.7-deps-bionic`, `2.0-deps-bionic`, `2.0-deps` (*2.0/ubuntu-18.04/dotnet-core/runtime-deps/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/runtime-deps/ubuntu-16.04/Dockerfile) 
- .NET Core Runtime 2.0 : [`2.0.7-bionic`, `2.0-bionic`, `2.0` (*2.0/ubuntu-18.04/dotnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/dotnet-core/runtime/Dockerfile)
- .NET Core Sdk 2.0 : [`2.1.200-runtime-2.0.7-bionic`, `2.1.200-bionic`, `2.0-bionic`, `2.0` (*2.0/ubuntu-18.04/dotnet-core/sdk/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/dotnet-core/sdk/Dockerfile)
- ASP.NET Core 2.0 : [`2.0.8-bionic`,`2.0-bionic`, `2.0` (*2.0/ubuntu-18.04/aspnet-core/runtime/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/aspnet-core/runtime/Dockerfile)
- ASP.NET Core 2.0 SPA : [`2.0.8-spa-node-8.11.2-bionic`, `2.0-spa-bionic`, `2.0-spa` (*2.0/ubuntu-18.04/aspnet-core/runtime-spa/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/aspnet-core/runtime-spa/Dockerfile)
- ASP.NET Core Build 2.0 : [`2.0.8-sdk-2.1.200-node-8.11.2-build-bionic`, `2.0.8-sdk-2.1.200-build-bionic`, `2.0-build-bionic`, `2.0-build` (*2.0/ubuntu-18.04/aspnet-core/build/Dockerfile*)](https://github.com/armutcom/docker-dotnet-core-images/blob/master/2.0/ubuntu-18.04/aspnet-core/build/Dockerfile)

## Image variants

The `armutcom/dotnet-core-runtime/`, `armutcom/dotnet-core-sdk/`, `armutcom/aspnet-core/` images come in different flavors, each designed for a specific use case.

### `armutcom/aspnet-core:<version>-<os>`

This image contains the ASP.NET Core and .NET Core runtimes and libraries and is optimized for running ASP.NET Core apps in production.

### `armutcom/aspnet-core:<version>-spa-node-<node-version>-<os>`

This image contains the ASP.NET Core, .NET Core and Node.js runtimes and libraries and is optimized for running ASP.NET Core SPA apps (server pre-rendering) like [Angular Universal](https://universal.angular.io/overview/) or [React Server Rendering](https://redux.js.org/recipes/server-rendering) in production.

### `armutcom/dotnet-core-runtime:<version>-<os>`

This image contains the .NET Core runtimes and libraries and is optimized for running .NET Core apps in production.

### `armutcom/dotnet-core-sdk:<sdk-version>-runtime-<runtime-version>-<os>`

This is the defacto image. If you are unsure about what your needs are, you probably want to use this one. It is designed to be used both as a throw away container (mount your source code and start the container to start your app), as well as the base to build other images off of.

It contains the .NET Core SDK which is comprised of two parts:

1. .NET Core CLI
1. .NET Core
1. ASP.NET Core

Use this image for your development process (developing, building and testing applications).

### `armutcom/dotnet-core-runtime:<version>-deps-<os>`

This image contains the native dependencies needed by .NET Core. It does not include .NET Core. It is for  [self-contained](https://docs.microsoft.com/dotnet/articles/core/deploying/index) applications.

### `armutcom/aspnet-core:<aspnet-version>-sdk-<sdk-version>-node-<node-version>-build-<os>`

This is the build image for both ASP.NET Core and ASP.NET Core SPA apps (server pre-rendering) like [Angular Universal](https://universal.angular.io/overview/) or [React Server Rendering](https://redux.js.org/recipes/server-rendering). It is designed to be used both as a throw away container (mount your source code and start the container to start your app), as well as the base to build other images off of.

It contains the both .NET Core SDK which is comprised of two parts and Node.js:

1. .NET Core CLI
1. .NET Core
1. ASP.NET Core
1. Node.js

Use this image for your development process (developing, building and testing applications).

## Issues

If you have any problems with or questions about this image, please contact us through a [GitHub issue](https://github.com/armutcom/docker-dotnet-core-images/issues).

## Licenses
Licensed under MIT, see [LICENSE](LICENSE) for the full text.

* [.NET Core license](https://github.com/dotnet/dotnet-docker/blob/master/LICENSE)

## Armut.com - .NET Core Docker Hub repos:

* [armutcom/aspnet-core](https://hub.docker.com/r/armutcom/aspnet-core/) for ASP.NET Core images.
* [armutcom/dotnet-core-runtime](https://hub.docker.com/r/armutcom/dotnet-core-runtime/) for .NET Core images.
* [armutcom/dotnet-core-sdk](https://hub.docker.com/r/armutcom/dotnet-core-sdk/) for .NET Core SDK images.

## Official Microsoft Hub repos :

.NET Core Docker Hub repos:

* [microsoft/aspnetcore](https://hub.docker.com/r/microsoft/aspnetcore/) for ASP.NET Core images.
* [microsoft/dotnet-nightly](https://hub.docker.com/r/microsoft/dotnet-nightly/) for .NET Core preview images.
* [microsoft/dotnet-samples](https://hub.docker.com/r/microsoft/dotnet-samples/) for .NET Core sample images.

.NET Framework Docker Hub repos:

* [microsoft/aspnet](https://hub.docker.com/r/microsoft/aspnet/) for ASP.NET Web Forms and MVC images.
* [microsoft/dotnet-framework](https://hub.docker.com/r/microsoft/dotnet-framework/) for .NET Framework images.
* [microsoft/dotnet-framework-build](https://hub.docker.com/r/microsoft/dotnet-framework-build/) for building .NET Framework applications with Docker.
* [microsoft/dotnet-framework-samples](https://hub.docker.com/r/microsoft/dotnet-framework-samples/) for .NET Framework and ASP.NET sample images.
