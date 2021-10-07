using System.Collections.Generic;

namespace Task1
{
    public abstract class Directory : IStorage
    {
        protected readonly List<object> _storageData = new();
        
        public void WriteData(object data)
        {
            _storageData.Add(data);
        }

        public List<object> ReadData() => _storageData;

        public abstract string GetFormat();
    }
}