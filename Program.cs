using DesafioPOO.Models;

Console.WriteLine("Telefone Nokia");
Smartphone n1 = new Nokia(numero:"999999",modelo:"Tijolao",imei:"11111111111",memoria:64);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo(nomeApp:"Spotify");


Console.WriteLine("Telefone Iphone");
Smartphone i1 = new Iphone(numero:"9777777",modelo:"Iphone X",imei:"123456789",memoria:128);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo(nomeApp: "ITunes");
