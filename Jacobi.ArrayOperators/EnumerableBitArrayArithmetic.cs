using System.Collections;

namespace Jacobi.ArrayOperators;

public static class EnumerableBitArrayArithmetic
{
    extension(BitArray)
    {
        public static BitArray operator &(BitArray source, BitArray other)
        {
            // we do not use this because it modifies the source array
            //source.And(other);
            var len = Math.Min(source.Length, other.Length);
            var result = new BitArray(len);
            for (int i = 0; i < len; i++)
                result[i] = source[i] & other[i];
            return result;
        }
        public static BitArray operator |(BitArray source, BitArray other)
            => source.Or(other);
        public static BitArray operator ^(BitArray source, BitArray other)
            => source.Xor(other);

        public static BitArray operator !(BitArray source)
        {
            var result = new BitArray(source.Length);
            for (int i = 0; i < source.Length; i++)
                result[i] = !source[i];
            return result;
        }

        public static bool operator true(BitArray source)
            => source.HasAllSet();
        public static bool operator false(BitArray source)
            => !source.HasAnySet();
    }
}
