using System.Linq.Expressions;

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

            Hospedes = hospedes; // Atribui a propriedade Hospedes, a lista hospedes que o método iŕa receber.
            try{ // Inicializa e delimita um bloco de código, onde uma exceção possa ocorrer.
                if (Hospedes.Count() <= Suite.Capacidade) // Gera uma condição, verificando se a capacidade da Suite comporta a quantidade de hospedes cadastrados.
                {
                    Hospedes.AddRange(hospedes); // Se verdadeiro, adiciona os hospedes da lista recebida do método à lista Hospedes do Objeto.
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
            // *IMPLEMENTE AQUI*

            return 0;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (true)
            {
                valor = 0;
            }

            return valor;
        }
    }
}