# Todo App

A full-stack Todo application consisting of a .NET backend and an Angular frontend.

## Project Structure

- `Todo-Backend`: A robust RESTful API built with .NET (ASP.NET Core), featuring Entity Framework Core for data access. It includes a Dockerfile and Kubernetes manifests for easy containerization and deployment.
- `Todo-Frontend`: A modern single-page application built with Angular, providing a responsive user interface for managing todo items.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js and npm](https://nodejs.org/)
- [Docker](https://www.docker.com/) (optional, for containerized deployment)

## Getting Started

### Backend Setup

Navigate to the `Todo-Backend` directory and start the API:

```bash
cd Todo-Backend
dotnet run --project Todo-Backend
```

The API will typically be available at `https://localhost:5001` or `http://localhost:5000`.

### Frontend Setup

Navigate to the `Todo-Frontend/sql_frontend` directory, install the required dependencies, and start the development server:

```bash
cd Todo-Frontend/sql_frontend
npm install
npm start
```

The frontend application will be available in your browser at `http://localhost:4200/`.

## Deployment

Both the frontend and backend applications are container-ready:
- **Backend Dockerfile:** Located at `Todo-Backend/Dockerfile`
- **Frontend Dockerfile:** Located at `Todo-Frontend/sql_frontend/Dockerfile`

You can use the provided Kubernetes (`k8s`) manifests in the backend directory to orchestrate deployments.

### Hosted Azure Environment

The application is currently deployed and hosted on Azure Kubernetes Service (AKS). 
You can access the live frontend application at: **[http://20.204.251.219](http://20.204.251.219)**
<img width="1904" height="904" alt="Screenshot 2026-06-11 200310" src="https://github.com/user-attachments/assets/c6402ff0-5cda-4c98-9f5a-20626bdb8a9a" />
<img width="1919" height="901" alt="Screenshot 2026-06-11 200344" src="https://github.com/user-attachments/assets/ac5cf3a2-cb9d-4d08-b5d1-4ef43c1aea9d" />
<img width="1913" height="881" alt="Screenshot 2026-06-11 200336" src="https://github.com/user-attachments/assets/6ee3051f-d968-4dc5-a435-e1524ee38afe" />
<img width="1915" height="892" alt="Screenshot 2026-06-11 200327" src="https://github.com/user-attachments/assets/f4f7a621-5d50-4f88-a975-5f513060f18b" />
<img width="1916" height="882" alt="Screenshot 2026-06-11 200319" src="https://github.com/user-attachments/assets/2487d511-85b1-411d-951e-69a9a2b7ae9d" />
