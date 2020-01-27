using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Services
{
    public class EnrollmentIdGenerator : IGenerateEnrollmentIds
    {

        public Guid GetNewId()
        {
            return Guid.NewGuid();
        }
    }
}
