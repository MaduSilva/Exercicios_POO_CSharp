using System;

namespace ConsoleWhatsapp {
    class Program {

        static void Main (string[] args) {

            Contato c1 = new Contato ("Maria", "4234-1354");
            Contato c2 = new Contato ("Eduarda", "8743-4325");
            Contato c3 = new Contato ("Lucia", "8754-7654");

            Agenda agd = new Agenda ();

            agd.Cadastrar (c1);
            agd.Cadastrar (c2);
            agd.Cadastrar (c3);

            agd.Excluir (c3);
            agd.Listar ();

            Mensagem msg = new Mensagem();
            msg.Destinatario = c1;
            msg.Texto = "Oi " + msg.Destinatario.Nome + " tudo bom?";
            Console.WriteLine(msg.Enviar());
        }
    }
}