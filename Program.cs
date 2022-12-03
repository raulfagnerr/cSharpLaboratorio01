string sb = new string('=', 40);

Console.WriteLine(sb + " Lab 01 " + sb);


Console.Write("Qual seu nome:. ");
string? nome = Console.ReadLine();
Console.Write("Qual a sua idade:. ");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade <= 17)
{
    Console.WriteLine("Valor do Ingresso: R$ 30");
}
else if (idade <= 59)
{
    Console.WriteLine("Valor do Ingresso: R$ 40");
}
else {
    Console.WriteLine("Valor do Ingresso:. R$ 20");
    }




Console.ReadKey(); 