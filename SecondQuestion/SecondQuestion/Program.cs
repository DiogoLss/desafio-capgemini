using System.Text.RegularExpressions;

namespace SecondQuestion
{
    class Program
    {
        public static void Main(string[] args)
        {
            string senha = "";
            bool isPasswordSecure = false;
            while (!isPasswordSecure) 
            {
                Console.Write("Digite uma senha: ");
                senha = Console.ReadLine();
                int minCaracter = 6;
                isPasswordSecure = HasDigit(senha) && HasTiny(senha) && HasCapital(senha) && HasSpecialChars(senha) && Has6CharsOrMore(senha);

                if (!HasDigit(senha))
                {
                    Console.WriteLine("A senha precisa conter digitos.");
                }
                if (!HasTiny(senha))
                {
                    Console.WriteLine("A senha precisa conter caracteres minúsculos.");
                }
                if (!HasCapital(senha))
                {
                    Console.WriteLine("A senha precisa conter caracteres maiúsculos.");
                }
                if (!HasSpecialChars(senha))
                {
                    Console.WriteLine("A senha precisa conter caracteres especiais.");
                }
                if (!Has6CharsOrMore(senha))
                {
                    Console.WriteLine($"É necessário mais {minCaracter - senha.Length} caractere(s)");
                }
                if (isPasswordSecure)
                {
                    Console.WriteLine("A senha é segura.");
                }
            }
        }
        private static bool HasDigit(string senha) { return senha.Any(char.IsDigit); }
        private static bool HasTiny(string senha) { return senha.Any(char.IsLower); }
        private static bool HasCapital(string senha) { return senha.Any(char.IsUpper); }
        private static bool HasSpecialChars(string senha)
        {
            Regex rgx = new Regex("[^A-Za-z0-9]");
            return rgx.IsMatch(senha);
        }
        private static bool Has6CharsOrMore(string senha) { return senha.Trim().Length >= 6; }
    }
}