# Actividad 6 - TodoList ASP.NET Core MVC con SQLite

Proyecto desarrollado para la actividad de Implementación de Software.

La aplicación consiste en un sistema TodoList desarrollado con ASP.NET Core MVC .NET 10, Entity Framework Core 10 y SQLite.

## Tecnologías utilizadas

- ASP.NET Core MVC .NET 10
- Entity Framework Core 10
- SQLite
- Bootstrap 5
- Git
- GitHub
- Docker
- Docker Hub

## Funcionalidades

### Versión 1.0

La versión 1.0 incluye las funciones principales para administrar tareas:

- Crear tareas
- Listar tareas
- Editar tareas
- Eliminar tareas
- Manejo de estados:
  - PENDIENTE
  - EN PROGRESO
  - COMPLETADA
- Fecha de creación
- Persistencia de información con SQLite

### Versión 2.0

La versión 2.0 incorpora mejoras adicionales:

- Buscador por título o descripción
- Filtro por estado
- Resumen estadístico de tareas
- Visualización identificada como TodoList v2.0

## Estructura de versiones

El repositorio contiene las siguientes ramas:

- `main` - versión estable actual
- `version/1.0` - código correspondiente a la versión 1.0
- `version/2.0` - código correspondiente a la versión 2.0

También se incluyen los tags:

- `v1.0`
- `v2.0`

## Base de datos

La aplicación utiliza SQLite como base de datos.

La conexión principal se maneja mediante:

```text
Data Source=todolist.db
