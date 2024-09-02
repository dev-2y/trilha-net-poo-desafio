using DesafioPOO.Models;

Console.WriteLine("<<< Smartphone Nokia >>> ");
Smartphone n1 = new Nokia("99991234", "Nokia C80", "abcd1234", 16);
n1.Ligar();
n1.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("<<< Smartphone Iphone >>> ");
Smartphone i1 = new Iphone("99997654", "Iphone 12", "efgh7654", 128);
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");
