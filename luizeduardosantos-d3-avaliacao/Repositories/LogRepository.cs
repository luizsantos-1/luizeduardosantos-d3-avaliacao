using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luizeduardosantos_d3_avaliacao.Repositories
{
    internal class LogRepository
    {
        private const string path = "logDatabase/log.csv";

        public static void LogAccess(string nome, string id)
        {
            var data = DateTime.Now;
            string[] line = { $"O usuario {nome} ({id}) acessou o sistema as {data.Hour}:{data.Minute} do dia {data.Day} / {data.Month}" };
            File.AppendAllLines(path, line);
        }
    }
}
