﻿using System.Collections.Generic;
using System.Linq;

namespace SimpleStorage.Infrastructure
{
    public class Storage : IStorage
    {
        private readonly IDictionary<string, Value> internalStorage = new Dictionary<string, Value>();

        public IEnumerable<ValueWithId> GetAll()
        {
            lock (internalStorage)
                return internalStorage.Select(p => new ValueWithId {Id = p.Key, Value = p.Value});
        }

        public Value Get(string id)
        {
            lock (internalStorage)
                return internalStorage.ContainsKey(id) ? internalStorage[id] : null;
        }

        public bool Set(string id, Value value)
        {
            lock (internalStorage)
                internalStorage[id] = value;
            return true;
        }

        public bool Delete(string id)
        {
            lock (internalStorage)
                return internalStorage.Remove(id);
        }
    }
}