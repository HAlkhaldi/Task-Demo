﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TAG.DataAccess.DAL;

namespace TAG.WebAPI.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
       
        private MyContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new MyContext();
            table = _context.Set<T>();
        }
        public GenericRepository(MyContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Add(T obj)
        {
            table.Add(obj);
        }
        public void Edit(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}