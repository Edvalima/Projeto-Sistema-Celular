﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("863526", "tipo 5", "456828742", 112);
nokia.Ligar();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("256366", "11", "458269", 224);
iphone.Ligar();
iphone.InstalarAplicativo("Chorme");