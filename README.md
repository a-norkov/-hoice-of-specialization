# Проверочная итоговая работа. «Выбор специализации»

## Этот репозиторий создан для публикации итоговой проверочной работу по курсу «Выбор специализации».

## Задача:

Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа.\
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.\
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Пример:

``["hello", "2", "word", ":-)"] --> ["2", ":-)"]``\
``["1234", "1567", "-2", "computer science"] --> ["2"]``\
``["Russia", "Denmark", "Kaza", ":-)"] --> []``

## Описание решения:
1. Просим пользователя ввести массив строк, разделителем является запятая.
2. Методом *Parse()* считываем строку, а методом *Split()* разделяем на элементы массива.
3. Проходим циклом по массиву строк, в условии проверяем длину строки элемента массива, и если длина строки меньше или равна 3, то добавляем ее в новый массив.
4. Проходим циклом по новому массиву и выводим его элементы в консоль.

Решение на языке С# доступно в файле **"Program.cs"** по [**ссылке**](https://github.com/a-norkov/choice-of-specialization/blob/main/Program.cs)

## Блок схема:
![](https://github.com/a-norkov/choice-of-specialization/blob/main/image1.png)