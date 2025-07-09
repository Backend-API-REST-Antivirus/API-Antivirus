# 📄 API Antivirus

El objetivo de este proyecto es desarrollar una serie de API’s con **.NET 9** y **C#**, para gestionar entidades como usuarios, instituciones, oportunidades, bootcamps y sus relaciones.  
Utiliza **PostgreSQL** como base de datos, **JWT** para autenticación del rol administrador y la documentación se genera automáticamente con **Swagger/OpenAPI**.

---

## 🚀 Tecnologías utilizadas
- [.NET 9](https://dotnet.microsoft.com/) y C#
- Entity Framework Core
- PostgreSQL
- JWT para autenticación
- Swagger / OpenAPI para documentación
- GitHub para control de versiones

---

## 🛠️ Instalación

### Clonar el repositorio
git clone https://github.com/Backend-API-REST-Antivirus
cd Api-Antivirus/

### Instalar dependencias y herramientas
dotnet add package DotNetEnv
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

dotnet tool install --global dotnet-ef

### Configurar la base de datos
Edita \`appsettings.json\` y añade la cadena de conexión con tus credenciales de PostgreSQL:
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=antivirus;Username=tu_usuario;Password=tu_contraseña"
  }
}

### Crear la base de datos
dotnet ef migrations add InitialCreate
dotnet ef database update

---

## 🔐 Cómo probar el backend

1️⃣ Levanta la base de datos PostgreSQL (asegúrate de que la conexión de \`appsettings.json\` sea correcta).  
2️⃣ Ejecuta el proyecto:

dotnet build
dotnet run

3️⃣ Abre tu navegador en (Local):

http://localhost:5041/swagger/index.html

Ahí verás la documentación interactiva (Swagger) con todos los endpoints.

4️⃣ Abre tu navegador en (Produccion):

https://api-antivirus.duckdns.org/

### 🔑 Credenciales
Para las rutas que requieren autenticación con el rol **admin**, utiliza un JWT válido.  
*(Puedes generarlo según tu implementación en el login, este README no incluye tokens reales por seguridad.)*
---

## 📋 Endpoints disponibles

### 🔒 Instituciones
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`POST\` | \`/api/auth/register\` | Registra Usuarios |
| \`POST\` | \`/api/auth/login\` | Inicio de Sesion |

### 📚 Instituciones
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/Institutions\` | Lista todas las instituciones |
| \`POST\` | \`/api/Institutions\` | Crea una nueva institución |
| \`PUT\` | \`/api/Institutions/{id}\` | Actualiza una institución |
| \`GET\` | \`/api/Institutions/{id}\` | Lista una institucion |
| \`DELETE\` | \`/api/Institutions/{id}\` | Elimina una institución |

### 🎓 Oportunidades
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/Opportunities\` | Lista todas las oportunidades |
| \`POST\` | \`/api/Opportunities\` | Crea una nueva oportunidad |
| \`PUT\` | \`/api/Opportunities/{id}\` | Actualiza una oportunidad |
| \`GET\` | \`/api/Opportunities/{id}\` | Lista una oportunidad |
| \`DELETE\` | \`/api/Opportunities/{id}\` | Elimina una oportunidad |

### 🎓 Usuarios Oportunidades
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/Opportunities\` | Lista todas las oportunidades |
| \`POST\` | \`/api/Opportunities\` | Crea una nueva oportunidad |
| \`PUT\` | \`/api/Opportunities/{id}\` | Actualiza una oportunidad |
| \`GET\` | \`/api/Opportunities/{id}\` | Lista una oportunidad |
| \`DELETE\` | \`/api/Opportunities/{id}\` | Elimina una oportunidad |
| \`GET\` | \`/api/Opportunities/user/{id}\` | Lista una oportunidad por usuario |
| \`GET\` | \`/api/Opportunities/exists\` | Verifica si una relacion existe |

### 🚀 Bootcamps
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/Bootcamp\` | Lista todos los bootcamps |
| \`POST\` | \`/api/Bootcamp\` | Crea un nuevo bootcamp |
| \`PUT\` | \`/api/Bootcamp/{id}\` | Actualiza un bootcamp |
| \`GET\` | \`/api/Bootcamp/{id}\` | Lista un bootcamp |
| \`DELETE\` | \`/api/Bootcamp/{id}\` | Elimina un bootcamp |

### 🚀 Bootcamps Temas
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/BootcampTopic\` | Lista todos los bootcamps temas |
| \`POST\` | \`/api/BootcampTopic\` | Crea un nuevo bootcamp temas |
| \`PUT\` | \`/api/BootcampTopic/{id}\` | Actualiza un bootcamp temas |
| \`DELETE\` | \`/api/BootcampTopic/{id}\` | Elimina un bootcamp temas |

### 📂 Categorías
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/Categories\` | Lista todas las categorías |
| \`POST\` | \`/api/Categories\` | Crea una nueva categoría |
| \`PUT\` | \`/api/Categories/{id}\` | Actualiza una categoría |
| \`GET\` | \`/api/Categories/{id}\` | Lista una categoria |
| \`DELETE\` | \`/api/Categories/{id}\` | Elimina una categoría |

### 📕 Temas
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/Topic\` | Lista todas los temas |
| \`POST\` | \`/api/Topic\` | Crea un nuevo tema |
| \`PUT\` | \`/api/Topic/{id}\` | Actualiza un tema |
| \`GET\` | \`/api/Topic/{id}\` | Lista un tema |
| \`DELETE\` | \`/api/Topic/{id}\` | Elimina un tema |

### 🧑 Usuarios
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/Users\` | Lista todas los usuarios |
| \`POST\` | \`/api/Users\` | Crea un nuevo usuario |
| \`PUT\` | \`/api/Users/{id}\` | Actualiza un usuario |
| \`GET\` | \`/api/Users/{id}\` | Lista un usuario |
| \`DELETE\` | \`/api/Users/{id}\` | Elimina un usuario |
| \`PATCH\` | \`/api/Users/{id}/rol\` | Actualiza un rol del usuario |

---

## 📖 Documentación de la API

Cuando el servidor esté corriendo, abre:

Local = http://localhost:5041/swagger/index.html
Produccion = https://api-antivirus.duckdns.org/swagger/index.html

Ahí puedes probar todos los endpoints, ver los parámetros esperados y las respuestas.

---

## 📂 Estructura básica del proyecto

Api-Antivirus/
├── Controllers/
├── Data/
├── Models/
├── Services/
├── Program.cs
├── appsettings.json
├── README.md

---

### 📬 Nota
Si necesitas ayuda para generar un JWT válido para probar las rutas protegidas, por favor revisa la documentación de autenticación en tu implementación o pídele a un administrador del sistema.

---
