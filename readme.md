# Sistema de Gestión de Biblioteca en C#

## 1. Información del proyecto

- **Actividad:** 220501097-04-AA1 – EV06
- **Nombre:** Aplicación de la sintaxis básica de C# - Funciones
- **Proyecto:** Sintaxis en C# - Parte 1
- **Lenguaje:** C#
- **Framework:** .NET 10
- **Tipo de aplicación:** Consola
- **Control de versiones:** Git y GitHub

## 2. Descripción

Este proyecto consiste en el desarrollo de un sistema de gestión de biblioteca mediante una aplicación de consola en C#.

Su objetivo es aplicar los conocimientos de sintaxis básica, funciones, estructuras de control, menús interactivos y validación de entradas.

El sistema permite navegar por diferentes módulos de una biblioteca, simulando las operaciones principales mediante mensajes en consola.

## 3. Objetivos

- Aplicar funciones y métodos estáticos en C#.
- Implementar menús interactivos mediante estructuras de control.
- Utilizar `switch`, `if`, `while` y `do-while`.
- Validar las opciones ingresadas por el usuario.
- Organizar el código en funciones independientes.
- Aplicar Git Flow para organizar el desarrollo y controlar las versiones del proyecto.

## 4. Funcionalidades

### 4.1. Menú principal

El sistema cuenta con las siguientes opciones:

1. Libros.
2. Usuarios.
3. Préstamos.
4. Búsquedas y reportes.
5. Guardar / Cargar datos.
6. Salir.

### 4.2. Módulo de libros

- Registrar libros.
- Listar todos los libros.
- Consultar libros disponibles.
- Consultar libros prestados.
- Ver detalles de un libro.
- Actualizar información.
- Eliminar libros.

### 4.3. Módulo de usuarios

- Registrar usuarios.
- Listar usuarios.
- Consultar detalles.
- Actualizar información.
- Activar o desactivar usuarios.
- Eliminar usuarios.

### 4.4. Módulo de préstamos

- Crear préstamos.
- Listar todos los préstamos.
- Consultar préstamos activos.
- Consultar préstamos cerrados.
- Ver detalles de un préstamo.
- Registrar devoluciones.
- Eliminar préstamos.

### 4.5. Búsquedas y reportes

- Buscar libros por título, autor, identificador o categoría.
- Buscar usuarios por nombre o identificador.
- Generar reportes por usuario.
- Generar reportes por libro.
- Consultar préstamos vencidos.
- Mostrar un resumen general.

### 4.6. Guardar y cargar datos

- Simular el guardado de información.
- Simular la carga de información.
- Simular el reinicio de datos con confirmación.

### 4.7. Salida del sistema

Antes de cerrar el programa, el usuario puede decidir si desea guardar los datos o salir sin guardar.

El sistema valida que la respuesta sea S o N.

## 5. Conceptos de C# utilizados

| Concepto            | Aplicación                                        |
| ------------------- | ------------------------------------------------- |
| Métodos estáticos   | Organización de las funcionalidades.              |
| Variables           | Almacenamiento temporal de opciones y respuestas. |
| Tipos de datos      | Manejo de datos como enteros y cadenas de texto.  |
| Condicionales `if`  | Validación de respuestas.                         |
| `switch`            | Selección de opciones de los menús.               |
| `while`             | Repetición de los menús.                          |
| `do-while`          | Validación de entradas y confirmaciones.          |
| `int.TryParse`      | Validación de opciones numéricas.                 |
| `Console.WriteLine` | Presentación de información.                      |
| `Console.ReadLine`  | Lectura de datos ingresados.                      |

## 6. Estructura del proyecto

```text
proyecto_biblioteca_csharp/
│
├── Program.cs
├── proyecto_biblioteca_csharp.csproj
├── .gitignore
└── README.md
```

## 7. Tecnologías y herramientas

- C#: lenguaje de programación utilizado.
- .NET 10: plataforma para ejecutar la aplicación.
- Visual Studio Code: editor de código.
- PowerShell: terminal para ejecutar comandos.
- Git: sistema de control de versiones.
- GitHub: alojamiento del repositorio.

## 8. Control de versiones - Git Flow

Para organizar el desarrollo se utilizaron las ramas principales `main` y `develop`, junto con las siguientes ramas de funcionalidades:

| Rama                           | Funcionalidad                       |
| ------------------------------ | ----------------------------------- |
| `feature/project-bootstrap`    | Configuración inicial del proyecto. |
| `feature/main-menu-navigation` | Menú principal y navegación.        |
| `feature/books-menu`           | Menú de libros.                     |
| `feature/users-menu`           | Menú de usuarios.                   |
| `feature/loans-menu`           | Menú de préstamos.                  |
| `feature/search-reports-menu`  | Búsquedas y reportes.               |
| `feature/persistence-menu`     | Guardar, cargar y reiniciar datos.  |
| `feature/exit-flow`            | Confirmación de salida.             |

Las funcionalidades se desarrollaron en ramas independientes y posteriormente se integraron en `develop`. Finalmente, los cambios se incorporaron a `main`.

**Versión de entrega:** `v0.1-menu`

## 9. Ejecución del proyecto

Para ejecutar el proyecto desde PowerShell:

```powershell
dotnet restore
dotnet build
dotnet run
```

## 10. Consideraciones

Esta versión corresponde a una implementación académica de los menús y las funciones del sistema.

Las operaciones de registro, actualización, eliminación, búsquedas, reportes y persistencia son simuladas mediante mensajes en consola. No se implementa una base de datos ni almacenamiento permanente de información.

## 11. Repositorio

**GitHub:**

https://github.com/estebanvalcarcel6909/proyecto_biblioteca_csharp

---

**Proyecto desarrollado como parte de la formación del SENA.**
