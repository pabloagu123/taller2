using Monoplaza;

Mclaren monoplaza1=new Mclaren("Escuderia 1");
Ferarri monoplaza2=new Ferarri("Escuderia 2");
Redbul monoplaza3=new Redbul("Escuderia 3");

Circuito circuito1=new Circuito("Circuito #1",3);


circuito1.agregar_monoplaza(monoplaza1);
circuito1.realizar_prueba();


circuito1.sacar_monoplaza();
circuito1.agregar_monoplaza(monoplaza2);
circuito1.realizar_prueba();


circuito1.sacar_monoplaza();
circuito1.agregar_monoplaza(monoplaza3);
circuito1.realizar_prueba();
   
