namespace DictionaryAssignment2
{
    public class Program
    {
        // 재해싱 도대체 어떻게하는거죠
        // 배열을 늘리고 재해싱해서 값을 다시 넣은뒤 새로운 배열에서 key값을 해싱하면 해당 인덱스가 다르게 나옵니다. 도대체 이유를 모르겠습니다
        // 힌트,,,,,!!!
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("테스트", 123);
            dictionary.Add("테이프", 456);
            Console.WriteLine(dictionary.Contains("테스트"));
            dictionary.Add("테란", 784);
            dictionary.Add("일번", 4561);
            dictionary.Add("이번", 1235);
            dictionary.Add("삼번", 1271617);
            Console.WriteLine(dictionary.Contains("테란")); 
            Console.WriteLine(dictionary.Find("테란"));
            Console.WriteLine(dictionary.Find("삼번"));
            dictionary.Remove("삼번");
            Console.WriteLine(dictionary.Contains("삼번"));
        }
    }
    public class Dictionary<TKey, TValue>
    {
        Key<TKey, TValue>[] keyArr;
        Key<TKey, TValue>[] temp;
        int index;
        int count;
        public Dictionary()
        {
            keyArr = new Key<TKey, TValue>[193];
        }
        public Dictionary(int size)
        {
            keyArr = new Key<TKey, TValue>[size * 4];
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
            count++;
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
            count--;
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
                    return true;
                index++;
            }
            return false;
        }

        public TValue Find(TKey key)
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
                    return default(TValue);
            }
            return keyArr[index].value;
        }

        private int FuncHash(TKey key)
        {
            int hash = key.GetHashCode();
            hash = Math.Abs(hash);
            return hash%keyArr.Length;
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
