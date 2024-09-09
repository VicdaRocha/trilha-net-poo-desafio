using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\nNokia:");
Smartphone nokia = new Nokia("5465487913", "M1", "12345", 64);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");

Console.WriteLine("\nIphone:");
Smartphone iphone = new Iphone("5487965824", "M2", "54321", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");