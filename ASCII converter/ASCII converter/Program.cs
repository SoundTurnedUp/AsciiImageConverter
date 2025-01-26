using System.Drawing;

namespace ImageToAscii
{
    class Program
    {
        private static string asciiChars = "      `.-':_,^=;><+!rc*/z?sLTv)J7(|Fi{C}fI31tlu[neoZ5Yxjya]2ESwqkP6h9d4VpOGbUAKXHm8RD#$Bg0MNWQ%&@";
        static void Main(string[] args)
        {
            Bitmap bitmap = new("image.png");

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width - 10; x++)
                {
                    Color col = bitmap.GetPixel(x, y);
                    
                    float brightness = (col.R + col.B + col.G) / (3f * 255f);

                    char asciiChar = asciiChars[(int)((brightness) * asciiChars.Length)];

                    Console.Write(asciiChar);
                    Console.Write(asciiChar);
                }
                Console.WriteLine();
            }
        }
    }
}