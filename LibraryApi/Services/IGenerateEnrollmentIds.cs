using System;

namespace LibraryApi.Services
{
    public interface IGenerateEnrollmentIds
    {
        Guid GetNewId();
    }
}