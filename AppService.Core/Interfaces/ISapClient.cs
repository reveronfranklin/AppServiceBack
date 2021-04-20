using AppService.Core.CustomEntities;
using AppService.Core.DTOs.Sap;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Core.Interfaces
{
    public interface ISapClient
    {
        Task<string> GetData();

        Task<Metadata> GetToken(string yourusername, string yourpwd);

        Task<Metadata> Post(string action, string token, StringContent data);

        Task<Metadata> GetEstadoCuenta(string action, string token);

    }
}
