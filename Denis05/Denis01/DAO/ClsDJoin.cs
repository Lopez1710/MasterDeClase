using Denis01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denis01.DAO
{
    class ClsDJoin
    {

        public List<List<object>> JoinUsuarioType()
        {
            List<List<object>> Matriz = new List<List<object>>();
            using (programacionEntities db = new programacionEntities())
            {
                var lista = (from Usuario in db.UserList
                            from Type in db.typeOfUser
                            where Usuario.IdTypeOUser == Type.IdTypeOfUser


                            select new
                            {
                                Usuario.id,
                                Usuario.NombreUsuario,
                                Type.IdTypeOfUser,
                                Type.TypeOfUserName
                            }
                            ).ToList();

                for(int i=0; i < lista.Count; i++)
                {
                    Matriz.Add(new List<object> {

                    lista[i].id,lista[i].NombreUsuario,lista[i].IdTypeOfUser,lista[i].TypeOfUserName
                    
                    });
                }




                return Matriz;
            }
        }
    }
}
