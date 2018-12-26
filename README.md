# SimpleInfoServer
The demo project for the K8s training

## To run container

With default port
```
docker run -p 8080:80 sadedil/simpleinfoserver:latest
```

With custom port

```
docker run -e "ASPNETCORE_URLS=http://+:8080" -p 8080:8080 sadedil/simpleinfoserver:latest
```

and access from `http://localhost:8080/`