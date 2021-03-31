using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Task5
{
    public class EDevletValidationManager : IPersonValidationService
    {
        public bool CheckIfIdentityNumberExist(string identityNumber)
        {
            return true;
        }

        public bool CheckIfRealPerson(Person person)
        {
            if (CheckIfIdentityNumberExist(person.IdentityNumber))
            {
                return true;
            }

            return false;
        }
    }
}
