﻿/* Задача 34: Задайте массив заполненными случайными числами трехзначными числами. Напишите программу, которая определяет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
int  size  = ReadInt ( " Укажите размерность массива: " ) ;
int  [ ]  числа  =  новый  int [ размер ] ;

FillArrayRandomNumbers ( числа ) ;
PrintArray ( числа ) ;
интервал  результата  =  0 ;

for  ( int  i  =  0 ;  я  < числа . Длина ;  я ++ )
{
    если  ( числа [ я ]  %  2  ==  0 )
    {
        результат ++ ;
    }
}
если  ( результат  %  10  ==  1 )
{
    Консоль . WriteLine ( $" В массиве { result } четное число " ) ;
}
if  ( результат  %  10  ==  2  ||  результат  %  10  ==  3  ||  результат  %  10  ==  4 )
{
    Консоль . WriteLine ( $" В массиве { result } четных чисел " ) ;
}
еще

    Консоль . WriteLine ( $" В массиве { result } четных чисел " ) ;

// Методы
void  FillArrayRandomNumbers ( int  [ ]  array )  //Заполнение массива
{
    for  ( int  i  =  0 ;  я  < массив . Длина ;  я ++ )
    {
        массив [ я ]  =  новый случайный ( ) . Далее ( 99 ,  999 ) ;
    }
}

void  PrintArray ( int [ ]  array )  //Вывод массива на экран
{
    for  ( int  i  =  0 ;  я  < массив . Длина ;  я ++ )
    {
        Консоль . Write ( массив [ i ]  +  "  " ) ;
    }
    Консоль . ЗаписатьСтроку ( ) ;
}


int  ReadInt ( строковое  сообщение )   //Ввод функции
{
    Консоль . Написать ( сообщение ) ;
    вернуть Конвертировать . ToInt32 ( Console.ReadLine ( ) ) ; _ _
}