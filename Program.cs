using ProjetoSistemaCelular.Models;

var smartPhone1 = new Nokia("NK070", "5.4", "15713-20-13411", 128 );
var smartPhone2 = new Iphone("2878782", "11", "MHDJ3BR/A", 128 );


smartPhone1.Ligar();
smartPhone1.InstalarAplicativo("Whatsapp");
smartPhone1.ReceberLigacao();
