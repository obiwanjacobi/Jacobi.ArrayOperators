using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class EnumerableBitwiseArithmetic
{
    extension<T>(IEnumerable<T>) where T : IShiftOperators<T, int, T>
    {
        public static IEnumerable<T> operator <<(IEnumerable<T> source, int shiftAmount)
        {
            List<T> result = [];
            foreach (var item in source)
                result.Add(item << shiftAmount);
            return result;
        }

        public static IEnumerable<T> operator >>(IEnumerable<T> source, int shiftAmount)
        {
            List<T> result = [];
            foreach (var item in source)
                result.Add(item >> shiftAmount);
            return result;
        }

        public static IEnumerable<T> operator >>>(IEnumerable<T> source, int shiftAmount)
        {
            List<T> result = [];
            foreach (var item in source)
                result.Add(item >>> shiftAmount);
            return result;
        }
    }

    extension<T>(IEnumerable<T>) where T : IBitwiseOperators<T, T, T>
    {
        public static IEnumerable<T> operator &(IEnumerable<T> left, IEnumerable<T> right)
        {
            List<T> result = [];
            using var enum1 = left.GetEnumerator();
            using var enum2 = right.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current & enum2.Current);
            }
        }
        public static IEnumerable<T> operator |(IEnumerable<T> left, IEnumerable<T> right)
        {
            List<T> result = [];
            using var enum1 = left.GetEnumerator();
            using var enum2 = right.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current | enum2.Current);
            }
        }
        public static IEnumerable<T> operator ^(IEnumerable<T> left, IEnumerable<T> right)
        {
            List<T> result = [];
            using var enum1 = left.GetEnumerator();
            using var enum2 = right.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current ^ enum2.Current);
            }
        }
        public static IEnumerable<T> operator ~(IEnumerable<T> source)
        {
            foreach (var item in source)
                yield return ~item;
        }
    }
}
