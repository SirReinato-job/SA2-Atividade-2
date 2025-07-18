namespace Clinica
{
    public static class Validador
    {
        public static string LerTipo()
        {
            string tipo = "";

            do
            {
                tipo = Console.ReadLine();

                if (tipo != "f" && tipo != "j")
                    Console.WriteLine("Opção inválida. Digite 'f' para PF ou 'j' para PJ.");
            } while (tipo != "f" && tipo != "j");

            return tipo;
        }

        public static string LerCPF()
        {
            string cpf;
            do
            {
                Console.WriteLine("Informar CPF (11 dígitos):");
                cpf = Console.ReadLine();
                if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                    Console.WriteLine("CPF inválido!");
            } while (cpf.Length != 11 || !cpf.All(char.IsDigit));
            return cpf;
        }

        public static string LerRG()
        {
            string rg;
            do
            {
                Console.WriteLine("Informar RG (somente números, mínimo 7 dígitos):");
                rg = Console.ReadLine();
                if (rg.Length < 7 || !rg.All(char.IsDigit))
                    Console.WriteLine("RG inválido!");
            } while (rg.Length < 7 || !rg.All(char.IsDigit));
            return rg;
        }

        public static string LerCNPJ()
        {
            string cnpj;
            do
            {
                Console.WriteLine("Informar CNPJ (somente números, 14 dígitos):");
                cnpj = Console.ReadLine();
                if (cnpj.Length != 14 || !cnpj.All(char.IsDigit))
                    Console.WriteLine("CNPJ inválido!");
            } while (cnpj.Length != 14 || !cnpj.All(char.IsDigit));
            return cnpj;
        }

        public static string LerIE()
        {
            string ie;
            do
            {
                Console.WriteLine("Informar IE (somente números, mínimo 9 dígitos):");
                ie = Console.ReadLine();
                if (ie.Length < 9 || !ie.All(char.IsDigit))
                    Console.WriteLine("IE inválido!");
            } while (ie.Length < 9 || !ie.All(char.IsDigit));
            return ie;
        }

        public static string FormatoCPF(string cpf)
        {
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }

        public static string FormatoRG(string rg)
        {
            if (rg.Length == 9)
                return Convert.ToUInt64(rg).ToString(@"00\.000\.000\-0");
            return rg;
        }

        public static string FormatoCNPJ(string cnpj)
        {
            return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
        }

        public static string FormatoIE(string ie)
        {
            return ie.Insert(4, ".").Insert(8, "-");
        }
    }
}
