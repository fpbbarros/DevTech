using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevTech.Models;
using Microsoft.AspNetCore.Identity;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;


namespace DevTech.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IdentityResult> Create(User usuario, string senha);
        Task<User> Delete(Guid id);
        Task Update(User usuario);
        Task<IEnumerable<User>> Read();
        Task<User> ReadOne(Guid id);


    }

    public class UsuarioReposutory : IUsuarioRepository
    {

        public IConfiguration _configuration;

        public UsuarioReposutory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IdentityResult> Create(User usuario, string senha)
        {

            using (SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("BaseIndicadores")))
            {
                try
                {
                    var teste = await connection.QueryAsync<User>
                        ("select Id, CPF, Foto from [dbo].[AspNetUsers]");
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }

            return null;
        }

        public Task<User> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> Read()
        {
            throw new NotImplementedException();
        }

        public Task<User> ReadOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User usuario)
        {
            throw new NotImplementedException();
        }
    }
}