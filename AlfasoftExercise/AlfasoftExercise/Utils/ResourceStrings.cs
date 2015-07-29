using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlfasoftExercise.Utils
{
    public static class ResourceStrings
    {
        public const String ListUserView = "/users";
        public const String AddUserView = "/users/new";
        public const String RemoveUserView = "/users/delete";

        public const String UserList = "api/users";
        public const String AddUser = "api/users/new";
        public const String RemoveUser = "api/users/delete";

        public const String UserIdTemplate = "api/users/{id}";
    }
}