using System;

namespace AaDS.Helper
{
    public class Validator
    {
        private static Validator _instance;
        private static object syncObj = new object();

        private Validator() { }

        public static Validator GetValidator()
        {
            if (_instance == null)
            {
                lock (syncObj)
                {
                    if (_instance == null)
                    {
                        _instance = new Validator();
                    }
                }
            }
            return _instance;
        }

        public bool ValidateOrder<T>(T[] array) where T: IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}