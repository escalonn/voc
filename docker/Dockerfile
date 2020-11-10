FROM ubuntu:bionic

RUN apt-get update \
    && apt-get install -y --no-install-recommends \
#        ca-certificates \
#        curl \
        xdg-utils \
    && rm -rf /var/lib/apt/lists/*

RUN mkdir -p /opt \
    && curl -sSL https://dl.pstmn.io/download/latest/linux64 \
    | tar -xzC /opt

RUN mkdir -p /opt \
    && curl -sS https://downloads.yoctoproject.org/eclipse-full/technology/epp/downloads/release/2020-09/R/eclipse-java-2020-09-R-linux-gtk-x86_64.tar.gz \
    | tar -xzC /opt

COPY *.desktop ~/.local/share/applications/
