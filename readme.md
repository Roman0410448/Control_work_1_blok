_Задача:_ __Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.__

_Пример:_ __["hello", "2", "world", ":-"] -> ["2", ":-"] ["1234", "1567", "-2", "информатика"] -> ["-2"] ["Россия", "Дания", "Казань"] -> []__

Решение задачи

Создаем блок ввода исходных данных, согласно заданию и вывода на экран полученного массива. Создаем функцию определения количества элемента массива длина которых меньше какой-то заданной длины _length_. Для наглядности выводим его на экран с помощью метода _PrintArray_.

Через цикл с счетчиками _result_ = __0__ и _i_ = __0__ ищем и считаем элементы длина которых меньше либо равна 3. Для данной операции создаем функцию _CheckArray_.

Задаем numbers новую переменную, в которую будем присваивать вычесленный элемент массива меньше либо равна 3 символа с помощью метода _CheckArray_

Задаем новый массив строк _newArrayStrings_, который формируется перебором элементов массива _arrayStrings_, размером, равным переменной numbers

Формируем новый массива строк с помощью метода _NewArray_ . Cравнением количества их элементов с переменной длины и добавлением в массив _newArray_ элемента, удовлетворяющего условию.

На выходе метода получается заполненный массив строк _newArrayStrings_, удовлетворяющий условию, что и является решением задачи. Для наглядности выводим его на экран с помощью метода _PrintArray_.