# Use the official Node.js Alpine image as the base image
FROM node:14-alpine

# Set the working directory in the container
WORKDIR /app

# Copy package.json and package-lock.json to the container
COPY package*.json ./

# Install dependencies
RUN npm install

# Copy the rest of the application code
COPY . .

# Build the React app
RUN npm run build

# Expose the container's port (you can change this if needed)
EXPOSE 80

# Start the application
CMD ["npm", "start"]
