    static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int n = int.Parse(Console.ReadLine());
            
            string r = string.Empty;
            for (int i = 0; n > 2; i++)
            {
                r = n % 2 + r;
                n = n / 2;
            }
            Console.WriteLine("Binary Namber Is : "+ r);
            
            Console.ReadKey();
        }
   