# Задача:

*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

**Пример "hello", "2", "world", ":-)" ---> "2", ":-)"**

# Алгоритм решения задачи:

- Создаем массив с заданными значениями "hello", "2", "world", ":-)"
- Создаём цикл For - программа выбирает первый индекс массива
- Создаём проверку на количество символов (*Если количество символов в индексе <= 3, программа выводит его в консоль и возвращается обратно к циклу For. Если количество символов > 3, программа возвращается к циклу For, не выводя индекс в консоль.*)
- После проверки всех данных, программа выводит итоговый результат в консоль

**Блок схема**

<a href="https://ibb.co/4VhFMww"><img src="https://i.ibb.co/4VhFMww/diagram.jpg" alt="diagram" border="0"></a>