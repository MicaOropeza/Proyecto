using BlogCore.Models;
using BlogCoreAccesoDatos.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogCore.AccesoDatos.Data.Repository 
{
    public interface IUsuarioRepository : IRepository<ApplicationUser>
    {
        void BloqueaUsuario(string IdUsuario);
        void DesbloquearUsuario(string IdUsuario); 
    }
}
  