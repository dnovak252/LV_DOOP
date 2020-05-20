using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class PasswordValidator
    {
        StringChecker firstLink;
        StringChecker lastLink;
        public PasswordValidator(StringChecker first)
        {
            this.firstLink = first;
            this.lastLink = first;
        }
        public void AddLink(StringChecker link)
        {
            lastLink.SetNext(link);
            lastLink = link;
        }
        public bool CheckPassword(string Password)
        {
            return firstLink.Check(Password);
        }
    }
}
