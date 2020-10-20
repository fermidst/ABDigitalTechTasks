using System.Collections;

namespace Task1810
{
    public class Items : IEnumerable
    {
        private readonly Item[] _items;

        public Items(Item[] items)
        {
            _items = new Item[items.Length];
            for (var i = 0; i < items.Length; i++) _items[i] = items[i];
        }

        public Item this[int i]
        {
            get => _items[i];
            set => _items[i] = value;
        }

        public int Length => _items.Length;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private ItemEnum GetEnumerator()
        {
            return new ItemEnum(_items);
        }
    }
}