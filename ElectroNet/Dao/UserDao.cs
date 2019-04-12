using ElectroNet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroNet.Dao
{
    public class UserDao
    {
        private List<User> userCollection;
        private static UserDao userDao;
        public static UserDao getInstance()
        {

            if (userDao == null)
            {
                userDao = new UserDao();
                return userDao;
            }
            else
            {
                return userDao;
            }
        }
        public UserDao()
        {
            userCollection = new List<User>();
            //userCollection.Add(new User());


        }
        public void AddUser(User usr)
        {
            if (usr != null)
            {
                User tmp = null;
                for (int i = 0; i < userCollection.Count; i++)
                {

                    if (userCollection.ElementAt(i).Name == usr.Name)
                    {
                        tmp = userCollection.ElementAt(i);
                    }
                   
                }
                if (tmp == null)
                {
                    userCollection.Add(usr);
                }
            }
        }
        public User getUser(int id)
        {
            User tmp = null;
            for (int i = 0; i < userCollection.Count; i++)
            {

                if (userCollection.ElementAt(i).Id == id)
                {
                    tmp = userCollection.ElementAt(i);
                }

            }
            return tmp;
        }
        public void patchUser(User usr)
        {
            if (usr != null)
            {
                User tmp = null;
                for (int i = 0; i < userCollection.Count; i++)
                {
                    tmp = userCollection[i];
                    if (tmp.Id == usr.Id)
                    {
                        

                        userCollection[i] = usr;
                        break;
                    }
                }
            }
        }
        public List<User> getAll()
        {
            return userCollection;
        }
    }

}
