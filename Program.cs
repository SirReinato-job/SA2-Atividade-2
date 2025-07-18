using System;
using Clinica;

namespace Clinica
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ?");
            string var_tipo = Validador.LerTipo();

            if (var_tipo == "f")
            {
                // --- Pessoa Física ----
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Validador.LerCPF();
                Console.WriteLine("Informar RG:");
                pf.rg = Validador.LerRG();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Física ---------");

                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + Validador.FormatoCPF(pf.cpf));
                Console.WriteLine("RG ............: " + Validador.FormatoRG(pf.rg));
                Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pf.valor_total.ToString("C"));
            }
            if (var_tipo == "j")
            {
                // --- Pessoa Jurídica ----
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Validador.LerCNPJ();
                Console.WriteLine("Informar IE:");
                pj.ie = Validador.LerIE();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("-------- Pessoa Jurídica ---------");

                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + Validador.FormatoCNPJ(pj.cnpj));
                Console.WriteLine("IE ............: " + Validador.FormatoIE(pj.ie));
                Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar : " + pj.valor_total.ToString("C"));
            }
        }
    }
}
