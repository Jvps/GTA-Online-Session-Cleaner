using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            int i;
            Console.Title = "Secador de Sessão - por JvpsdoGamer";
            Console.WriteLine("=================================================");
            Console.WriteLine("|      Secador de Sessão - por JvpsdoGamer      |");
            Console.WriteLine("=================================================");
            Console.WriteLine(" - Meu canal no YouTube: JvpsdoGamer");
            Console.WriteLine(" - Link: http://www.youtube.com.br/c/JvpsdoGamer");
            Console.WriteLine("=================================================");
            Console.WriteLine("");
            Processos();
            Console.WriteLine("Secando Sessão...");
            for (i = 10; i >= 1; i--) {
                if (i == 1) {
                    Console.WriteLine("Tempo restante: {0} segundo.", i);
                    Thread.Sleep(1000);
                } else {
                    Console.WriteLine("Tempo restante: {0} segundos.", i);
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("===============================================");
            Console.WriteLine("Aperte ENTER e pode voltar para o GTA Online :)");
            Console.WriteLine("===============================================");
        }

        public static void Processos() {
            Process Processo = new Process();
            Processo.StartInfo.FileName = "SuspenderGTA5.bat";
            Processo.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            Processo.Start();
        }
    }
}
