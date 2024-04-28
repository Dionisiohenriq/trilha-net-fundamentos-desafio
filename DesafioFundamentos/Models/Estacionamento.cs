namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<Vehicle> Vehicles = new List<Vehicle>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string vehiclePlate = Console.ReadLine();
            


            if(!string.IsNullOrEmpty(vehiclePlate) && !Vehicles.Any(p => p.Plate == vehiclePlate.ToUpper()))
                Vehicles.Add(new Vehicle { Plate = vehiclePlate.ToUpper()});
        }

        public void RemoverVeiculo()
        {

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para remover:");
            string plate = Console.ReadLine();

            // Verifica se o veículo existe

            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
            // *IMPLEMENTE AQUI*
            
            decimal totalValue = 0.0M;

            if (Vehicles.Any(vhc => vhc.Plate.ToUpper() == plate.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                if(int.TryParse(Console.ReadLine(), out var hours)){
                    totalValue = (precoInicial + precoPorHora) * hours; 

                }else{
                    Console.WriteLine("Placa inválida!");

                }

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                var vehiclePlate = Vehicles.Find(p => p.Plate.Equals(plate.ToUpper()));
                Vehicles.Remove(vehiclePlate);

                Console.WriteLine($"O veículo {plate} foi removido e o preço total foi de: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (Vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var vehicle in Vehicles)
                {
                    Console.WriteLine($"Vehicle: {vehicle.Plate}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
