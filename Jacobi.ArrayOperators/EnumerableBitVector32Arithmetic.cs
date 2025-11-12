using System.Collections.Specialized;

namespace Jacobi.ArrayOperators;

public static class EnumerableBitVector32Arithmetic
{
    extension(BitVector32)
    {
        public static BitVector32 operator &(BitVector32 source, BitVector32 other)
            => new(source.Data & other.Data);
        public static BitVector32 operator |(BitVector32 source, BitVector32 other)
            => new(source.Data | other.Data);
        public static BitVector32 operator ^(BitVector32 source, BitVector32 other)
            => new(source.Data ^ other.Data);

        public static BitVector32 operator !(BitVector32 source)
            => new(~source.Data);

        public static bool operator true(BitVector32 source)
            => source.Data == int.MaxValue;
        public static bool operator false(BitVector32 source)
            => source.Data == 0;
    }
}
