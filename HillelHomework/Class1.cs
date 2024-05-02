using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelHomework
{
    public class User
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public byte Age { get; private set; }

        public enum Gender
        {
            Male,
            Women,
            Other
        }


    }
}
