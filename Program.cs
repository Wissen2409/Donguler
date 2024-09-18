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
/*int a = 10;
for(;;){

    // bu döngüye sonsuz döngü denir.
    a++;
    Console.WriteLine(a);
}
*/

// Farklı bir yazım şekli


/*int a;
int b =0;
for(a=20;a<100;){
    //a++;
    Console.WriteLine(a);

    b++;
    // sonsuz adet 20 olur
    Console.WriteLine(b);
}
*/
// dönen bir döngüyü durdurma!!
// iki yöntem var
// 1- kaçış keywordleri ile(break-contiune,return)
// 2- mevcut koşuşu bozarak döngüden dışarı çıkılabilir
/*for(int i=10;i<100;i++){
    // bu göndü 10'dan 100'a kadar dönecek

    // döngü 50ye ulaştığında sonlandıralım
    Console.WriteLine(i);
    if(i==50){
        i=101;
    }

    // döngünün dönmesi, yukarıdaki koşulun sağlanmasına bağlıdır. 
    //bu konuş bozulduğunda, yani true değer üretmediğinde döngü dönmeuye devam etmez:

}*/


// For içerisinde for olur mu ?

// çarpım tablosu örneği üstünden gösterelim

/*for(int i=1;i<=10;i++){
// bir kere çalıştı
    for(int j=1;j<=10;j++){
        // 10 kere çalıştı
        // buraya yazılan bir yazı ekrana kaç defa yazar.
        //9 
        //10 11
        //100 2
        // sürekli olarak tekrarlar mı 
        // Cevap : 100 kere yazar 

        Console.WriteLine("{0}x{1}={2}",i,j,i*j);
        
    }// döngü değişkeni bellekten düşer
    Console.WriteLine("--------------------");
}
*/


// Örnek : 
// 1000 adet random sayı çekip, bu sayılardan kaç tanesi tek kaç tanesi çift sayı ekrana yazan uygulama

/*int tekSayi=0;
int ciftSayi =0;
Random rnd = new Random();

for(int i =0;i < 10000;i++)
{
    int randomSAyi = rnd.Next(0, 1000);
    if(randomSAyi%2==0){
        ciftSayi++;
    }
    else{
        tekSayi++;
    }
}
Console.WriteLine("{0} adet tek sayı",tekSayi);
Console.WriteLine("{0} adet çift sayı",ciftSayi);
*/
// for döngüsü kullanılarak, ekrana 10 karakterli random bir kelime yazdırınız
// Örnek : asjasdkdkd

Random rnd = new Random();
string randomString="";
for(int i=0;i<=1000;i++){

   char random = (char)rnd.Next('A','Z');
   //randomString=randomString+random.ToString();

   // oluşturulan değeri bir değişken üzerine alalım.!!
   randomString+=random.ToString();
   Console.Write(random);

}


