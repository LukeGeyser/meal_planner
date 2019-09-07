using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MealPlanner.Models;
using System.Diagnostics;

namespace MealPlanner.Services
{
    public static class SecurityService
    {
        static public User EncryptNewPassword(User u)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(u.Password, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string encryptedPassword = Convert.ToBase64String(hashBytes);
            u.Password = encryptedPassword;
            u.Salt = salt;
            return u;
        }

        static public User EncryptExistingPassword(User u)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(u.Password, u.Salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(u.Salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string encryptedPassword = Convert.ToBase64String(hashBytes);
            u.Password = encryptedPassword;
            return u;
        }

        //static public bool Validate(string password, string hashedPassword, byte[] salt)
        //{
        //    User attemptedPassword = EncryptExistingPassword(password, salt);

        //    if (attemptedPassword.Password != hashedPassword)
        //        return false;
        //    else
        //        return true;
        //}
    }
}
