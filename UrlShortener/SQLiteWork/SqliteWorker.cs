using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using UrlShortener.Models;

namespace UrlShortener.SQLiteWork
{
    public class SqliteWorker
    {
        private SQLiteConnection _connection;
        private SQLiteCommand _command;
        private const string Base = "UrlShortenerDataBase.db";

        public SqliteWorker()
        {
            _command = new SQLiteCommand();
        }

        public bool FindUserByName(string name)
        {
            //Найти пользователя
            var result = false;
            var connection = GetConnection(Base);
            try
            {
                connection.Open();
                _command.Connection = connection;
                _command.CommandText =$"select 1 from users where UserName = {name}";
                var ans = _command.ExecuteScalar();
                connection.Close();
                if (ans != null)
                    result = true;
            }
            catch (Exception e)
            {
                //Something
            }

            return result;
        }

        public bool AddNewUser(User user)
        {
            //Добавить пользователя
            bool result;

            return result;
        }

        private SQLiteConnection GetConnection(string baseName)
        {
            var connection = new SQLiteConnection($"Data source={baseName};Version=3");
            return connection;
        }

    }
}