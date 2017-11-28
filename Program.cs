using System;
using System.Collections.Generic;
using System.Linq;

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
        
        // int[] valores = {40,56,23,1,9,11,22};

        // Func<int,bool> rs = delegate(int x){
        //     return x%2==0;
        // };

        // Func<int,bool> rs = x => x % 2 == 0;


        // foreach(int i in valores)
        //     if(rs(i))
        //         System.Console.WriteLine(i);

        // Func<double,double,double> calculo = (x,y) => x/y;
        // System.Console.WriteLine(calculo(23,5));
        
        // ############################################################################################################################################
        // List<string> cidades = new List<string>();
        // cidades.Add("Campinas");
        // cidades.Add("Guarulhos");
        // cidades.Add("Salvador");
        // cidades.Add("Belo Horizonte");

        // var cid = cidades.Where(x => x.Length <5);
        // foreach(string c in cid)
        //     System.Console.WriteLine(c);

        //    // #####################################################################################
        //     List<Alunos> aluno = new List<Alunos>(){
        //         new Alunos{Id = 10, Nome = "Pedro", email = "pedro@terra.com.br", Idade = 35},
        //         new Alunos{Id = 11, Nome = "Helena", email = "helena@uol.com.br", Idade = 24},
        //         new Alunos{Id = 58, Nome = "Tadeu", email = "tadeu@terra.com.br", Idade = 55},
        //         new Alunos{Id = 7, Nome = "Vanessa", email = "vanessa@gmail.com.br", Idade = 15}
        //     };

            

        //     // PRIMEIRA MANEIRA
        //     var resultado = from a in aluno where a.Idade > 20 && a.Idade < 40 orderby a.Nome descending select a;
        //     //SEGUNDA MANEIRA
        //     //var resultado = aluno.Where(z => z.Idade > 20 && z.Idade < 50);
        //     foreach(Alunos al in resultado){
        //         System.Console.WriteLine(al.Id + " - " + al.Nome + " - " + al.email + " - " + al.Idade);
        //     }

        // ######################################################################################################################################################


        List<Produto> prod = new List<Produto>(){
            new Produto{IdProduto = 1,NomeProduto = "Lapis", Preco = 2 , IdFornecedor = 30},
            new Produto{IdProduto = 2,NomeProduto = "Borracha", Preco = 5 , IdFornecedor = 41},            
            new Produto{IdProduto = 3,NomeProduto = "Caneta", Preco = 6 , IdFornecedor = 30},            
            new Produto{IdProduto = 4,NomeProduto = "Caderno", Preco = 20 , IdFornecedor = 51},            
            new Produto{IdProduto = 5,NomeProduto = "Fichario", Preco = 30 , IdFornecedor = 62}            
        };

        List<Fornecedor> Forne = new List<Fornecedor>(){
            new Fornecedor{IdFornecedor = 30, RazaoSocial = "Faber Castel", Telefone = "11"},
            new Fornecedor{IdFornecedor = 41, RazaoSocial = "Bic", Telefone = "56"},
            new Fornecedor{IdFornecedor = 51, RazaoSocial = "Chameco", Telefone = "45"}
        };             
        
        // INNER JOIN COM LABDA !!!!!
        var resultado = prod.Join(
            Forne,
            p => p.IdFornecedor,
            f => f.IdFornecedor,
            (p,f) => new {
                pNome = p.NomeProduto,
                fRazao = f.RazaoSocial
                }
            );


        foreach(var al in resultado){
            System.Console.WriteLine(al.pNome + " - " + al.fRazao);
        }


        }

    }
}
