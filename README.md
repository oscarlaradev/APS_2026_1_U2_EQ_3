# APS_2026_1_U2_EQ_3

Proyecto de ejercicios de programación en C# (.NET 10) correspondiente a la Unidad 2.

## Organización

El proyecto sigue una arquitectura de dos capas por ejercicio:

- **Handlers** (`HandlersEjerciciosBasicos/`) — contienen la lógica y reglas de negocio de cada ejercicio, usando herencia desde la clase base `Ejercicio`.
- **Runners** (`EjecutoresDeEjercicios/`) — gestionan la entrada/salida por consola e invocan al handler correspondiente.

Además cuenta con módulos de apoyo:

- **`auxiliar/`** — utilidades compartidas, como la clase genérica `Punto<T>`.
- **`ListasGenericas/`** — ejemplos de uso de `List<T>`, `ArrayList` y `LinkedList<T>`.
- **`Herencia/`** — jerarquía de clases (`Jugador → JugadorSupport → SupporType1`) para ilustrar herencia y polimorfismo.

## Ejercicios disponibles

| # | Ejercicio |
|---|-----------|
| 1 | Par o impar |
| 2 | Suma A + B |
| 3 | Invertir X y Y |
| 4 | Comprobar mayoría de edad |
| 5 | A y B: número mayor |
| 6 | Multiplicación A * B |
| 7 | Suma A + B genérica |
| 8 | Cantidad de efectivo |
| 9 | Índice de masa corporal (IMC) |
| 10 | Distancia entre dos puntos |
| 11 | Promedio de 3 calificaciones |
| 12 | Número primo |
| 13 | Factorial (con proceso paso a paso) |
| 14 | Línea recta (y = mx + b) |
| 15 | Perímetro de un polígono regular |
| 16 | Lista enlazada |

## Cómo ejecutar

Desde la carpeta `Clase_ICDIA_Unidad2`:

```bash
dotnet run
```

Ingresa el número del ejercicio cuando el menú lo solicite. Para compilar sin ejecutar:

```bash
dotnet build
```
