using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class CollectionArithmetic
{
    extension<T>(ICollection<T> collection) where T : IIncrementOperators<T>
    {
        public void operator ++()
        {
            var temp = collection.ToList();
            collection.Clear();
            foreach (var item in temp)
            {
                var dummy = item;
                collection.Add(++dummy);
            }
        }
    }

    extension<T>(ICollection<T> collection) where T : IDecrementOperators<T>
    {
        public void operator --()
        {
            var temp = collection.ToList();
            collection.Clear();
            foreach (var item in temp)
            {
                var dummy = item;
                collection.Add(--dummy);
            }
        }
    }

    extension<T>(ICollection<T> collection) where T : IAdditionOperators<T, T, T>
    {
        public void operator +=(T scalar)
        {
            var temp = collection.ToList();
            collection.Clear();
            foreach (var item in temp)
                collection.Add(item + scalar);
        }
    }

    extension<T>(ICollection<T> collection) where T : ISubtractionOperators<T, T, T>
    {
        public void operator -=(T scalar)
        {
            var temp = collection.ToList();
            collection.Clear();
            foreach (var item in temp)
                collection.Add(item - scalar);
        }
    }

    extension<T>(ICollection<T> collection) where T : IMultiplyOperators<T, T, T>
    {
        public void operator *=(T scalar)
        {
            var temp = collection.ToList();
            collection.Clear();
            foreach (var item in temp)
                collection.Add(item * scalar);
        }
    }

    extension<T>(ICollection<T> collection) where T : IDivisionOperators<T, T, T>
    {
        public void operator /=(T scalar)
        {
            var temp = collection.ToList();
            collection.Clear();
            foreach (var item in temp)
                collection.Add(item / scalar);
        }
    }

    extension<T>(ICollection<T> collection) where T : IModulusOperators<T, T, T>
    {
        public void operator %=(T scalar)
        {
            var temp = collection.ToList();
            collection.Clear();
            foreach (var item in temp)
                collection.Add(item % scalar);
        }
    }
}