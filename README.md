# Лабораторные работы за 5 семестр

### Репозиторий содержит только исходный код работ
***
## Современные платформы программирования
### [Лабораторная работа 1](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab1)
### Вариант 10
### [Задание 1](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab1/Task1)
>Поиск выброса в последовательности. Выброс – это элемент последовательности максимальным
>образом отличающийся от других элементов последовательности. Например, в последовательности
>1 2 3 4 5 6 100, выбросом является значение 100.

### [Задние 2](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab1/Task2)
>Напишите метод **double[] flatten(double[][] array)**, который преобразует двумерный массив
>в соответствующий ему одномерный, выстраивая элементы по порядку.

### [Задание 3](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab1/Task3)
>Напишите метод String stripWhitespaces(String str), убирающий пробелы по концам строки.
>Метод должен работать следующим образом:
    
    stripWhitespaces ( null ) = null  
    stripWhitespaces ("") = null  
    stripWhitespaces (" ") = null   
    stripWhitespaces (" abc ") = "abc"         
    stripWhitespaces (" abc ") = " abc "  
    stripWhitespaces (" abc ") = " abc "   
    stripWhitespaces (" abc ") = " abc "   
    stripWhitespaces (" ab c ") = "ab c"
***
### [Лабораторная работа 2](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab2)
### Вариант 10
### [Задание 1](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab2/Task1)
>Напишите программу, считывающую текст из файла построчно и выполняющую вывод указанных
>строк в порядке увеличения их длины.

### [Задание 2](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab2/Task2)
>На вход утилите cat подается список файлов. Утилита считывает их по одному и выводит в
>стандартный вывод, объединяя их в единый поток. Если вместо имени файла указано –, то cat
>читает данные из стандартного ввода до тех пор, пока пользователь не прервет сеанс ввода
>нажав ввод.
> 
>Формат использования: **cat [файл1] [файл2] ..**
>
>Примеры использования:
>
>**cat a.txt b.txt** : Выводит на экран содержимое текстовых файлов.
>**cat a.txt – b.txt > abc.txt** : Читает содержимое файла a.txt , читает из консоли (–), читает
>из файла b.txt, записывает результат объединения в файл abc.txt.
***
### [Лабораторная работа 3](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab3)
### Вариант 10
### [Задание 1](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab3/Task1)
> **Реализовать простой класс**
>
> Множество символов переменной мощности – Предусмотреть возможность пересечения
> двух множеств, вывода на печать элементов множества, а также метод, определяющий, 
> принадлежит ли указанное значение множеству. Класс должен содержать методы, позволяющие
> добавлять и удалять элемент в/из множества. Конструктор должен позволить создавать объекты 
> с начальной инициализацией. Реализацию множества осуществить на базе струк-
> туры ArrayList. Реализовать метод equals, выполняющий сравнение объектов данного типа.

### [Задание 2](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab3/Task2)
>Составить программу, которая формирует англо-русский словарь. Словарь должен содержать
>английское слово, русское слово и количество обращений к слову
>
>Программа должна:
>1. обеспечить начальный ввод словаря (по алфавиту) с конкретными значениями счетчиков обращений;
>2. формировать новое дерево, в котором слова отсортированы не по алфавиту, а по количеству обращений.
>3. иметь возможность добавления новых слов, удаления существующих, поиска нужного слова, выполнять просмотр обоих вариантов словаря
***
### [Лабораторная работа 4](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab4)
### Вариант 10
### [Задание 1](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab4/Task1)
> Создать класс Notepad (записная книжка) с внутренним классом или классами, с помощью
> объектов которого могут храниться несколько записей на одну дату.

### [Задание 2](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab4/Task2)
> Реализовать агрегирование. При создании класса агрегируемый класс объявляется как атрибут
> (локальная переменная, параметр метода). Включить в каждый класс 2-3 метода на выбор. 
> Продемонстрировать использование разработанных классов.
> 
> **Задание по варианту: Создать класс Планета, используя класс Материк.**

