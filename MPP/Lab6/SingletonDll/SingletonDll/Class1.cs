using UnityEngine;

namespace SingletonDll
{
    public class Singleton  : MonoBehaviour 
    {
        private static Object _instance;

        public static Object Instance => _instance;

        public Singleton(Object instance)
        {
            _instance = instance;
        }
        
        public void Awake()
        {
            if (_instance != null)
            {
                Destroy(_instance);
            }
            else
            {
                Destroy(_instance);
            }
        }
    }
}