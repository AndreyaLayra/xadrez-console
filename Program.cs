using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console
{
    public class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}