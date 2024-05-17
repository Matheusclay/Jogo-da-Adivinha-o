int numeroAleatorio = new Random().Next(1,101);
int Tentativas = 0;
int chute = 0;

Console.WriteLine(@"
██╗░░░░░███████╗██╗░█████╗░  ███╗░░░███╗██╗███╗░░██╗██╗░░██╗░█████╗░
██║░░░░░██╔════╝██║██╔══██╗  ████╗░████║██║████╗░██║██║░░██║██╔══██╗
██║░░░░░█████╗░░██║███████║  ██╔████╔██║██║██╔██╗██║███████║███████║
██║░░░░░██╔══╝░░██║██╔══██║  ██║╚██╔╝██║██║██║╚████║██╔══██║██╔══██║
███████╗███████╗██║██║░░██║  ██║░╚═╝░██║██║██║░╚███║██║░░██║██║░░██║
╚══════╝╚══════╝╚═╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝

███╗░░░███╗███████╗███╗░░██╗████████╗███████╗
████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░███████╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
Console.WriteLine("\nBem vindo ao jogo de adivinhação! ");
Console.WriteLine("-----------------------------------");

while (chute != numeroAleatorio) 
{
    Console.Write("Adivinhe o número que estou pensando de 1 até 100: ");
    chute = int.Parse(Console.ReadLine()!);
    if (chute > numeroAleatorio){
        Console.WriteLine("Errou, o número que estou pensando é menor!\n ");
        Tentativas++;    
    }
    else if (chute < numeroAleatorio){
        Console.WriteLine("Errou, o número que estou pensando é maior!\n ");
        Tentativas++;
    } 
}
Tentativas++;
Console.WriteLine("Parabéns você acertou!!! com " + Tentativas + " Tentativas");
