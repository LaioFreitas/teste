using System;

public class Conversor
{
	static double IOF = 1.06;//o valor do  desconto IOF e de 6%
	public static double ConverteMoeda(double cotacao, double quantidade)
	{
		double valor = cotacao * quantidade * IOF;
		return valor;
	}
	/*public Conversor()
	{

	}*/
}
