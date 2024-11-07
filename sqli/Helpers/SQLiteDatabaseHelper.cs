﻿using sqli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqli.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public SQLiteDatabaseHelper( String path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }

        public Task <int> Insert(Produto p) 
        {
            return _conn.InsertAsync(p);
        }

        public Task<List<Produto> Update(Produto p)
        {
            string sql = "UPDATE Produto" + "SET  Descricao=?, Quantidade=?, Preco=? WHERE Id=?";
        }
    }
}
