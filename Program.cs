using DesafioPOO.Models;

Iphone iphone = new Iphone(numero:"219817172",imei:"21",modelo:"Iphone 10",memoria:20);
Nokia nokia = new Nokia(numero: "21921092", imei: "21", modelo: "Nokia tijolão", memoria: 10);

nokia.InstalarAplicativo(nomeApp: "FaceBook");
nokia.ReceberLigacao();
nokia.Ligar();
iphone.InstalarAplicativo(nomeApp: "FaceBook");
iphone.ReceberLigacao();
iphone.Ligar();