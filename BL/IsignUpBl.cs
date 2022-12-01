using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IsignUpBl
    {
        Task<List<User>> getRegisters();
    }
}
