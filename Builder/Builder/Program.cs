using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PaletaPingPong.Builder palleteBuilder = new PaletaPingPong.Builder("NoName", "Wood");
            palleteBuilder.setControlRating(90).setSpeedRating(20);

            PaletaPingPong pallete = palleteBuilder.createPingPongPalette();
            Console.WriteLine(pallete.ToString());

            Console.ReadLine();
        }
    }
}
