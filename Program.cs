namespace tombok
{
    internal class Program
    {
        static string[] torpok = new string[7];

        static void Torpokletrehozasa()
        {
            torpok[0] = "szundi";
            torpok[1] = "szende";
            torpok[2] = "Hapci";
            torpok[3] = "Morgo";
            torpok[4] = "Tudor";
            torpok[5] = "Vidor";
            torpok[6] = "Kuka";
        }
        static void Torpokkiirasa()
        {
            Console.WriteLine($"A torpok lista elemeinek a hossza {torpok.Length}");
            for (int i = 0; i < torpok.Length; i++)
            {
                Console.WriteLine(torpok[i]);
            }
        }   
        static void Main(string[] args)
        {
            Torpokletrehozasa();
            Torpokkiirasa();
        }
    }
}
