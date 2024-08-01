namespace DictionaryAssignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            char test = '할';
            int test1 = test;
            Console.WriteLine(test1);
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
