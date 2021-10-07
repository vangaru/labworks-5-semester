using System.Collections.Generic;

namespace Task1
{
    public interface IStorage
    {
        public void WriteData(object data);

        public List<object> ReadData();
    }
}