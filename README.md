# Dapr Zeebe Example
This project is an example of using the Zeebe JobWorker input binding for Dapr microservices.

## Requirements

* .Net 5.0
* Docker Desktop running Linux containers

## Quick start

### Clone the zeebe-docker-compose:

```bash
git clone https://github.com/camunda-community-hub/zeebe-docker-compose.git
```

### Start the Zeebe broker in zeebe-docker-compose/operate:

```bash
docker-compose up
```

### Install Camunda Cloud Modeler:

Install Camunda Cloud Modeler `https://camunda.com/download/modeler/` and deploy `dosomething.bpmn`

### Install Dapr:

```bash
powershell -Command "iwr -useb https://raw.githubusercontent.com/dapr/cli/master/install/install.ps1 | iex"
```

### Install the latest Dapr runtime binaries:

```bash
dapr init
```

### Start the project

```bash
dapr run --app-id Zeebe --app-port 5000 --components-path .\Zeebe\Components\ -- dotnet run --project ".\Zeebe\Zeebe.csproj"
```

## Services

The following Tools can be used:

| Tool                   | URI                                   |
|------------------------|---------------------------------------|
| Zeebe Operate          | http://localhost:8080                 |
| Camunda Modeler        | https://camunda.com/download/modeler/ |
