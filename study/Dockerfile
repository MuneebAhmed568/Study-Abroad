# develop stage
FROM node:16.16.0-alpine3.16 as develop-stage

LABEL maintainer="Faisal Shahzad <faisalshahzad.ciit@gmail.com>"
LABEL description="It will install npm packages and runs the vue app in nginx"

WORKDIR /app
COPY package*.json ./
RUN npm install
COPY . .

# build stage
FROM develop-stage as build-stage
RUN npm run build

# production stage
FROM nginx:alpine as production-stage
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=build-stage /app/dist /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
