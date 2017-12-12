using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi.NewFolder1
{
    public class ValidationManager
    {
        public bool ValidateField(string input)
        {
            if (!string.IsNullOrWhiteSpace(input))
                return true;

            return false;
        }
    }
}
