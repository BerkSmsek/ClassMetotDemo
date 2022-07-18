namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> isimler2 = new List<string> { "berk","Umut"};

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[2]);
            //foreach for döngüsü gibi her elemanı tek tek çeviriyor. i=0 dan flan yazmaya gere kalmıyor.
        }
    }
}