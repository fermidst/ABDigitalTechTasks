using System;
using System.Collections;

namespace Task1810
{
    public class ItemEnum : IEnumerator
    {
        private readonly Item[] _items;

        private int _position = -1;

        public ItemEnum(Item[] items)
        {
            _items = items;
        }

        private Item Current
        {
            get
            {
                try
                {
                    return _items[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Length;
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current => Current;
    }
}