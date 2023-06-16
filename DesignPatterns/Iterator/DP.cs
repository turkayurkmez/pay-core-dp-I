using System.Collections;

namespace Iterator
{

    public class News
    {
        public string Title { get; set; }
    }

    public class Iterator<T> : IEnumerable<T> //IEnumerator<T>
    {
        private int position = 0;

        public T Current { get; private set; }
        List<T> collection = new List<T>();
        public void Add(T item)
        {
            collection.Add(item);
            Current = collection[collection.Count - 1];
        }
        public T Next()
        {
            position++;
            Current = collection[position];
            return Current;
        }

        public T First()
        {
            position = 0;
            Current = collection[position];
            return Current;
        }

        public T Last()
        {
            position = collection.Count - 1;
            Current = collection[position];
            return Current;
        }


        //object IEnumerator.Current => throw new NotImplementedException();

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public bool MoveNext()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Reset()
        //{
        //    throw new NotImplementedException();
        //}
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
