using ProvaEntrevistaProvider.Domain.Ineterfaces;

namespace ProvaEntrevistaProvider.Domain
{
    public class CalculoImpostoDeRenda : ICalculoImpostoDeRenda
    {
        protected decimal _aliquotaImposto;

        public decimal Calcular(decimal salario) 
            => (salario * this._aliquotaImposto) / 100;
    }
}