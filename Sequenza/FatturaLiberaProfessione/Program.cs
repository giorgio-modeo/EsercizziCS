/*
 dato in input il costo,
stampare la fattura emessa da un libero professionista
sapendo che l'aliquota iva e al 22%
sapendo che si applica al costo la rivalsa del 4%
sapendo che si applica la ritenuta d'acconto
 
    es. costo                       1000,00 euro
        rivalsa(4%)                 40 euro
        inponibile                  1040,00 euro
        iva 22%                     228,80 euro
        Totale lordo:               1268,80
        ritenuta d'acconto(20%)     208,00 euro
        Totale netto                1060,80 euro
 */

Console.Write("inserire il conto: ");
float costo = float.Parse(Console.ReadLine());

float rivalsa = costo *4 /100;
float inponibile = rivalsa + costo;
float iva = inponibile *22 /100;
float totale_lordo = inponibile + iva;
float ritenuta = inponibile *20 /100;
float totale_netto = totale_lordo - ritenuta;

Console.WriteLine($"Rivalsa e(4%): {rivalsa:#.##} euro\nInponibile: {inponibile:#.##} euro\nIva(22%): {iva:#.##} euro\ntotale lordo: {totale_lordo:#.##} euro\nritenuta d'acconto(20%): {ritenuta:#.##} euro\n\nTotale netto: {totale_netto:#.##} euro");

