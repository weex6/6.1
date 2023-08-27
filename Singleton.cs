using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    internal class Singleton
    {
        private static Singleton instance;
        public string type { get; private set; }
        public string size { get; private set; }
        private Singleton(string _type, string _size)
        {
            type = _type;
            size = _size;
        }
        public static Singleton GetInstance(string _type, string _size)
        {
            if (instance == null)
                instance = new Singleton(_type, _size);
            return instance;
        }
    }
    class Order
    {
        public Singleton singleton { get; set; }
        public void Launch(string type, string size)
        {
            singleton = Singleton.GetInstance(type, size);
        }
    }
}
