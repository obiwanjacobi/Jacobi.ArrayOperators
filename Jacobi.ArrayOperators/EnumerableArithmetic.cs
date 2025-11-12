using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class EnumerableArithmetic
{
    extension<T>(IEnumerable<T>) where T : IAdditionOperators<T, T, T>
    {
        public static IEnumerable<T> operator +(IEnumerable<T> source, IEnumerable<T> other)
        {
            List<T> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current + enum2.Current);
            }
        }
    }
    extension<T>(IEnumerable<T>) where T : ISubtractionOperators<T, T, T>
    {
        public static IEnumerable<T> operator -(IEnumerable<T> source, IEnumerable<T> other)
        {
            List<T> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current - enum2.Current);
            }
        }
    }
    extension<T>(IEnumerable<T>) where T : IMultiplyOperators<T, T, T>
    {
        public static IEnumerable<T> operator *(IEnumerable<T> source, IEnumerable<T> other)
        {
            List<T> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current * enum2.Current);
            }
        }
    }
    extension<T>(IEnumerable<T>) where T : IDivisionOperators<T, T, T>
    {
        public static IEnumerable<T> operator /(IEnumerable<T> source, IEnumerable<T> other)
        {
            List<T> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current / enum2.Current);
            }
        }
    }
    extension<T>(IEnumerable<T>) where T : IModulusOperators<T, T, T>
    {
        public static IEnumerable<T> operator %(IEnumerable<T> source, IEnumerable<T> other)
        {
            List<T> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current % enum2.Current);
            }
        }
    }

    extension<T>(IEnumerable<T>) where T : IUnaryNegationOperators<T, T>
    {
        public static IEnumerable<T> operator -(IEnumerable<T> source)
        {
            foreach (var item in source)
                yield return -item;
        }
    }
    extension<T>(IEnumerable<T>) where T : IUnaryPlusOperators<T, T>
    {
        public static IEnumerable<T> operator +(IEnumerable<T> source)
        {
            foreach (var item in source)
                yield return +item;
        }
    }

}

public static class EnumerableScalarArithmetic
{
    extension<T>(T) where T : IAdditionOperators<T, T, T>
    {
        public static IEnumerable<T> operator +(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] += scalar;
            return list;
        }
    }
    extension<T>(T) where T : ISubtractionOperators<T, T, T>
    {
        public static IEnumerable<T> operator -(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] -= scalar;
            return list;
        }
    }
    extension<T>(T) where T : IMultiplyOperators<T, T, T>
    {
        public static IEnumerable<T> operator *(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] *= scalar;
            return list;
        }
    }
    extension<T>(T) where T : IDivisionOperators<T, T, T>
    {
        public static IEnumerable<T> operator /(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] /= scalar;
            return list;
        }
    }
    extension<T>(T) where T : IModulusOperators<T, T, T>
    {
        public static IEnumerable<T> operator %(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] %= scalar;
            return list;
        }
    }
}
