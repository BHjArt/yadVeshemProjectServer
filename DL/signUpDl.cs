using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class signUpDl:IsignUpDl
    {
        

        public async Task<List<User>> getRegisters()
        {

            var webClient = new WebClient();
            var json = webClient.DownloadString("c:/registers.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            return users;
        }
    }
}
