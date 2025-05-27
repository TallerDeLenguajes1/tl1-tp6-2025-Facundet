### ¿String es un tipo por valor o un tipo por referencia?

En C#, `string` es un **tipo por referencia**. Esto significa que las variables `string` almacenan una referencia en memoria a los datos reales. Sin embargo, los strings son **inmutables**, es decir, no se pueden modificar una vez creados; cualquier cambio genera una nueva instancia de string.

---

### ¿Qué secuencias de escape tiene el tipo string?

El tipo `string` en C# permite usar secuencias de escape para representar caracteres especiales. Algunas de las más comunes son:

- `\n` → Salto de línea  
- `\t` → Tabulación  
- `\\` → Barra invertida  
- `\"` → Comillas dobles  
- `\'` → Comillas simples  
- `\r` → Retorno de carro  
- `\0` → Carácter nulo

Estas secuencias comienzan con una barra invertida `\` y tienen un comportamiento especial dentro de las cadenas.

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

En C#, los caracteres `@` y `$` modifican la forma en que se interpretan las cadenas de texto:

- `@` convierte una cadena en **verbatim**, es decir, literal. Esto significa que no se interpretan secuencias de escape como `\n` o `\t`, y se permite incluir saltos de línea directamente. Además, es útil para escribir rutas de archivos sin tener que duplicar las barras invertidas (`\\`).

  Ejemplo:

  ```csharp
  string ruta = @"C:\Usuarios\Facu\Documentos\archivo.txt";
