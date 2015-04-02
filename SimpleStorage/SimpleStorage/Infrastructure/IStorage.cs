﻿using System.Collections.Generic;

namespace SimpleStorage.Infrastructure
{
    public interface IStorage
    {
        IEnumerable<ValueWithId> GetAll();
        Value Get(string id);
        bool Set(string id, Value value);
        bool Delete(string id);
    }
}