namespace Clinica
{
    public class Clientes
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; protected set; }
        public float valor_imposto { get; protected set; }
        public float valor_total { get; protected set; }

        //Metodo para calcular o imposto
        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100; // 10% de imposto
            this.valor_total = this.valor + this.valor_imposto;
        }
    }
}
