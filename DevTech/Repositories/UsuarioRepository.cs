using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevTech.Models;
using Microsoft.AspNetCore.Identity;

namespace DevTech.Repositories
{
    public interface IUsuarioRepository 
    {
      Task<IdentityResult> Create(Usuario usuario, string senha);
      Task<Usuario> Delete(Guid id);  
      Task Update(Usuario usuario);
      Task<IEnumerable<Usuario>> Read(); 
      Task<Usuario> ReadOne(Guid id); 
      

    }

  public class UsuarioReposutory : IUsuarioRepository
  {
  
    public Task<IdentityResult> Create(Usuario usuario, string senha)
    {
      
      throw new NotImplementedException();
    }

    public Task<Usuario> Delete(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Usuario>> Read()
    {
      throw new NotImplementedException();
    }

    public Task<Usuario> ReadOne(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task Update(Usuario usuario)
    {
      throw new NotImplementedException();
    }
  }
}