using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Task5
{
    public interface IPersonValidationService
    {
        bool CheckIfIdentityNumberExist(string identityNumber);
        bool CheckIfRealPerson(Person person);
    }
}