### [Задание 3](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab4/Task3)
> Система Городской транспорт. На Маршрут назначаются Автобус или Троллейбус. Транспортные 
> средства должны двигаться с определенным для каждого Маршрута интервалом.
> При поломке на Маршрут должен выходить резервный транспорт или увеличиваться интервал движения.
***
### [Лабораторная работа 5](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab5)
### Вариант 10
### [Задание 1](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab5/Task1)
> Реализовать абстрактные классы или интерфейсы, а также наследование и полиморфизм для
> следующих классов: 
> 
> **Задание по варианту:**  
> **interface Диск ← abstract class Директория ← class Файл.**
### [Задание 2](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab5/Task2)
> В следующих заданиях требуется создать суперкласс (абстрактный класс, интерфейс) и определить 
> общие методы для данного класса. Создать подклассы, в которых добавить специфические
> свойства и методы. Часть методов переопределить. Создать массив объектов суперкласса и заполнить
> объектами подклассов. Объекты подклассов идентифицировать конструктором по имени или
> идентификационному номеру. Использовать объекты подклассов для моделирования реальных ситуаций и объектов.
> 
> **Задание по варианту: Создать суперкласс Учащийся и подклассы Школьник и Студент. Создать массив объектов
> суперкласса и заполнить этот массив объектами. Показать отдельно студентов и школьников.**
***
### [Лабораторная работа 6](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab6)
### Вариант 10
### [Задание 1](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab6/Task1)
Абстрактная фабрика
>Заводы по производству автомобилей. Реализовать возможность создавать автомобили различных типов на различных заводах.
### [Задание 2](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab6/Task2)
Декоратор
>Учетная запись покупателя книжного интернет-магазина. Предусмотреть различные уровни
>учетки в зависимости от активности покупателя. Дополнительные уровни добавляют функцональные
>возможности и открывают доступ к уникальным предложениям.
### [Задание 3](https://github.com/vangaru/labworks-5-semester/tree/master/MPP/Lab6/Task3)
Состояние
>Проект «Банкомат». Предусмотреть выполнение основных операций (ввод пин-кода, снятие
>суммы, завершение работы) и наличие различных режимов работы (ожидание, аутентификация, 
>выполнение операции, блокировка – если нет денег). Атрибуты: общая сумма денег в банкомате, ID.
***
## Объектно-ориентированные технологии программирования
### [Лабораторная работа 1](https://github.com/vangaru/labworks-5-semester/tree/master/OOP/Lab1)
### Вариант 13
> Вывести заданным шрифтом вертикально на экран наименование лабораторной работы.
> Нарисовать цветную фигуру и организовать движение фигуры по заднной траектории.
> 
> **Шрифт - Светлый**
> 
> **Фигура - Окружность на треугольнике**
> 
> **Траектория движения - [Циссоида диокла](https://ru.wikipedia.org/wiki/%D0%A6%D0%B8%D1%81%D1%81%D0%BE%D0%B8%D0%B4%D0%B0_%D0%94%D0%B8%D0%BE%D0%BA%D0%BB%D0%B0)**
***
### [Лабораторная работа 2](https://github.com/vangaru/labworks-5-semester/tree/master/OOP/Lab2)
> Разработать текстовый редактор
***
## Операционные системы и системное программирование
### [Лабораторная работа 1](https://github.com/vangaru/labworks-5-semester/tree/master/OS&SP/Lab1)
### Вариант 10
> Игра «Арканоид». Реализовать игру с одним уровнем. Возможность 2 раза пропустить мяч,
> после 3-го игра заканчивается. Очки начисляются за разбитые блоки.
> 
> Made this task using [this video tutorial](https://www.youtube.com/watch?v=fVeLWGsdFn0&list=PLElhtYsGq0haMcAYcCPM-AGglUmKUkO5B)
***
## Специализированные языки обработки документов