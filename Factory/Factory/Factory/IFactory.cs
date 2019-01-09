using Factory.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factory
{
    public interface IFactory
    {
        AUser createUser(UserType type);
    }

    public enum UserType
    {
        ADMINISTRATOR,
        CLIENT,
        CONTRIBUTOR
    }
}
