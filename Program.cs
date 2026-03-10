class Program
{
    static void Main(string[] args)
    {


        for (int j = 0; j < 10; j++)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            List<char> list = new List<char>();
            bool var = false;
            Console.WriteLine("Ayrıştırılmasını istediğiniz metni giriniz: ");
            string text = Console.ReadLine();

            foreach (char c in text)
            {
                list.Add(c);
            }




            for (int i = 0; i <= list.Count - 4; i++)
            {

                try
                {
                    if (i == 0 && char.IsDigit(list[i]) && char.IsDigit(list[i + 1]) &&
                     char.IsDigit(list[i + 2]) && char.IsDigit(list[i + 3]))
                    {
                        // Console.WriteLine($"{list[i]}{list[i + 1]}{list[i + 2]}{list[i + 3]}");
                        //var = true;
                    }

                    if (!char.IsDigit(list[i]) || !char.IsDigit(list[i + 1]) || !char.IsDigit(list[i + 2]) || !char.IsDigit(list[i + 3]))
                    {
                        continue;
                    }

                    if (i > 0)
                    {
                        if (char.IsDigit(list[i - 1]) || char.IsLetter(list[i - 1]) || !char.IsWhiteSpace(list[i - 1]))
                        {
                            continue;
                        }
                    }

                    if (i + 4 < list.Count && (char.IsDigit(list[i + 4]) || char.IsLetter(list[i + 4]) || !char.IsWhiteSpace(list[i + 4])))
                    {
                        continue;
                    }

                    Console.WriteLine($"{list[i]}{list[i + 1]}{list[i + 2]}{list[i + 3]}");
                    var = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata meydana geldi");
                }

            }
            if (!var)
            {
                Console.WriteLine("Metin içerisinde 4 rakamdan oluşan bir sayı bulunamadı.");
            }
        }
    }

}

