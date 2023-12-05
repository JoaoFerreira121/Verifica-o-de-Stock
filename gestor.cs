internal class Gestor : Vendedor 
{
        private int quantidadeEstoque; 
        private int quantidade; 
        private int quantidade2; 


        public void AumentarEstoque()
        {
            Console.WriteLine("Queres aumentar o estoque em quanto? ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            quantidadeEstoque += quantidade;
            Console.WriteLine("Estoque aumentado em: {0} ", quantidade);
        }

        public void DiminuirEstoque()
        {
            Console.WriteLine("Queres diminuir o estoque em quanto? ");
            quantidade2 = Convert.ToInt32(Console.ReadLine());
     
            if (quantidade2 <= quantidadeEstoque)
            {
                quantidadeEstoque -= quantidade2;
                Console.WriteLine("Estoque diminuído em {0} ", quantidade2);
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }

        public void ConsultarEstoque()
        {
            Console.WriteLine("Quantidade atual em estoque: {0}", quantidadeEstoque);
        }

       

    }
