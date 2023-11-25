namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.Write("Digite a placa do veículo para estacionar: ");
            string cadastrarVeiculo = Console.ReadLine(); 
            
            // Verifica se a placa já está na lista de veiculos
            if (veiculos.Any(veiculo => veiculo.ToUpper() == cadastrarVeiculo.ToUpper())){
                Console.WriteLine("Essa placa já foi cadastrada, não é possivel cadastrar novamente, verifique se você digitou corretamente");
            }else{
                veiculos.Add(cadastrarVeiculo);
                Console.WriteLine("Veiculo cadastrado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = "";

            Console.Write("Digite a placa do veículo para remover: ");
            placa = Console.ReadLine(); 
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,


                // Para evitar exceções utilizei o TryParse
                var valor = int.TryParse(Console.ReadLine(), out var horas);


                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                if (valor){
                    
                    decimal valorTotal = horas * precoPorHora + precoInicial; 

                    // TODO: Remover a placa digitada da lista de veículos
                    veiculos.Remove(placa);
                    // *IMPLEMENTE AQUI*

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

                }else{
                    Console.WriteLine("Erro: hora invalida! digite apenas números. Não foi possivel remover o veiculo.");
                }
                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach(string veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
