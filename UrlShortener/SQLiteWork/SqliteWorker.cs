using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using UrlShortener.Models;

namespace UrlShortener.SQLiteWork
{
    public class SqliteWorker
    {
        private readonly SQLiteCommand _command;
        private const string Base = "|DataDirectory|\\UrlShortenerDataBase.db";

        public SqliteWorker()
        {
            _command = new SQLiteCommand();
        }

        private ArrayList SelectFromDataBase(string selectStatement)
        {
            if (selectStatement == null)
                return null;

            var result = new ArrayList();
            var connection = GetConnection(Base);
            try
            {
                connection.Open();
                _command.Connection = connection;
                _command.CommandText = selectStatement;

                var dataReader = _command.ExecuteReader();
                if (!dataReader.HasRows)
                    return null;

                while (dataReader.Read())
                {
                    var data = new string[dataReader.FieldCount];
                    for (var i = 0; i <= dataReader.FieldCount - 1; i++)
                    {
                        data[i] = dataReader[i].ToString();
                    }

                    result.Add(data);
                }

                dataReader.Close();
                _command.Dispose();
            }
            catch (Exception)
            {
                
                throw;
            }
            return result;
        }


        public bool FindUserByCredentials(string name)
        {
            //Найти пользователя по имени
            var sqlCommand = $"select 1 from users where username = '{name}'";
            var selectResult = SelectFromDataBase(sqlCommand);

            return selectResult != null; //возвращаем: null -> false, !null -> true
        }

        public bool FindUserByCredentials(string name, string password)
        {
            //Найти пользователя по имени и паролю
            var sqlCommand = $"select 1 from users where username = '{name}' and userpassword = '{password}'";
            var selectResult = SelectFromDataBase(sqlCommand);

            return selectResult != null; //возвращаем: null -> false, !null -> true
        }

        public bool AddNewUser(User user)
        {
            //Добавить пользователя
            bool result = false;

            return result;
        }

        private SQLiteConnection GetConnection(string baseName)
        {
            var connection = new SQLiteConnection($"Data source={baseName};Version=3");
            return connection;
        }

    }
}