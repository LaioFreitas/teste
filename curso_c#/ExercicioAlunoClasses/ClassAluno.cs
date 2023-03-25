using System;

public class Aluno
{
	public double notaTrimestre1, notaTrimestre2, notaTrimestre3;
	public string? nome;
	public Aluno()
	{
	}
	public double Total()
	{
		return notaTrimestre1 + notaTrimestre2 + notaTrimestre3;
	}
}
