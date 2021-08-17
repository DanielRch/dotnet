using AdoteUmPet.Data;
using AdoteUmPet.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace AdoteUmPet
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void InicializaDB()
        {
            contexto.Database.EnsureCreated(); //garante que o banco foi criado, caso contrário, refaz

            var json = File.ReadAllText("pet.json"); //lê os arquivos de registro inicial dos pets
            var pets = JsonConvert.DeserializeObject<List<Pet>>(json); //transforma o registro em uma lista

            foreach (var pet in pets)
            {
                contexto.Set<Pet>()
                    .Add(new Pet(pet.Id, pet.Tipo, pet.Nome, pet.Raca, pet.Idade, pet.Porte, pet.Peso)); //adiciona as informações em memória, mas ainda não manda para o banco
            }
            contexto.SaveChanges();
        }
    }
}
