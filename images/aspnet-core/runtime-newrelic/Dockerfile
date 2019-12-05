ARG ASPNETCORE_RUNTIME_IMAGE
FROM ${ASPNETCORE_RUNTIME_IMAGE}

ENV CORECLR_ENABLE_PROFILING=1 \
CORECLR_PROFILER={36032161-FFC0-4B61-B559-F6C5D41BAE5A} \
CORECLR_NEWRELIC_HOME=/usr/local/newrelic-netcore20-agent \
CORECLR_PROFILER_PATH=/usr/local/newrelic-netcore20-agent/libNewRelicProfiler.so

RUN curl https://download.newrelic.com/dot_net_agent/latest_release/newrelic-netcore20-agent_8.21.34.0_amd64.deb -o newrelic-netcore-agent.deb
RUN dpkg -i newrelic-netcore-agent.deb

LABEL authors="Armut.com <dev@armut.com>"