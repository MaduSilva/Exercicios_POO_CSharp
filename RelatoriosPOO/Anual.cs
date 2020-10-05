namespace RelatoriosPOO
{
    public class Anual : Relatorio
    {
	    public override void MostrarRelatorio(){
		base.MostrarRelatorio();
		System.Console.WriteLine("Mostrando relatório por ano");

        }
    }
}