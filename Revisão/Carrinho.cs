using System;
/*public  void Produto(int quantidade, double preço, string descrição) {

        };  Porque isso ta errado*/
/*Produto[] lista = new Produto[50];
            int auxiliar = 0;
            auxiliar = 0;
            foreach(Produto n in prods){
                
                if (n != null) {
                   lista[auxiliar] = n.Getdescrição();
                   auxiliar++; 
                }
            }
            return lista;*/

namespace Aulão_de_CSHARP
{
    class Program
    {
        public static void Main()
        {
            int a;
            do
            {
                a = int.Parse(Console.ReadLine());
            } while (a != 0);
        }
    }
    class Produto
    {
        private int quantidade;
        private double preço;
        private string descrição;
        public Produto (int quantidade, double preço, string descrição) {
            if (quantidade > 0) this.quantidade = quantidade;
            if (preço > 0) this.preço = preço;
            if (descrição != "")this.descrição = descrição;/*Não sei como colocar para não pegar string vazia*/
        }
        public int Getquantidade()
        {
            return quantidade;
        }
        public double Getpreço()
        {
            return preço;
        }
        public string Getdescrição()
        {
            return descrição;
        }
        public override string ToString()
        {
            return $"descrição = {descrição}, preço = {preço}, quantidade = {quantidade}";
        }
    }
    class Carrinho
    {
        public Produto[] prods = new Produto[50];
        public void inserir(Produto p)/*Inserir: insere um novo produto no carrinho (máximo 50);*/
        {
            string a; 
            int auxiliar = 0;
            if(auxiliar <= prods.Length)
            {
                a = Console.ReadLine();
                prods[auxiliar] = p;
                auxiliar++;
            }
        }
        public Produto[] Listar()/*Listar: retorna um vetor os produtos inseridos até o momento;*/
        {
            return prods;
        }
        public double somar()/*Somar: retorna o total financeiro da compra obtido a partir da quantidade comprada e do preço dos produtos
inseridos no carrinho.*/
        {
            double soma = 0;
            double x;
            for(int i = 0; i <= prods.Length; i++)
            {
                x = prods[i].Getquantidade() * prods[i].Getpreço();
                soma = soma + x;
            }
            return soma;
        }
    }
}