namespace DictionaryAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("테스트", 123);
        }
    }
    public class Dictionary<TKey, TValue>
    {
        TKey?[] key;
        TValue?[] value;
        int index;

        public Dictionary()
        {
            key = new TKey?[193];
            value = new TValue?[193];
        }
        public void Add(TKey key, TValue value)
        {
            index=FuncHash(key);
            this.key[index] = key;
            this.value[index] = value;
        }


        private int FuncHash(dynamic key)
        {
            if (key is int)
                return key % this.key.Length;
            else if (key is float)
                return (int)(key % this.key.Length);
            else if (key is double)
                return (int)(key % this.key.Length);
            else if (key is char)
                return (int)key % this.key.Length;
            else if (key is string)
                return (int)key[0] % this.key.Length;
            else
                return (int)key % this.key.Length;
        }
    }
}
