# Armut.com - .NET Core docker images

This repo contains the base Docker images for working with .NET Core and the .NET Core Tools based on Ubuntu images. Since the Armut.com developer team already uses these images, they will keep the images up to date and maintain it.

## Builds status

|       | Linux |
|-------|-------|
| Build | [![Build Status](https://travis-ci.com/armutcom/docker-dotnet-core-images.svg?branch=master)](https://travis-ci.com/armutcom/docker-dotnet-core-images)     |

## Base Images

All the images centralized to base images in order to make this repository simple and easy to manage.

### Runtime Deps

- [`armutcom/dotnet-core-runtime-deps ubuntu-16.04`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/runtime-deps/ubuntu-16.04/Dockerfile)
- [`armutcom/dotnet-core-runtime-deps ubuntu-18.04`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/runtime-deps/ubuntu-18.04/Dockerfile)

#### Ubuntu Xenial (16.04) amd64 tags

- .NET Core Runtime Deps 2.1 : [`armutcom/dotnet-core-runtime-deps:2.1.5-deps-xenial`]
- .NET Core Runtime Deps 2.2 : [`armutcom/dotnet-core-runtime-deps:2.2.3-deps-xenial`]

#### Ubuntu Bionic (18.04) amd64 tags

- .NET Core Runtime Deps 2.1 : [`armutcom/dotnet-core-runtime-deps:2.1.5-deps-bionic`]
- .NET Core Runtime Deps 2.2 : [`armutcom/dotnet-core-runtime-deps:2.2.3-deps-bionic`]
- .NET Core Runtime Deps 3.1 : [`armutcom/dotnet-core-runtime-deps:3.1.0-deps-bionic`]

### Dotnet Core Runtime

- [`armutcom/dotnet-core-runtime`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/dotnet-core/runtime/Dockerfile)
- [`armutcom/dotnet-core-runtime-timezone-tr`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/dotnet-core/runtime-timezone-tr/Dockerfile)
- [`armutcom/dotnet-core-runtime-newrelic`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/dotnet-core/runtime-newrelic/Dockerfile)
- [`armutcom/dotnet-core-runtime-newrelic-timezone-tr`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/dotnet-core/runtime-newrelic-timezone-tr/Dockerfile)

#### Ubuntu Xenial (16.04) amd64 tags

- .NET Core Runtime 2.1.5                               : [`armutcom/dotnet-core-runtime:2.1.5-xenial`]
- .NET Core Runtime 2.1.5 - Turkish Timezone            : [`armutcom/dotnet-core-runtime-timezone-tr:2.1.5-xenial`]
- .NET Core Runtime 2.1.5 - Newrelic                    : [`armutcom/dotnet-core-runtime-newrelic:2.1.5-xenial`]
- .NET Core Runtime 2.1.5 - Newrelic, Turkish Timezone  : [`armutcom/dotnet-core-runtime-newrelic-timezone-tr:2.1.5-xenial`]

---

- .NET Core Runtime 2.2.3                               : [`armutcom/dotnet-core-runtime:2.2.3-xenial`]
- .NET Core Runtime 2.2.3 - Turkish Timezone            : [`armutcom/dotnet-core-runtime-timezone-tr:2.2.3-xenial`]
- .NET Core Runtime 2.2.3 - Newrelic                    : [`armutcom/dotnet-core-runtime-newrelic:2.2.3-xenial`]
- .NET Core Runtime 2.2.3 - Newrelic, Turkish Timezone  : [`armutcom/dotnet-core-runtime-newrelic-timezone-tr:2.2.3-xenial`]

#### Ubuntu Bionic (18.04) amd64 tags

- .NET Core Runtime 2.1.5                               : [`armutcom/dotnet-core-runtime:2.1.5-bionic`]
- .NET Core Runtime 2.1.5 - Turkish Timezone            : [`armutcom/dotnet-core-runtime-timezone-tr:2.1.5-bionic`]
- .NET Core Runtime 2.1.5 - Newrelic                    : [`armutcom/dotnet-core-runtime-newrelic:2.1.5-bionic`]
- .NET Core Runtime 2.1.5 - Newrelic, Turkish Timezone  : [`armutcom/dotnet-core-runtime-newrelic-timezone-tr:2.1.5-bionic`]

---

- .NET Core Runtime 2.2.3                               : [`armutcom/dotnet-core-runtime:2.2.3-bionic`]
- .NET Core Runtime 2.2.3 - Turkish Timezone            : [`armutcom/dotnet-core-runtime-timezone-tr:2.2.3-bionic`]
- .NET Core Runtime 2.2.3 - Newrelic                    : [`armutcom/dotnet-core-runtime-newrelic:2.2.3-bionic`]
- .NET Core Runtime 2.2.3 - Newrelic, Turkish Timezone  : [`armutcom/dotnet-core-runtime-newrelic-timezone-tr:2.2.3-bionic`]

---

- .NET Core Runtime 3.1.0                               : [`armutcom/dotnet-core-runtime:3.1.0-bionic`]
- .NET Core Runtime 3.1.0 - Turkish Timezone            : [`armutcom/dotnet-core-runtime-timezone-tr:3.1.0-bionic`]
- .NET Core Runtime 3.1.0 - Newrelic                    : [`armutcom/dotnet-core-runtime-newrelic:3.1.0-bionic`]
- .NET Core Runtime 3.1.0 - Newrelic, Turkish Timezone  : [`armutcom/dotnet-core-runtime-newrelic-timezone-tr:3.1.0-bionic`]

### Dotnet Core Sdk

- [`armutcom/dotnet-core-sdk ubuntu-16.04`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/dotnet-core/sdk/ubuntu-16.04/Dockerfile)
- [`armutcom/dotnet-core-sdk ubuntu-18.04`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/dotnet-core/sdk/ubuntu-18.04/Dockerfile)

#### Ubuntu Xenial (16.04) amd64 tags

- .NET Core Sdk 2.1.5 : [`armutcom/dotnet-core-sdk:2.1.403-runtime-2.1.5-xenial`, `armutcom/dotnet-core-sdk:2.1.403-xenial`, `armutcom/dotnet-core-sdk:2.1-xenial`]
- .NET Core Sdk 2.2.3 : [`armutcom/dotnet-core-sdk:2.2.105-runtime-2.2.3-xenial`]

#### Ubuntu Bionic (18.04) amd64 tags

- .NET Core Sdk 2.1.5 : [`armutcom/dotnet-core-sdk:2.1.403-runtime-2.1.5-bionic`, `armutcom/dotnet-core-sdk:2.1.403-bionic`, `armutcom/dotnet-core-sdk:2.1-bionic`]
- .NET Core Sdk 2.2.3 : [`armutcom/dotnet-core-sdk:2.2.105-runtime-2.2.3-bionic`]
- .NET Core Sdk 3.1.0 : [`armutcom/dotnet-core-sdk:3.1.100-runtime-3.1.0-bionic`]

### AspNet Core Build

- [`armutcom/aspnet-core-build`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/aspnet-core/build/Dockerfile)

#### Ubuntu Xenial (16.04) amd64 tags

- ASP.NET Core Build 2.1.5 : [`armutcom/aspnet-core-build:2.1.5-sdk-2.1.403-node-8.11.2-build-xenial`, `armutcom/aspnet-core-build:2.1.5-sdk-2.1.403-build-xenial`, `armutcom/aspnet-core-build:2.1-build-xenial`]
- ASP.NET Core Build 2.2.3 : [`armutcom/aspnet-core-build:2.2.3-sdk-2.2.105-node-8.11.2-build-xenial`, `armutcom/aspnet-core-build:2.2.3-sdk-2.2.105-build-xenial`, `armutcom/aspnet-core-build:2.2-build-xenial`]

#### Ubuntu Bionic (18.04) amd64 tags

- ASP.NET Core Build 2.1.5 : [`armutcom/aspnet-core-build:2.1.5-sdk-2.1.403-node-8.11.2-build-bionic`, `armutcom/aspnet-core-build:2.1.5-sdk-2.1.403-build-bionic`, `armutcom/aspnet-core-build:2.1-build-bionic`]
- ASP.NET Core Build 2.2.3 : [`armutcom/aspnet-core-build:2.2.3-sdk-2.2.105-node-8.11.2-build-bionic`, `armutcom/aspnet-core-build:2.2.3-sdk-2.2.105-build-bionic`, `armutcom/aspnet-core-build:2.2-build-bionic`]
- ASP.NET Core Build 3.1.0 : [`armutcom/aspnet-core-build:3.1.0-sdk-3.1.100-node-8.11.2-build-bionic`, `armutcom/aspnet-core-build:3.1.0-sdk-3.1.100-build-bionic`, `armutcom/aspnet-core-build:3.1-build-bionic`]

### AspNet Core Runtime

- [`armutcom/aspnet-core-runtime`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/aspnet-core/runtime/Dockerfile)

#### Ubuntu Xenial (16.04) amd64 tags

- ASP.NET Core 2.1.5 : [`armutcom/aspnet-core-runtime:2.1.5-xenial`, `armutcom/aspnet-core-runtime:2.1-xenial`]
- ASP.NET Core 2.2.3 : [`armutcom/aspnet-core-runtime:2.2.3-xenial`, `armutcom/aspnet-core-runtime:2.2-xenial`]

#### Ubuntu Bionic (18.04) amd64 tags

- ASP.NET Core 2.1.5 : [`armutcom/aspnet-core-runtime:2.1.5-bionic`, `armutcom/aspnet-core-runtime:2.1-bionic`]
- ASP.NET Core 2.2.3 : [`armutcom/aspnet-core-runtime:2.2.3-bionic`, `armutcom/aspnet-core-runtime:2.2-bionic`]
- ASP.NET Core 3.1.0 : [`armutcom/aspnet-core-runtime:3.1.0-bionic`, `armutcom/aspnet-core-runtime:3.1-bionic`]

### AspNet Core Runtime Spa

- [`armutcom/aspnet-core-runtime-spa`](https://github.com/armutcom/docker-dotnet-core-images/blob/master/images/aspnet-core/runtime-spa/Dockerfile)

#### Ubuntu Xenial (16.04) amd64 tags

- ASP.NET Core 2.1.5 SPA : [`armutcom/aspnet-core-runtime-spa:2.1.5-spa-node-8.11.2-xenial`, `armutcom/aspnet-core-runtime-spa:2.1-spa-xenial`]
- ASP.NET Core 2.2.3 SPA : [`armutcom/aspnet-core-runtime-spa:2.2.3-spa-node-8.11.2-xenial`, `armutcom/aspnet-core-runtime-spa:2.2-spa-xenial`]

#### Ubuntu Bionic (18.04) amd64 tags

- ASP.NET Core 2.1.5 SPA : [`armutcom/aspnet-core-runtime-spa:2.1.5-spa-node-8.11.2-bionic`, `armutcom/aspnet-core-runtime-spa:2.1-spa-bionic`]
- ASP.NET Core 2.2.3 SPA : [`armutcom/aspnet-core-runtime-spa:2.2.3-spa-node-8.11.2-bionic`, `armutcom/aspnet-core-runtime-spa:2.2-spa-bionic`]
- ASP.NET Core 3.1.0 SPA : [`armutcom/aspnet-core-runtime-spa:3.1.0-spa-node-8.11.2-bionic`, `armutcom/aspnet-core-runtime-spa:3.1-spa-bionic`]

## Image variants

The `armutcom/dotnet-core-runtime/`, `armutcom/dotnet-core-runtime-timezone-tr/`, `armutcom/dotnet-core-runtime-newrelic/`, `armutcom/dotnet-core-runtime-newrelic-timezone-tr/`, `armutcom/dotnet-core-sdk/`, `armutcom/aspnet-core/` images come in different flavors, each designed for a specific use case.

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

### `armutcom/dotnet-core-runtime-newrelic:<version>-<os>`

This image contains Newrelic with .Net Core runtimes and libraries and is optimized for running .NET Core apps in production.

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

- [.NET Core license](https://github.com/dotnet/dotnet-docker/blob/master/LICENSE)

## Armut.com - .NET Core Docker Hub repos

- [armutcom/aspnet-core](https://hub.docker.com/r/armutcom/aspnet-core/) for ASP.NET Core images.
- [armutcom/dotnet-core-runtime](https://hub.docker.com/r/armutcom/dotnet-core-runtime/) for .NET Core images.
- [armutcom/dotnet-core-runtime-timezone-tr](https://hub.docker.com/r/armutcom/dotnet-core-runtime-timezone-tr/) for .NET Core Turkish timezone images.
- [armutcom/dotnet-core-runtime-newrelic](https://hub.docker.com/r/armutcom/dotnet-core-runtime-newrelic/) for .NET Core Newrelic images.
- [armutcom/dotnet-core-runtime-timezone-tr-newrelic](https://hub.docker.com/r/armutcom/dotnet-core-runtime-timezone-tr-newrelic/) for .NET Core Newrelic - Turkish timezone images.
- [armutcom/dotnet-core-sdk](https://hub.docker.com/r/armutcom/dotnet-core-sdk/) for .NET Core SDK images.

## Official Microsoft Hub repos

.NET Core Docker Hub repos:

- [microsoft/aspnetcore](https://hub.docker.com/r/microsoft/aspnetcore/) for ASP.NET Core images.
- [microsoft/dotnet-nightly](https://hub.docker.com/r/microsoft/dotnet-nightly/) for .NET Core preview images.
- [microsoft/dotnet-samples](https://hub.docker.com/r/microsoft/dotnet-samples/) for .NET Core sample images.

.NET Framework Docker Hub repos:

- [microsoft/aspnet](https://hub.docker.com/r/microsoft/aspnet/) for ASP.NET Web Forms and MVC images.
- [microsoft/dotnet-framework](https://hub.docker.com/r/microsoft/dotnet-framework/) for .NET Framework images.
- [microsoft/dotnet-framework-build](https://hub.docker.com/r/microsoft/dotnet-framework-build/) for building .NET Framework applications with Docker.
- [microsoft/dotnet-framework-samples](https://hub.docker.com/r/microsoft/dotnet-framework-samples/) for .NET Framework and ASP.NET sample images.
