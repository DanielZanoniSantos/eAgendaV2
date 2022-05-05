using GestaoTarefas.Dominio;
using GestaoTarefas.Infra.Arquivo;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace GestaoTarefas.Infra.Arquivos
{
    public class SerializadorContatosJsonEmDotNet : ISerializadorContatos
    {
        private const string arquivoContatos = @"C:\Users\danie\Desktop\contatos.json";

        public List<Contato> CarregarContatosDoArquivo()
        {
            if (File.Exists(arquivoContatos) == false)
                return new List<Contato>();

            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string contatosJson = File.ReadAllText(arquivoContatos);

            return JsonConvert.DeserializeObject<List<Contato>>(contatosJson, settings);
        }
        public void GravarContatosEmArquivo(List<Contato> contatos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.Formatting = Formatting.Indented;

            string contatosJson = JsonConvert.SerializeObject(contatos, settings);

            File.WriteAllText(arquivoContatos, contatosJson);
        }
    }
}