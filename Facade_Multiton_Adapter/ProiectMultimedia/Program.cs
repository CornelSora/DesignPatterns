using ProiectMultimedia.Facade;
using ProiectMultimedia.Multimedia;
using ProiectMultimedia.Multiton;
using System;

namespace ProiectMultimedia
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadePlayer.playMusic("This is my music");
            FacadePlayer.openImage("This is my image");
            FacadePlayer.playVideo("This is my video");

            Console.ReadKey();
        }
    }
}
