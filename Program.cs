namespace Task_Bits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long b = 20;
            var bits = (Bits)b;
            Console.WriteLine(bits.Value);

            int c = 50;
            var bits1 = (Bits)c;
            Console.WriteLine(bits1.Value2);

            byte d= 70;
            var bits2 = (Bits)d;
            Console.WriteLine(bits2.Value3);
        }
    }
}
