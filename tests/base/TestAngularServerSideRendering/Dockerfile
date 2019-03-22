ARG base_image_runtime
ARG base_image_build

FROM $base_image_runtime AS base
WORKDIR /app
EXPOSE 80


FROM $base_image_build AS builder
ARG project_path
ARG NETCOREAPP_VERSION
ARG DOTNET_RUNTIME_VERSION
WORKDIR /src
COPY . .
WORKDIR /src/$project_path
ENV TARGET_FRAMEWORK ${NETCOREAPP_VERSION}
ENV PKG_VERSION ${DOTNET_RUNTIME_VERSION}
RUN dotnet restore
RUN dotnet build -c Release -o /app

FROM builder AS publisher
RUN dotnet publish -c Release -o /app

FROM base AS final
ARG run_target
WORKDIR /app
COPY --from=publisher /app .
ENV env_run_target=$run_target

ENTRYPOINT dotnet $env_run_target