using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{
    public class BookList : IBookList
    {
        public Book this[int index]
        { 
            get { throw new NotImplementedException(); }
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

#region Generics

public class GenericList<T>
{
    public void Add(T value)
    {

    }
    public T this [int index]
    {
        get { throw new NotImplementedException(); }
    }
}

public class GenericDictionay<TKey, TValue>
{
    public void Add(TKey key, TValue value)
    {

    }
}

#endregion

public class ObjectList
{ 
    public void Add(object value)
    {

    }
    public object this[int index]
    {
        get { throw new NotImplementedException(); }
    }
}