// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.WriteLine("Test 1.1\n");

CaixaObjeto caixaint1 = new CaixaObjeto();
caixaint1.Valor = 11;
Console.WriteLine($"{caixaint1.Valor}");

CaixaObjeto caixafloat1 = new CaixaObjeto();
caixafloat1.Valor = 1.1f;
Console.WriteLine($"{caixafloat1.Valor}");

CaixaObjeto caixastring1 = new CaixaObjeto();
caixastring1.Valor = "1.1";
Console.WriteLine($"{caixastring1.Valor}");

Console.WriteLine("\nTest 1.2\n");

Caixa<int> caixaint2 = new Caixa<int>();
caixaint2.Valor = 12;
Console.WriteLine($"{caixaint2.Valor}");

Caixa<float> caixafloat2 = new Caixa<float>();
caixafloat2.Valor = 1.2f;
Console.WriteLine($"{caixafloat2.Valor}");

Caixa<string> caixastring2 = new Caixa<string>();
caixastring2.Valor = "1.2";
Console.WriteLine($"{caixastring2.Valor}");






