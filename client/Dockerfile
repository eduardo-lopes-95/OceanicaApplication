FROM node:16 AS build

WORKDIR /app

COPY . .

RUN npm run build

CMD [ "npm", "start" ]