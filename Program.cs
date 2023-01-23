using DesafioPOO.Models;

Console.WriteLine("Teste de Nokia:");
Smartphone smart1 = new Nokia(numero: "99999-0000", modelo: "N110", imei: "ABXCD00122", memoria: 64);
smart1.Ligar();
smart1.ReceberLigacao();
smart1.InstalarAplicativo("Spotify");

Console.WriteLine("Teste de Iphone:");
Smartphone smart2 = new Iphone(numero: "99999-1111", modelo: "Iphone14", imei: "ABXCD00033", memoria: 256);
smart2.Ligar();
smart2.ReceberLigacao();
smart2.InstalarAplicativo("WhatsApp");