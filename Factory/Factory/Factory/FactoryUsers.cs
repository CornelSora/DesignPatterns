using System;
using System.Collections.Generic;
using System.Text;
using Factory.Users;

namespace Factory.Factory
{
    public class FactoryUsers : IFactory
    {
        private static FactoryUsers INSTANCE = new FactoryUsers();
        private FactoryUsers() { }

        public static FactoryUsers getInstance()
        {
            return INSTANCE;
        }

        public AUser createUser(UserType type)
        {
            if (type == UserType.ADMINISTRATOR)
            {
                return new Administrator();
            }
            else if (type == UserType.CLIENT)
            {
                return new Client();
            }
            else if (type == UserType.CONTRIBUTOR)
            {
                return new Contributor();
            }
            throw new Exception("User type is incorrect");
        }
    }
}
