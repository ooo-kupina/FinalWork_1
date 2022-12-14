# Итоговая проверочная работа.

## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### Алгоритм решения:
1. Просим пользователя ввести массив из произвольных слов, буквенных или цифровых сочетаний.
2. Делаем перебор значений из исходного массива.
3. Проверяем каждое значение из массива на соответствие условию: **длина строки меньше или равна трем**
4. Если строка удовлетворяет условию кладем значение в новый массив
5. Повторяем пункты `3` и `4` до тех пор пока не достигнем конца исходного массива
6. Возвращаем новый заполненый массив как результат

### Блок-схема алгоритма:
![Диаграмма](/FinalWork_1/algorithm/algorithm.png)
Блок-схема алгоритма находится в папке algorithm.

### Программа:
Для запуска программы запустите команду через терминал:
```
dotnet run 
```
Далее введите значения через пробел, например:
```
Введите значения через пробел: мама папа Огонь 365 22 yes
```
Пример вывода программы:
```
[мама, папа, Огонь, 365, 22, yes] -> [365, 22, yes]
```