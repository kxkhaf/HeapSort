# HeapSort Implementation in C#

[![C# Version](https://img.shields.io/badge/C%23-10.0-blue.svg)](https://dotnet.microsoft.com)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

Оптимизированная реализация алгоритма пирамидальной сортировки (HeapSort) на C# с использованием современных возможностей языка.

## Особенности

- 🚀 Высокая производительность (O(n log n) в любом случае)
- 💾 Экономия памяти (сортировка на месте, O(1) дополнительной памяти)
- 🛠 Оптимизированные методы:
  - Использование `ref` для обмена элементов
  - Expression-bodied members
  - Локальные функции
- 📊 Поддержка любых целочисленных массивов

## Использование

```csharp
// Простейший пример
var data = new[] { 12, 11, 13, 5, 6, 7 };
HeapSort.PerformSort(data);
HeapSort.DisplayElements(data);```