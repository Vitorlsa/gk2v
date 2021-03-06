using System.Collections.Generic;
using APIGK2V.Entidades;
using MongoDB.Bson;

namespace APIGK2V.Contratos
{
    public interface IRepositorioBase<T> where T: EntidadeBase
    {
         void Insert(T document);

         IList<T> Listar();

         T Encontrar(string onde);
         void InsertMany(IList<T> documents);

         void Update(string onde,  T document);

         IList<T> ListarOnde(string onde);
    }
}