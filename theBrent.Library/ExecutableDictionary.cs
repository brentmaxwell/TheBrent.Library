namespace theBrent.Library
{
    public class ExecutableDictionary<T> : Dictionary<T, Action> where T : notnull
    {
        public void Eval(T key)
        {
            if (ContainsKey(key))
            {
                this[key].Invoke();
            }
            else
            {
                this[default].Invoke();
            }
        }
    }

    public class ExecutableDictionary<T, T1> : Dictionary<T, Action<T1>> where T : notnull
    {
        public void Eval(T key, T1 p1)
        {
            if (ContainsKey(key))
            {
                this[key].Invoke(p1);
            }
            else
            {
                this[default].Invoke(p1);
            }
        }
    }

    public class ExecutableDictionary<T, T1, T2> : Dictionary<T, Action<T1, T2>> where T : notnull
    {
        public void Eval(T key, T1 p1, T2 p2)
        {
            if (ContainsKey(key))
            {
                this[key].Invoke(p1, p2);
            }
            else
            {
                this[default].Invoke(p1, p2);
            }
        }
    }
}