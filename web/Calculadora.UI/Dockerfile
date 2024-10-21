# Stage 1: Build the Angular app
FROM node:18-alpine AS build

# Definir o diretório de trabalho dentro do container
WORKDIR /app

# Copiar o package.json e o package-lock.json para instalar as dependências
COPY ./web/Calculadora.UI/package*.json ./

# Instalar as dependências do projeto Angular
RUN npm install

# Copiar o restante do código-fonte da aplicação Angular
COPY ./web/Calculadora.UI .

# Gerar o build de produção da aplicação
RUN npm run build -- --configuration production

# Verifique o diretório correto após o build
RUN ls -la /app/dist

# Stage 2: Servir a aplicação Angular com Nginx
FROM nginx:alpine

# Copiar a aplicação Angular gerada para o diretório público do Nginx
COPY --from=build /app/dist/calculadora.ui /usr/share/nginx/html

# Expor a porta 80 para servir a aplicação
EXPOSE 80

# Comando para iniciar o Nginx
CMD ["nginx", "-g", "daemon off;"]
