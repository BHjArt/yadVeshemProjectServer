using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class signUpBl:IsignUpBl
    {
        IsignUpDl _IsignUpDl;
        public signUpBl(IsignUpDl userDL)
        {
            _IsignUpDl = userDL;
            
        }
        public async Task<List<User>> getRegisters()
        {

            return await _IsignUpDl.getRegisters();
        }

    }
}
