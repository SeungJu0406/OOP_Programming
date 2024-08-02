using System.Security.Cryptography.X509Certificates;

namespace DictionaryAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("테스트", 123);
            dictionary.Add("테이프", 456);
            Console.WriteLine(dictionary.Contains("테스트"));
            dictionary.Remove("테스트");
            dictionary.Remove("테이프");
            dictionary.Add("테란", 784);
            Console.WriteLine(dictionary.Contains("테란"));
        }
    }
    public class Dictionary<TKey, TValue>
    {
        Key<TKey, TValue>[] keyArr;
        int index;
        public Dictionary()
        {
            keyArr = new Key<TKey, TValue>[193];
        }
        public void Add(TKey key, TValue value)
        { 
            index = FuncHash(key);
            while (keyArr[index] != null)
            {
                index++;
                if (index >= keyArr.Length)
                    index = 0;
            }
            keyArr[index] = new Key<TKey, TValue>(key, value);
        }

        public void Remove(TKey key)
        {
            index = FuncHash(key);
            while (keyArr[index] != null)
            {
                if (index >= keyArr.Length)
                    index = 0;
                if (keyArr[index].key == null)
                {
                    index++;
                    continue;
                }
                if (keyArr[index].key.Equals(key))
                    break;

                index++;
                if (keyArr[index] == null)
                    return;
            }
            keyArr[index].key = default(TKey);
            keyArr[index].value = default(TValue);
        }

        public bool Contains(TKey key)
        {
            index = FuncHash(key);
            while (keyArr[index] != null)
            {
                if (index >= keyArr.Length)
                    index = 0;
                if (keyArr[index].key == null)
                {
                    index++;
                    continue;
                }
                if (keyArr[index].key.Equals(key))
                    break;

                index++;
                if (keyArr[index] == null)
                    return false;
            }
            return true;
        }

        private int FuncHash(dynamic key)
        {
            if (key is int)
                return key % this.keyArr.Length;
            else if (key is float)
                return (int)(key % this.keyArr.Length);
            else if (key is double)
                return (int)(key % this.keyArr.Length);
            else if (key is char)
                return (int)key % this.keyArr.Length;
            else if (key is string)
                return (int)key[0] % this.keyArr.Length;
            else
                return (int)key % this.keyArr.Length;
        }
    }


    public class Key<Tkey, TValue>
    {
        public Tkey key;
        public TValue value;
        public Key(Tkey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }

}
