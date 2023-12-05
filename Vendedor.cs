internal class Vendedor
    {


       
        public int idade {  get; internal set; }
        public string nome {  get; internal set; }

        public int idadegest { get; internal set; }
        
        public string nomegest { get; internal set; }
        
        public int quantidadeEstoque { get; internal set; } 
        public int quantidade { get; internal set; }

   
        public virtual void EscreveEcra()
        {
            Console.WriteLine("Nome: {0} | Idade: {1} ", nome, idade);
        }

        public virtual void EscreveEcragest()
        {
            Console.WriteLine("Nome: {0} | Idade: {1} ", nomegest, idadegest);
        }
    }
