using System;

namespace RelatoriosPOO
{
    public class Relatorio
    {
        public DateTime data { get; set; }
	    public virtual void MostrarRelatorio(){
		Console.WriteLine("Mostrando relatório geral");
        }
    }
}