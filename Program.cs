using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

//Teste com a classe Nokia.

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("Nokia 5100", "(21)888888", "123456", 64);
nokia.ModeloCelular();
nokia.NumeroCelular();
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da velha");

Console.WriteLine("\n");

//Teste com a classe Iphone.

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("Iphone XR ", "(31)999999", "654321", 128);
iphone.ModeloCelular();
iphone.NumeroCelular();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebock");