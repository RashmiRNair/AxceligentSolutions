using System;
using System.Collections.Generic;

namespace CreateUserClass
{
    public class User
    {
        private static List<string> listOfUsers;
        private bool allowDuplicates = true;

        public User()
        {

        }

        static User()
        {
            listOfUsers = new List<string>();
        }

        public void Add(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrEmpty(userName))
                return;

            //If we need to add max length limit we can add it         

            if (allowDuplicates == false)
            {
                if (User.listOfUsers.Contains(userName))
                    return;
            }

            User.listOfUsers.Add(userName);
        }

        public int GetUsersCount()
        {
            return User.listOfUsers.Count;
        }
    }
}