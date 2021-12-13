using e_jogos.Models;
using System.Collections.Generic;

namespace e_jogos.Interface
{
    public interface IEquipe
    {
        //CREATE
        //READALL        
        //UPDATE     
        //DELETE

        void Create(Equipe nova_equipe);
        List<Equipe> ReadAll();
        void Update(Equipe equipe);
        void Delete(int idEquipe);
    }
}
