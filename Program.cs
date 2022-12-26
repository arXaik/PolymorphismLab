namespace PolymorphismLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random r = new();
            var partys = new[]
            {
                new Party("Партия любителей пить",120,72),
                new Party("Вишшенка",300,20),
                new Party("Сепаратистская Россия",2,8),
                new NextParty("Партия любителей пить",120,72,150),
                new NextParty("Вишшенка",300,20,250),
                new NextParty("Сепаратистская Россия",2,8,4),
            };

            for (int party_index = 0; party_index < partys.Length; party_index++)
            {
                Party party = partys[party_index];
                Console.WriteLine($"{party.Name} - качество: {party.Quality():F1}");
                if (party_index == 2)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}