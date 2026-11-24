# Sistema de Biblioteca en C# – EV08

## Descripción

Este proyecto corresponde a la continuación del Sistema de Biblioteca desarrollado en C#, en el cual se implementa una capa de servicios para la gestión de libros, usuarios y préstamos, utilizando colecciones dinámicas `List<T>`.

El objetivo de esta etapa es aplicar conceptos de programación orientada a objetos, manejo de colecciones, separación de responsabilidades, búsquedas, ordenamientos, operaciones de eliminación e indicadores estadísticos.

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET 10
- **Tipo de aplicación:** Consola
- **Colecciones:** `List<T>` y Array
- **Control de versiones:** Git
- **Plataforma de repositorio:** GitHub

## Estructura del proyecto

```text
proyecto_biblioteca_csharp/
│
├── Models/
│   ├── Libro.cs
│   ├── Usuario.cs
│   ├── Prestamo.cs
│   └── EstadoPrestamo.cs
│
├── Services/
│   ├── LibroService.cs
│   ├── UsuarioService.cs
│   └── PrestamoService.cs
│
├── Examples/
│   ├── ArrayVsListDemo.cs
│   └── ServiciosDemo.cs
│
├── Program.cs
├── proyecto_biblioteca_csharp.csproj
└── README.md
```

## Funcionalidades implementadas

### 1. Servicio de libros – LibroService

- Agregar libros a una colección dinámica.
- Eliminar libros mediante su ISBN.
- Obtener todos los libros registrados.
- Buscar libros por ISBN.
- Buscar libros por título.
- Buscar libros por autor.
- Ordenar libros por título.
- Ordenar libros por año de publicación.
- Obtener indicadores estadísticos:
  - Total de libros.
  - Libros disponibles.
  - Libros prestados.

### 2. Servicio de usuarios – UsuarioService

- Agregar usuarios.
- Eliminar usuarios mediante su identificador.
- Obtener todos los usuarios registrados.
- Buscar usuarios por identificador.
- Buscar usuarios por nombre.
- Buscar usuarios por apellido.
- Buscar usuarios por correo electrónico.
- Ordenar usuarios por nombre.
- Obtener indicadores estadísticos:
  - Total de usuarios.
  - Usuarios activos.
  - Usuarios inactivos.

### 3. Servicio de préstamos – PrestamoService

- Registrar préstamos.
- Eliminar préstamos mediante su identificador.
- Obtener todos los préstamos registrados.
- Buscar préstamos por identificador.
- Buscar préstamos por estado.
- Consultar préstamos vencidos.
- Ordenar préstamos por fecha de vencimiento.
- Obtener indicadores estadísticos:
  - Total de préstamos.
  - Préstamos activos.
  - Préstamos vencidos.
  - Préstamos devueltos.
  - Promedio de días de préstamo.

### 4. Comparación entre Array y List

Se implementó una demostración que permite comparar las características de los arrays y las listas dinámicas.

- **Array:** estructura de tamaño fijo.
- **List<T>:** colección dinámica que permite agregar y eliminar elementos.

### 5. Demostración y pruebas de servicios

Se incorporó una opción en el menú principal para ejecutar las pruebas de los servicios.

Esta demostración permite visualizar:

- Registro de libros, usuarios y préstamos.
- Consultas y búsquedas.
- Ordenamientos.
- Indicadores estadísticos.
- Pruebas de eliminación.
- Comparación entre Array y List.

## Ejecución del proyecto

### Requisitos

- Tener instalado el SDK de .NET 10.
- Disponer de un terminal o consola de comandos.

### Pasos para ejecutar

1. Clonar el repositorio:

```bash
git clone https://github.com/estebanvalcarcel6909/proyecto_biblioteca_csharp.git
```

2. Entrar a la carpeta del proyecto:

```bash
cd proyecto_biblioteca_csharp
```

3. Ejecutar el proyecto:

```bash
dotnet run
```

4. Seleccionar la opción **8. Pruebas de servicios (EV08)** en el menú principal para ejecutar la demostración.

## Control de versiones

El desarrollo del proyecto se realizó utilizando Git y Git Flow, mediante ramas de funcionalidades y la integración progresiva de cambios.

- `main`: versión final del proyecto.
- `develop`: rama de integración y desarrollo.
- `feature/*`: ramas utilizadas para desarrollar funcionalidades específicas.

Las funcionalidades fueron desarrolladas en ramas independientes, probadas e integradas posteriormente en `develop`, para finalmente realizar la integración final en `main`.

## Autor

Proyecto académico desarrollado como parte de la formación del programa Análisis y Desarrollo de Software (ADSO) del SENA.

## Proyecto académico

**EV08 – Sistema de Biblioteca en C#**

Aplicación de conceptos de programación orientada a objetos, colecciones dinámicas, servicios, búsquedas, ordenamientos, eliminación e indicadores estadísticos.
