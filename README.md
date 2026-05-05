# C# Memory Management: Class vs Struct (Stack & Heap)

Este repositório contém o código de exemplo utilizado para explicar a diferença técnica e prática entre `class` e `struct` no ecossistema .NET, focando em alocação de memória e performance da CPU.

---

## 🇧🇷 Português: Resumo da Aula

### O Conceito
> "Poderíamos usar `class`? Sim. Mas um Engenheiro de Software sênior sabe que, para objetos pequenos que representam valores e aparecem aos milhares, a `struct` economiza recursos e evita que o sistema precise 'parar para respirar' (Garbage Collection) o tempo todo."

### Diferença Técnica e Prática
Enquanto a **classe** cria um objeto separado na memória que o sistema precisa rastrear e buscar via ponteiro, a **struct** armazena o valor diretamente dentro do produto, eliminando "saltos" de memória e aliviando o trabalho do Garbage Collector.

*   **Analogia da Caixa de Ferramentas:**
    *   **Classe:** É como ter uma etiqueta na caixa dizendo "o martelo está no armário 7". Você tem que buscar em outro lugar.
    *   **Struct:** É como ter o martelo dentro da caixa. Abriu a caixa, o martelo já está na sua mão.

### Por que usar Struct dentro de uma Classe (Heap)?
Mesmo quando a struct vai para a Heap (por estar dentro de uma classe), ela ganha pela **eliminação da indireção**:
1.  **Classe:** Produto -> Ponteiro -> Preço (2 acessos à memória).
2.  **Struct:** Produto (Preço incluso) (1 acesso à memória).

**Resultado:** Menos ponteiros significam menos "saltos" da CPU, resultando em execução muito mais rápida em listas grandes.

---

## 🇺🇸 English: Lesson Summary

### The Concept
> "Could we use a `class`? Yes. But a senior Software Engineer knows that for small objects representing values that appear by the thousands, a `struct` saves resources and prevents the system from having to 'stop to breathe' (Garbage Collection) constantly."

### Technical and Practical Difference
While a **class** creates a separate object in memory that the system must track and fetch via a pointer, a **struct** stores the value directly inside the product, eliminating memory "jumps" and lightening the Garbage Collector's workload.

*   **Toolbox Analogy:**
    *   **Class:** It's like having a tag in the box saying "the hammer is in cabinet 7". You have to look elsewhere.
    *   **Struct:** It's like having the hammer inside the box. Open the box, and the hammer is already in your hand.

### Why use a Struct inside a Class (Heap)?
Even when the struct ends up on the Heap (because it's inside a class), it wins by **eliminating indirection**:
1.  **Class:** Product -> Pointer -> Price (2 memory accesses).
2.  **Struct:** Product (Price included) (1 memory access).

**Result:** Fewer pointers mean fewer CPU "hops," resulting in much faster execution for large lists.

---

## 🇪🇸 Español: Resumen de la Clase

### El Concepto
> "¿Podríamos usar `class`? Sí. Pero un Ingeniero de Software sénior sabe que, para objetos pequeños que representam valores y aparecen por miles, la `struct` ahorra recursos y evita que el sistema tenga que 'parar para respirar' (Garbage Collection) todo el tiempo."

### Diferencia Técnica y Práctica
Mientras que la **clase** crea un objeto separado en la memoria que el sistema debe rastrear y buscar mediante un puntero, la **struct** almacena el valor directamente dentro del producto, eliminando "saltos" de memoria y aliviando el trabajo del Garbage Collector.

*   **Analogía de la Caja de Herramientas:**
    *   **Clase:** Es como tener una etiqueta en la caja que dice "el martillo está en el armario 7". Tienes que buscarlo en otro lugar.
    *   **Struct:** Es como tener el martillo dentro de la caja. Al abrir la caja, el martillo ya está en tu mano.

### ¿Por qué usar una Struct dentro de una Clase (Heap)?
Incluso cuando la struct va al Heap (por estar dentro de una clase), gana por la **eliminación de la indirección**:
1.  **Clase:** Producto -> Puntero -> Precio (2 accesos a memoria).
2.  **Struct:** Producto (Precio incluido) (1 acceso a memoria).

**Resultado:** Menos punteros significan menos "saltos" de la CPU, lo que resulta en una ejecución mucho más rápida en listas grandes.
