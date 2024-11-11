using FBK74App.models;
using static System.Reflection.Metadata.BlobBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBK74App.Repository
{
    public interface IRegisteredFootballFieldRepository
    {
        Task<RegisteredFootballField> GetRFFbyId(int id);
        Task Add(RegisteredFootballField rff);

    }
}
