/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между габаритными элементами и монолитным массивом.
[3 7 22 2 78] -> 76 */
int  size  = ReadInt ( " Укажите размерность массива: " ) ;
int  min  = ReadInt ( " Введите минимальное число массива: " ) ;
int  max  = ReadInt ( " Введите максимальное число массива: " ) ;
int  [ ]  числа  =  новый  int [ размер ] ;

FillArrayRandomNumbers ( числа ) ;
PrintArray ( числа ) ;

int  maxFillarray  = числа [ 0 ] ;
int  minFillarray  = числа [ 0 ] ;

for  ( int  i  =  0 ;  я  < числа . Длина ;  я ++ )
{
    if  ( числа [ i ]  >  maxFillarray )
    {
        maxFillarray  = числа [ я ] ;
    }
    if  ( числа [ i ]  <  minFillarray )
    {
        minFillarray  = числа [ я ] ;
    }
}
Консоль . WriteLine ( $" Разница между максимальными и измеренными числами = { maxFillarray  -  minFillarray } " ) ;


// Методы
void  FillArrayRandomNumbers ( int  [ ]  array )  //Заполнение массива
{
    for  ( int  i  =  0 ;  я  < массив . Длина ;  я ++ )
    {
        массив [ я ]  =  новый случайный ( ) . Следующий ( мин , максимум ) ;
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