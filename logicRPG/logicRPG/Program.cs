Console.WriteLine("Selecione seu personagem: ");

var character = Console.ReadLine();

Console.WriteLine($"Em um mundo mágico e cheio de mistérios, o(a) jovem aventureiro(a) chamado(a) {character} " +
    $"embarca em uma jornada em busca de uma relíquia lendária conhecida como \"Cristal da Alma\". Diz a " +
    $"lenda que esse cristal possui o poder de controlar as energias vitais e proteger o reino de qualquer ameaça." +
    $"\r\n\r\nApós dias de exploração, {character} finalmente chega à entrada da Caverna das Sombras, onde se acredita " +
    $"que o cristal esteja escondido. No entanto, o(a) aventureiro(a) percebe que a caverna está protegida por um guardião misterioso.");

Random dice = new Random();

var rollin = dice.Next(1, 21);

Console.WriteLine("O que você fará? (selecione 1, 2 ou 3)");
Console.WriteLine("1 - Abordar o guardião pacificamente e pedir permissão para entrar.");
Console.WriteLine("2 - Tentar encontrar uma passagem secreta ao redor da caverna.");
Console.WriteLine("3 - Desafiar diretamente o guardião para um combate.");

var choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    Console.WriteLine("O guardião te achou suspeito. Role o dado e teste sua sorte!");

    Console.WriteLine($"O valor do dado é {rollin}");

    if (rollin == 20)
    {
        Console.WriteLine("parabéns, voce ganhou a confiança do guardião, você conseguiu entrar pacificamente!");
    }
    else
    {
        Console.WriteLine("Guardião: Quem você ousa ser ao adentrar minha caverna?");
    }
}
else if (choice == 2)
{
    Console.WriteLine("Você tentou ser furtivo e encontrar uma passagem secreta para passar pelo guardião em segurança," +
        " role o dado e veja o que acontece.");
    Console.WriteLine($"O valor do dado é {rollin}");

    if (rollin >= 12)
    {
        Console.WriteLine("Você conseguiu passar por pouco, ufa!");
    }
    else if (rollin <= 12)
    {
        Console.WriteLine("O guardião te encontrou e te destruiu, VOCÊ PERDEU");
    }
}
else if (choice == 3)
{
    Console.WriteLine("Você decidiu lutar com o guardião, mas ele é extremamente poderoso! Você só tem uma chance, qual ataque você usará?");
    Console.WriteLine(Console.ReadLine());

    Console.WriteLine("Incrível! Role os dados e veja o que acontece.");
    Console.WriteLine($"O valor do dado é {rollin}");

    if (rollin >= 15)
    {
        Console.WriteLine("O guardião foi nocauteado com seu golpe, parabéns, você venceu");
    }
    else if (rollin <= 15)
    {
        Console.WriteLine("O guardiao desviou do seu golpe e acabou perfurando seu peito com uma espada, VOCE MORREU");
    }

}