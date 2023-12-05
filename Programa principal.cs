internal class Program
    {
        static void Main(string[] args)
        {   
            string nomegestor, nome;
            int quantidad, quantidadeestoque, escolha, idadegestor, idade, novaidade, aumentar, novoestoque;

            Vendedor ven = new Vendedor();
            Gestor gest = new Gestor();

            Console.WriteLine("Escreve o nome do vendedor e a idade: ");
            nome = Convert.ToString(Console.ReadLine());
            idade = Convert.ToInt32(Console.ReadLine());
            

            ven.idade = idade;
            ven.nome = nome;

            Console.WriteLine("Escreve o nome do gestor e a idade: ");
            nomegestor = Convert.ToString(Console.ReadLine());
            idadegestor = Convert.ToInt32(Console.ReadLine());
            

            ven.idadegest = idadegestor;
            ven.nomegest = nomegestor;

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Verificar a Idade e o nome do vendedor");
                Console.WriteLine("2 - Verificar a Idade e o nome do gestor");
                Console.WriteLine("3 - Aumentar o Estoque");
                Console.WriteLine("4 - Diminuir o Estoque");
                Console.WriteLine("5 - Verificar a quantidade de Estoque na loja");
                Console.WriteLine("6 - Mudar a Idade do Vendedor");
                Console.WriteLine("0 - Sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                {
                    switch (escolha)
                    {
                        case 1:
                            ven.EscreveEcra(); 
                            break;
                        case 2:
                            ven.EscreveEcragest();  
                            break;
                        case 3:
                            gest.AumentarEstoque(); 
                            break;
                        case 4:
                            gest.DiminuirEstoque(); 
                            break;
                        case 5:
                            gest.ConsultarEstoque(); .
                            break;
                        case 6:
                            Console.WriteLine("Escreve a nova idade: ");
                            novaidade = Convert.ToInt32(Console.ReadLine());
                            ven.idade = novaidade;
                            Console.WriteLine("Nova idade: {0} ", novaidade);
                            break;
                        case 0:
                            Console.WriteLine("ADEUSS");
                            continuar = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                Console.WriteLine("Carrega enter para poderes continuar a escolher");
                Console.ReadLine();
            }
        }
    }
