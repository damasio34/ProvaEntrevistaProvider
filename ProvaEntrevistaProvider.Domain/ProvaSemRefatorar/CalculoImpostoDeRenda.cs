namespace ProvaEntrevistaProvider.Domain.ProvaSemRefatorar
{
    public class CalculoImpostoDeRenda
    {
        private readonly decimal AliquotaImpostoCnpj = 27.5M;
        private readonly decimal AliquotaImpostoCpf = 22.5M;

        public decimal Calcular(string documento, decimal salario)
        {
            if (documento == "CNPJ")
            {
                return (salario * this.AliquotaImpostoCnpj / 100);
            }
            else 
            {
                if (documento == "CNPJ")
                {
                    return (salario * this.AliquotaImpostoCpf / 100);
                }
            }
            return 0;
        }
    }
}
