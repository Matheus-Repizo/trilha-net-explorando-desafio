namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            try // Inicializa e delimita um bloco de código, onde uma exceção possa ocorrer.
            { 
                if (hospedes.Count <= Suite.Capacidade) // Gera uma condição, verificando se a capacidade da Suite comporta a quantidade de hospedes cadastrados.
                {
                    Hospedes = hospedes; // Se verdadeiro, adiciona os hospedes da lista recebida do método à lista Hospedes do Objeto.
                }
                else
                {
                    // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido.
                    throw new ArgumentException("A suite não comporta a quantidade de hospedes cadastrada!"); // Se falso, lança uma exceção,interrompendo o fluxo do código.
                }
            }
            catch (ArgumentException ex) // Trata a exceção gerada.
            {
                Console.WriteLine(ex.Message); // Mostra no console apenas a mensagem informada na exceção.
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            if (Hospedes == null) // Valida se a Lista Hospedes está vazia.
            {
                return 0; // Se verdadeiro retorna 0;
            }

            return Hospedes.Count; // Caso contrário, retorna o total de hospedes cadastrados.

        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal totalSemDesconto = DiasReservados * Suite.ValorDiaria; // Atribui a Variavel do tipo decimal totalSemDesconto o valor da multiplicação dos DiasReservados x valorDiaria.
            decimal DescontoPorcentagem = 10.00M; // Atribui a Variavel do tipo decimal DescontoPorcentagem o valor do percentual que será aplicado o desconto.
            decimal valorComDesconto = totalSemDesconto * (1 - DescontoPorcentagem /100); // Atribui a Variavel do tipo decimal valorComDescont o Valor com o Desconto.

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            // Verifica se a Lista é vazia
            if( Hospedes == null) {
                return 0; // Retorna o valor zero.
            }
             // Verifica se os dias reservados é menor que 10 dias.
            if (DiasReservados < 10)
            {
                return totalSemDesconto; // Retorna o valor sem desconto.
            }
            else {
                return valorComDesconto ; // Caso o contrário retorna o valor aplicado o desconto.
            }

        }
    }
}