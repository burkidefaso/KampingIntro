using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(5,6);
            dortIslem.Topla(6,9);

            dortIslem.Cikar(8,5);
            dortIslem.Cikar(5,6);

            dortIslem.Carp(2,8);
            dortIslem.Carp(8,9);

            dortIslem.Bol(8,2);
            dortIslem.Bol(3,9);

        }
    }
}
