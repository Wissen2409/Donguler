// See https://aka.ms/new-console-template for more information


// Döngü :  Verilen şart sağlanmadığı sürece, belirli kod bloklarını 
//şart sağlanana kadar çalıştıran yapılardır
// Döngü Çesitleri :
// For döngüsü
// Forech Döngüsü
// do while

// koşul 
// a satir
// b satir
// c satir

// For Döngüsü : 

// Syntax

// for(int i = 0;i<100;i++)
//{

//}

// Örnek : 
/*for(int i = 0; i <= 100;i++)
{
    Console.WriteLine(i);
    
}
*/

// Örnek 
// 1 den 100 e kadar 5 er 5 er ekrana yazdıralım


/*for (int i=0;i<1000;i+=5){

Console.WriteLine(i);
}
*/

// Örnek : 
// For döngüsünü tersten çevirebilir miyiz ?
// 1000'den 0'a tersten döndürelim

/*for (int i = 1000; i > 0 ; i--)
{
    Console.WriteLine(i);
}
*/

// i değeri her zaman 0 dan başlamak zorunda değildir.

// 10 dan yüze kadar sayıları ekrana yazdıralım

/*for(int i=10;i<100;i++){

}
*/


// Hiç bir koşul ve artış verilmeden döngü tanımlanabilir
int a = 10;
for(;;){

    // bu döngüye sonsuz döngü denir.
    a++;
    Console.WriteLine(a);
}