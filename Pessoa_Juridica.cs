using Clinica;

namespace Clinica
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj { get; set; }
        public string ie { get; set; }

        // Metodo para calcular o imposto
        public override void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100; // 20% de imposto
            this.valor_total = this.valor + this.valor_imposto;
        }
    }
}
