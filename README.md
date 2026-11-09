# Parcial-3---JustinOkada-HPA

**Universidad Tecnológica de Panamá**  
**Facultad de Ingeniería en Sistemas Computacionales**  
**Curso:** Herramientas de la Programación Aplicada III (.Net)  
**Instructor:** Ing. Irina Fong  
**Grupo:** 1IL133  
**Fecha:** 9/11/2026  

Este repositorio contiene la solución a la Parte Práctica del Parcial #3. Se divide en tres programas principales que evalúan conceptos de Programación Orientada a Objetos, manejo de JSON y seguridad/conexión a bases de datos con C#.

---

## 📋 Contenido

1. [Programa 1: Polimorfismo y Clases Abstractas]
2. [Programa 2: Serialización con Newtonsoft.Json]
3. [Programa 3: Sistema de Login con BCrypt y MySQL]
4. [Configuración y Ejecución]

---

## Programa 1: Polimorfismo y Clases Abstractas

Este programa de consola demuestra el uso de una jerarquía de clases geométricas. Utiliza una clase abstracta padre llamada `Figura` como molde obligatorio, que define los métodos `CalcularArea()` y `CalcularPerimetro()`. 

**Características clave:**
- Clases derivadas: `Rectangulo`, `Cuadrado` y `Triangulo`.
- Implementación de un arreglo unidimensional `Figura[]`.
- Recorrido polimórfico mediante un bucle `foreach` para calcular y mostrar el área y perímetro dinámicamente.

### 📸 Captura de Pantalla - Programa 1

<img width="1102" height="438" alt="Screenshot 2026-11-09 110406" src="https://github.com/user-attachments/assets/1bd9042b-5bd1-405c-a956-ce3b65164e6d" />

---

## Programa 2: Serialización con Newtonsoft.Json

Aplicación de consola enfocada en el intercambio y formateo de datos. Convierte un objeto anónimo de C# a una cadena en formato JSON.

**Características clave:**
- Uso de la librería `Newtonsoft.Json` (instalada vía NuGet).
- Creación de un objeto con los datos: Nombre, Edad y Carrera.
- Uso del método `JsonConvert.SerializeObject()`.

### 📸 Captura de Pantalla - Programa 2

<img width="810" height="310" alt="Screenshot 2026-11-09 105706" src="https://github.com/user-attachments/assets/12765f67-3f4d-476f-8cdd-c35dd717b7f8" />

---

## Programa 3: Sistema de Login con BCrypt y MySQL

Aplicación de Windows Forms (GUI) que simula un sistema de autenticación seguro, conectándose a una base de datos MySQL local. 

**Características clave:**
- **Seguridad:** Uso del algoritmo de encriptación y la librería `BCrypt.Net-Next` para generar el hash de las contraseñas al registrarlas y para verificarlas (`BCrypt.Verify()`) durante el login.
- **Base de Datos:** Almacenamiento de usuarios con contraseñas encriptadas.
- **Bitácora de Accesos:** Tabla adicional que registra de forma automática el nombre del usuario, la fecha y si el intento de acceso fue exitoso o fallido para su posterior análisis.
- **Feedback Visual:** Interfaz de usuario que da la bienvenida con el nombre del usuario al acceder exitosamente o muestra alertas de error.

### 📸 Captura de Pantalla - Programa 3 (Login Exitoso / Registro / Control de Errores)

<img width="814" height="522" alt="Screenshot 2026-11-09 105202" src="https://github.com/user-attachments/assets/86d9ef32-ba55-4693-a3f7-1df3e95d8735" />

<img width="814" height="525" alt="Screenshot 2026-11-09 105247" src="https://github.com/user-attachments/assets/145c8381-35a1-40e3-8937-5eb5e7a1b432" />

<img width="813" height="527" alt="Screenshot 2026-11-09 105223" src="https://github.com/user-attachments/assets/096f70c3-d3bb-42c2-ac7c-6398205041ef" />

<img width="812" height="527" alt="Screenshot 2026-11-09 105233" src="https://github.com/user-attachments/assets/ec2c5936-93d5-402f-9bef-ee470d769846" />


### 📸 Captura de Pantalla - Base de Datos (Usuarios y Bitácora)

<img width="636" height="327" alt="Screenshot 2026-11-09 110655" src="https://github.com/user-attachments/assets/a53c316f-3454-4057-80ed-1ffe2ee60e5e" />

<img width="397" height="355" alt="image" src="https://github.com/user-attachments/assets/f2dfd2eb-d41c-426e-a61a-2b774474edbc" />

---

## 🚀 Configuración y Ejecución

Para ejecutar estos programas en tu máquina local:

1. **Clonar el repositorio:**
   ```bash
   git clone (https://github.com/yoto88888/Parcial-3---JustinOkada-HP)
   ```

2. **Restaurar Paquetes NuGet:**
   Abre las soluciones en Visual Studio y asegúrate de restaurar los paquetes para que se descarguen las dependencias necesarias:
   - `Newtonsoft.Json`
   - `BCrypt.Net-Next`
   - `MySql.Data`

3. **Configurar la Base de Datos (Solo Programa 3):**
   - Ejecuta el script SQL incluido en el proyecto (o detallado en el código) en tu gestor de MySQL local para crear la base de datos `SistemaLoginDB` y sus tablas.
   - Asegúrate de actualizar la cadena de conexión en el archivo `Conexion.cs` con tus credenciales de MySQL (`Uid` y `Pwd`).

4. **Compilar e iniciar** el proyecto deseado desde Visual Studio presionando `F5`.
