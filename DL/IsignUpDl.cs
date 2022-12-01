using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface IsignUpDl
    {
        Task<List<User>> getRegisters();
        
    }
}
