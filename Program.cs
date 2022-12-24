using DesafioPOO.Models;

Nokia nokia = new Nokia("12345", "A1", "123123123123", 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Iphone iphone = new Iphone("1114444", "13S", "2222333", 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");