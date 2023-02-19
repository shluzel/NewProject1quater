# Итоговая проверочная работа.
**ЗАДАЧА.** *Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении рекомендуется обойтись массивами.*
## Разбор решения: 
* В решении данной задачи использовались строковые массивы, которые вводит сам пользователь, что позволяет работать с более вариативными вариантами. 
* На первом этапе мы просим пользователя ввести массив, который считываем, разделяя элементы пробелом. ENTER, который нажимает пользователь в конце ввода данных, позволяет нам закончить заполнять нужный нам массив. 
* Далее выводим массив, который ввел пользователь, с помощью метода вывода массива, чтобы каждый элемент был в другой строке, так мы убедимся, что получили информацию правильно, и что программа разделяет элементы, не добаляя пробел к самому элементу. 
* В последнем методе мы ищем в заданном массиве элементы, которые состоят из 3 и менее символов. Сначала мы подсчитываем количество элементов, удовлетворяющих запрос, затем создаем новый массив, длинна которого равна подсчитанному количеству. Записываем нужные элементы в новый массив. 
* На последнем этапе мы выводим новый массив из элементов, состоящих из 3 и менее символов.
*Если в массиве нет таких элементов, то программа выдаст нам строку с информацией о том, что таких элементов не найдено*