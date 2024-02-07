using DesafioPOO.Models;




Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "11-9695959595", modelo: "Modelo antigo", imei: "294258275828572", memoria: 4);
nokia.Ligar();
nokia.InstalarAplicativo("AIDA64");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "11-959284828", modelo: "XR", imei: "222422525252", memoria: 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Icloud");