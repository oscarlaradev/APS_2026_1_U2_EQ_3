# APS_2026_1_U2_EQ_3

Proyecto académico en C# (.NET 10) para la Unidad 2, orientado a practicar fundamentos de programación, POO, colecciones, herencia y simulaciones por consola.

## Arquitectura

El proyecto está organizado con separación de responsabilidades:

- **Handlers**: concentran la lógica de cada ejercicio.
- **Runners**: gestionan interacción por consola y ejecución.
- **Clase base `Ejercicio`**: estandariza el comportamiento mediante herencia.

## Contenido actual

### 1) Bloque de ejercicios base

Incluye ejercicios clásicos de lógica y matemáticas (opciones 1 a 16), entre ellos:

- Par o impar, suma, multiplicación e intercambio de variables.
- Validaciones de mayoría de edad, número mayor, número primo.
- IMC, distancia entre puntos, promedio de calificaciones.
- Factorial con visualización del proceso.
- Línea recta (`y = mx + b`) y perímetro de polígono regular.
- Ejemplo de listas enlazadas con `List<T>`.

### 2) Módulos adicionales recientes

- **ListasGenericas**: prácticas adicionales con listas y generación aleatoria.
- **Herencia**: jerarquía `Jugador -> JugadorSupport -> SupporType1`.
- **JuegosAzar**: simulación de juego de dados (`Dado`, `JuegoDado`).
- **RPG_Mini**: base de juego RPG con personajes, enemigos y flujo principal (`MainJuego`).

### 3) Menú principal

El `Program.cs` mantiene el enfoque tradicional con `switch`, incorporando tanto ejercicios base como módulos extra de práctica.

## Ejecución

Desde la carpeta del proyecto `Clase_ICDIA_Unidad2`:

```bash
dotnet run
```

Para compilar sin ejecutar:

```bash
dotnet build
```
