# dapr-zeebe-example
This project is an example of using the [Zeebe] JobWorker input binding for [Dapr] microservices.

## Requirements

* .Net 5.0
* Docker Desktop running Linux containers

## Quick start

Clone the zeebe-doker-compose:

```bash
git clone https://github.com/camunda-community-hub/zeebe-docker-compose.git
```

Start the Zeebe broker in zeebe-docker-compose/operate:

```bash
docker-compose up
```

Install Dapr:

```bash
powershell -Command "iwr -useb https://raw.githubusercontent.com/dapr/cli/master/install/install.ps1 | iex"
```

Install the latest Dapr runtime binaries:

```bash
dapr init
```
