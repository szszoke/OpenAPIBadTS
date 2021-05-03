FROM openapitools/openapi-generator-cli:latest

WORKDIR /app

COPY . /app
RUN rm /app/openapitools.json

RUN docker-entrypoint.sh generate -o web_client -i swagger.json -g typescript-axios -c config.json

RUN cat web_client/api/weather-forecast-api.ts