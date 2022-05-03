using GestaoTarefas.Dominio;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GestaoTarefas.Infra.Arquivos
{
    public class SerializadorTarefasJsonEmDotNet : ISerializadorTarefas
    {
        private const string arquivoTarefas = @"C:\Users\danie\Desktop\tarefas2.json";

        public List<Tarefa> CarregarTarefasDoArquivo()
        {
            if(File.Exists(arquivoTarefas) == false)
                return new List<Tarefa>();

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = File.ReadAllText(arquivoTarefas);   

           return JsonConvert.DeserializeObject<List<Tarefa>>(tarefasJson, settings);
        }

        public void GravarTarefasEmArquivo(List<Tarefa> tarefas)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string tarefasJson = JsonConvert.SerializeObject(tarefas, settings);

            File.WriteAllText(arquivoTarefas, tarefasJson);
        }
    }
}
