FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr
RUN mkdir /app
WORKDIR /app
COPY global.json /app/
COPY ./api/project.json /app/api/
COPY ./unit-tests/project.json /app/unit-tests/
RUN ["dnu","restore"]
COPY . /app
ENTRYPOINT ["dnx", "-p", "./unit-tests/project.json", "test"]