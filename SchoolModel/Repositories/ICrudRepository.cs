﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel.Repositories {
    public interface ICrudRepository<T, K> {
        T Create(T newElement);
        void Delete(T element);
        void Delete(K key);
        void Update(T newElement);
        T FindById(K key);
        IEnumerable<T> GetAll();
    }
}
