using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refugio
{
    class Data
    {
        IDictionary<string, string> loginCombinations = new Dictionary<string, string>() { { "admin", "admin" } };

        public bool IsValid(string username, string password)
        {
            if (loginCombinations.ContainsKey(username)){
                return loginCombinations[username] == password;
            }
            return false;
        }
    }
}
