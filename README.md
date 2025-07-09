cat << 'EOF' > README.md
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
\`\`\`bash
git clone https://github.com/Backend-API-REST-Antivirus
cd Api-Antivirus/
\`\`\`

### Instalar dependencias y herramientas
\`\`\`bash
dotnet add package DotNetEnv
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

dotnet tool install --global dotnet-ef
\`\`\`

### Configurar la base de datos
Edita \`appsettings.json\` y añade la cadena de conexión con tus credenciales de PostgreSQL:
\`\`\`json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=antivirus;Username=tu_usuario;Password=tu_contraseña"
  }
}
\`\`\`

### Crear la base de datos
\`\`\`bash
dotnet ef migrations add InitialCreate
dotnet ef database update
\`\`\`

---

## 🔐 Cómo probar el backend

1️⃣ Levanta la base de datos PostgreSQL (asegúrate de que la conexión de \`appsettings.json\` sea correcta).  
2️⃣ Ejecuta el proyecto:
\`\`\`bash
dotnet build
dotnet run
\`\`\`

3️⃣ Abre tu navegador en:
\`\`\`
http://localhost:5041/swagger/index.html
\`\`\`
Ahí verás la documentación interactiva (Swagger) con todos los endpoints.

### 🔑 Credenciales
Para las rutas que requieren autenticación con el rol **Administrador**, utiliza un JWT válido.  
*(Puedes generarlo según tu implementación en el login, este README no incluye tokens reales por seguridad.)*

---

## 📋 Endpoints disponibles

### 📚 Instituciones
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/instituciones\` | Lista todas las instituciones |
| \`POST\` | \`/api/instituciones\` | Crea una nueva institución |
| \`PUT\` | \`/api/instituciones/{id}\` | Actualiza una institución |
| \`DELETE\` | \`/api/instituciones/{id}\` | Elimina una institución |

### 🎓 Oportunidades
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/oportunidades\` | Lista todas las oportunidades |
| \`POST\` | \`/api/oportunidades\` | Crea una nueva oportunidad |
| \`PUT\` | \`/api/oportunidades/{id}\` | Actualiza una oportunidad |
| \`DELETE\` | \`/api/oportunidades/{id}\` | Elimina una oportunidad |

### 🚀 Bootcamps
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/bootcamps\` | Lista todos los bootcamps |
| \`POST\` | \`/api/bootcamps\` | Crea un nuevo bootcamp |
| \`PUT\` | \`/api/bootcamps/{id}\` | Actualiza un bootcamp |
| \`DELETE\` | \`/api/bootcamps/{id}\` | Elimina un bootcamp |

### 📂 Categorías
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| \`GET\` | \`/api/categories\` | Lista todas las categorías |
| \`POST\` | \`/api/categories\` | Crea una nueva categoría |
| \`PUT\` | \`/api/categories/{id}\` | Actualiza una categoría |
| \`DELETE\` | \`/api/categories/{id}\` | Elimina una categoría |

*(Puedes ampliar aquí más entidades si las tienes implementadas.)*

---

## 📖 Documentación de la API

Cuando el servidor esté corriendo, abre:
\`\`\`
http://localhost:5041/swagger/index.html
\`\`\`
Ahí puedes probar todos los endpoints, ver los parámetros esperados y las respuestas.

---

## 📂 Estructura básica del proyecto

\`\`\`
Api-Antivirus/
├── Controllers/
├── Data/
├── Models/
├── Services/
├── Program.cs
├── appsettings.json
├── README.md
\`\`\`

---

### 📬 Nota
Si necesitas ayuda para generar un JWT válido para probar las rutas protegidas, por favor revisa la documentación de autenticación en tu implementación o pídele a un administrador del sistema.

---
EOF
