using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class RegistrationValidator : IRegistrationValidator
    {
        public bool IsUserEntryValid(UserEntry user)
        {
            EmailValidator emailValidate = new EmailValidator();
            PasswordValidator passwordValidate = new PasswordValidator(10);
            bool validMail = false; 
            bool validPass = false;
            if (emailValidate.IsValidAddress(user.Email)) validMail = true;
            if (passwordValidate.IsValidPassword(user.Password)) validPass = true;

            return (validMail && validPass);
        }
    }
}
