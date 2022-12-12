Console.WriteLine("Receba o valor de troco da sua compra");

Console.WriteLine("Digite o valor total da compra:");
string valortotal = Console.ReadLine()!;
decimal um = Convert.ToDecimal(valortotal);

Console.WriteLine("Digite o valor pago:");
string valordpago = Console.ReadLine()!;
decimal dois = Convert.ToDecimal(valordpago);

decimal troco = um - dois;

if (dois >= um)
{

Console.WriteLine("Troco:");

}
else if ( dois < um)
{

Console.WriteLine("Deve pagar:");

}

Console.WriteLine($"{troco}");