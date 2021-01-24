using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>            // Generic Class
    {
        T[] items;
        //constructor
        public MyList()                                         // T[] Items ın altına, ctor tab tab - constructor. T tipinde dizi tanımlayıp altına ctor tab tab yaparız. MyList class ını bir yerde New lediğin anda public Mylist() e ait blok otomatik çalışıyor. Çalışan bloğa constructor deniyor. Hemen başlangıçta çalışıyor yani. New lediğin anda array oluştu ve sıfırladın. Sıfır elemanlı oldu yani. 9 ve 14. satırlar da dahil olmak üzere bu aradaki kod ile sıfır elemanlı bir dizi oluşturduk.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;                              // Aşağıda new dediğimizde yani dizinin eleman sayısını 1 arttırdığımızda eski değerler siliniyor çünkü yeni referans numarası alıyoruz. Bu yüzden geçici dizi tanımlayıp bu geçici diziye kaydediyoruz eski elemanları ki new dediğimizde eskiler silinmesin geçici olarak hafızada tutsun eskileri
            items = new T[items.Length + 1];                                                     // Burada da yukarda oluşturduğumuz diziye eleman ekleticez. Ama dizimim eleman sayısını önce bir arttırmam gerek o da length fonksiyonu ile olur. items.length dizinin eleman sayısını verir. Ama + 1 ekleriz ki ekleyeceğimiz yeni eleman için dizinin eleman sayısı da 1 artsın.
            for (int i = 0; i < tempArray.Length; i++)          // tempArray de tuttuğumuz verileri geri alıyoruz bu kısımda. tempArray ın bütün elemanlarını items e geri atayacağız
            {
                items[i] = tempArray[i];                        // Emanet elemanları geri aldık
            }

            items[items.Length - 1] = item;                      // Burada for dan sonra dizinin son elemanına yukarıdan gelen yani aslında eklenmek istenen item elemanını atıyoruz


        }





        public int CountYeni                                      // propfull tab tab yap. Set i sildik çünkü veri alacak bir şey yok sadece read yani get olacak. Kendi count prop umuzu oluşturduk.
        {
            get { return items.Length; }
        }


    }
}

