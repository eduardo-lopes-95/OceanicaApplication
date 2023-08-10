# Use the official NGINX image as the base image
FROM nginx:alpine

# Copy the nginx.conf file to the container
COPY nginx.conf /etc/nginx/conf.d/default.conf

# Expose port 80
EXPOSE 80

# Start NGINX
CMD ["nginx", "-g", "daemon off;"]
