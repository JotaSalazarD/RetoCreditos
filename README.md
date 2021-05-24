# Reto Técnico con .Net Core y SQL

Proyecto para la creación de créditos(reto técnico de ingreso), esucturado bajo el patron MVC

Trabajé con un módelo Kanban, para la asignación de tareas, desglosadas en un tablero en [trello](https://trello.com/b/xF6RQFeo/reto-t%C3%A9cnico) 


 
## Herramientas

.Net core
SQL
Docker
Swagger

[Docker](https://hub.docker.com/editions/community/docker-ce-desktop-windows)
[Git](https://git-scm.com/downloads)


## Descarga
```sh
git clone https://github.com/JotaSalazarD/RetoCreditos.git
cd RetoCreditos

```

## Configuración
1. En el proyecto se encuentra una carpeta SQL, con dos archivos, se debe ejecutar primero el archivo script.sql, el cual crea la base de datos, posterior a ello, se debe ejecutar el siguiente script, tablasreto, el cual almacena datos de algunos departamentos, municipios y almacena los plazos establecidos.
2. Se debe cambiar la cadena de conexiòn en el archivo RetoCreditos\ApisRetoTecnico\ApisRetoTecnico\appsettings.json

NOTA: Las tablas de Municipios y Departamentos, me basé en los códigos DANE, para estructurarla
