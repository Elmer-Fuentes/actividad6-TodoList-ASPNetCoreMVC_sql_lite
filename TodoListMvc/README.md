# TodoList MVC - Actividad 6
Proyecto ASP.NET Core MVC (.NET 8) con SQLite, Git y Docker.

## Versiones incluidas
El repositorio incluye los tags `v1.0` y `v2.0`.

```bash
git tag
git checkout v1.0
git checkout v2.0
```

## Ejecutar localmente
```bash
dotnet restore
dotnet run
```

## Docker v1.0
```bash
git checkout v1.0
docker build -t TU_USUARIO_DOCKERHUB/749023230907:1.0 .
docker run -d --name todolist-749023230907 -p 8080:8080 -v todolist-data:/data TU_USUARIO_DOCKERHUB/749023230907:1.0
docker ps
docker logs todolist-749023230907
docker login
docker push TU_USUARIO_DOCKERHUB/749023230907:1.0
```

## Docker v2.0
```bash
git checkout v2.0
docker build -t TU_USUARIO_DOCKERHUB/749023230907:2.0 .
docker push TU_USUARIO_DOCKERHUB/749023230907:2.0
```

## Despliegue en servidor
```bash
docker pull TU_USUARIO_DOCKERHUB/749023230907:1.0
docker run -d --name todolist-749023230907 --restart unless-stopped -p PUERTO_ASIGNADO:8080 -v todolist-data:/data TU_USUARIO_DOCKERHUB/749023230907:1.0
```
Abrir: `http://IP_SERVIDOR:PUERTO_ASIGNADO`

## Actualización a 2.0
```bash
docker stop todolist-749023230907
docker rm todolist-749023230907
docker pull TU_USUARIO_DOCKERHUB/749023230907:2.0
docker run -d --name todolist-749023230907 --restart unless-stopped -p PUERTO_ASIGNADO:8080 -v todolist-data:/data TU_USUARIO_DOCKERHUB/749023230907:2.0
```

## Rollback a 1.0
```bash
docker stop todolist-749023230907
docker rm todolist-749023230907
docker run -d --name todolist-749023230907 --restart unless-stopped -p PUERTO_ASIGNADO:8080 -v todolist-data:/data TU_USUARIO_DOCKERHUB/749023230907:1.0
```
No publiques contraseñas, tokens ni credenciales en Git.
