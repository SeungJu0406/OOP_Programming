namespace DictionaryAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Dictionary<TKey, TValue> 
    {
        TKey[] key;
        TValue[] value;
        public Dictionary() 
        {
            key = new TKey[193];
            value = new TValue[193];
        }

    }    
}
