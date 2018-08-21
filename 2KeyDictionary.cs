public struct 2KeyDictionary<T1, T2> : IEquatable<2KeyDictionary<T1, T2>>
{
        public readonly T1 Item1;
        public readonly T2 Item2;

        public 2KeyDictionary(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override int GetHashCode()
        {
            return 2KeyDictionary.GetHashCode(this);
        }

        public override bool Equals(object obj)
        {
            return 2KeyDictionary.Equals(this, obj);
        }

        public bool Equals(2KeyDictionary<T1, T2> other)
        {
            return 2KeyDictionary.Equals(this, other);
        }
    }

    public struct 2KeyDictionary<T1, T2, T3> : IEquatable<2KeyDictionary<T1, T2, T3>>
    {
        public readonly T1 Item1;
        public readonly T2 Item2;
        public readonly T3 Item3;

        public 2KeyDictionary(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }

        public override int GetHashCode()
        {
            return 2KeyDictionary.GetHashCode(this);
        }

        public override bool Equals(object obj)
        {
            return 2KeyDictionary.Equals(this, obj);
        }

        public bool Equals(2KeyDictionary<T1, T2, T3> other)
        {
            return 2KeyDictionary.Equals(this, other);
        }
    }

    internal static class 2KeyDictionary
    {
        internal static bool Equals<T1, T2>(2KeyDictionary<T1, T2> key, object obj)
        {
            if (!(obj is 2KeyDictionary<T1, T2>))
                return false;

            return Equals(key, (2KeyDictionary<T1, T2>)obj);
        }

        internal static bool Equals<T1, T2>(2KeyDictionary<T1, T2> keyA, 2KeyDictionary<T1, T2> keyB)
        {
            return EqualityComparer<T1>.Default.Equals(keyA.Item1, keyB.Item1)
                && EqualityComparer<T2>.Default.Equals(keyA.Item2, keyB.Item2);
        }

        internal static bool Equals<T1, T2, T3>(2KeyDictionary<T1, T2, T3> key, object obj)
        {
            if (!(obj is 2KeyDictionary<T1, T2, T3>))
                return false;

            return Equals(key, (2KeyDictionary<T1, T2, T3>)obj);
        }

        internal static bool Equals<T1, T2, T3>(2KeyDictionary<T1, T2, T3> keyA, 2KeyDictionary<T1, T2, T3> keyB)
        {
            return EqualityComparer<T1>.Default.Equals(keyA.Item1, keyB.Item1)
                && EqualityComparer<T2>.Default.Equals(keyA.Item2, keyB.Item2)
                && EqualityComparer<T3>.Default.Equals(keyA.Item3, keyB.Item3);
        }

        internal static int GetHashCode<T1, T2>(2KeyDictionary<T1, T2> key)
        {
            return CombineHashCodes(
                EqualityComparer<T1>.Default.GetHashCode(key.Item1),
                EqualityComparer<T2>.Default.GetHashCode(key.Item2));
        }

        internal static int GetHashCode<T1, T2, T3>(2KeyDictionary<T1, T2, T3> key)
        {
            return CombineHashCodes(
                EqualityComparer<T1>.Default.GetHashCode(key.Item1),
                EqualityComparer<T2>.Default.GetHashCode(key.Item2),
                EqualityComparer<T3>.Default.GetHashCode(key.Item3));
        }

        internal static int CombineHashCodes(int h1, int h2)
        {
            return (((h1 << 5) + h1) ^ h2);
        }

        internal static int CombineHashCodes(int h1, int h2, int h3)
        {
            return CombineHashCodes(CombineHashCodes(h1, h2), h3);
        }
    }
