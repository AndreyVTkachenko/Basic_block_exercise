## ТЕКСТОВОЕ ОПИСАНИЕ РЕШЕНИЯ ЗАДАЧИ
1. Предлагаем пользователю ввести размерность массива постредством ввода числа в терминале;
2. Создаём пустой массив "array" размером введённого пользователем числа;
3. Заполняем массив поэлементно, предложив пользователю ввести в терминале каждый элемент по очереди;
4. Для визуализации выводим исходный массив в терминал;
5. Создаём переменную "maxLength", которая будет контролировать выполнение условия задачи и переменную "n" для определения размерности нового массива;
6. С помощью цикла "for" находим количество элементов в массиве, удовлетворяющим условию поставленной задачи, а именно, количеству символов в каждом элементе не более трёх;
7. Создаём новый массив "result" новой размерности "n";
8. Заполняем массив "result", выбирая элементы из массива "array", посредством цикла "for", удовлетворяющих условию "maxLength";
8. Выводим заполненный массив "result" в терминал.