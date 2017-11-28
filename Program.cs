using System;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Func<int,int,double> rs = Atividade.subtrair;
            // System.Console.WriteLine(rs(10,5));
            // Func<int,int,string> ser = Atividade.Multiplicar;
            // System.Console.WriteLine(ser(10,5));

            // Action<int,int> res = soma;
            // res(10,5);

            // Predicate<int> res = Par;
            // System.Console.WriteLine(res(33));

        //     Data dt = delegate(string msg){
        //         return msg+"Hoje é "+DateTime.Now.ToString();
        //     };
        //     System.Console.WriteLine(dt("Bacon! "));
        // }

        // static void soma(int v1, int v2){
        //     System.Console.WriteLine(v1+v2);;
        // }

        // static bool Par(int valor)
        // {
        //     return valor%2==0;
        // }

        // delegate string Data(string mensagem);
        
        int[] valores = {40,56,23,1,9,11,22};

        // Func<int,bool> rs = delegate(int x){
        //     return x%2==0;
        // };

        // Func<int,bool> rs = x => x % 2 == 0;


        // foreach(int i in valores)
        //     if(rs(i))
        //         System.Console.WriteLine(i);

        Func<double,double,double> calculo = (x,y) => x/y;
        System.Console.WriteLine(calculo(23,5));

        }

    }
}
