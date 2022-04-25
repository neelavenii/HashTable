using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
            foreach (KeyValue<K, V> iten in linkedlist)
            {
                if (iten.key.Equals(key))
                {
                    return iten.value;
                }
            }
            return default(V);
        }
        public void Add(K key,V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K,V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> iten = new KeyValue<K, V>() { key =key, value =value };
            linkedList.AddLast(iten);
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itenFound = false;
            KeyValue<K, V> foundIten = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> iten in linkedList)
            {
                if (iten.key.Equals(key))
                {
                    itenFound = true;
                    foundIten = iten;
                }
            }
            if (itenFound)
            {
                linkedList.Remove(foundIten);
            }
                
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList (int position)
        {
            LinkedList<KeyValue<K, V>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
    }
    public struct KeyValue<K, V>
    {
        public K key { get; set; }
        public V value { get; set; }
    }  
        }
        

    

