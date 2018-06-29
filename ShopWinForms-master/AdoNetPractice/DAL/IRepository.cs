using System;
using System.Collections.Generic;
using AdoNetPractice.Models;

namespace AdoNetPractice.DAL
{
    interface IRepository<T>  where T : class
    {
        List<T> List(); // получение всех объектов
       // T Get(int id); // получение одного объекта по id
        void Insert(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
    }
}