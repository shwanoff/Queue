using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    /// <summary>
    /// Очередь.
    /// </summary>
    /// <typeparam name="T"> Тип данных, хранимых в очереди. </typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// Коллекция хранимых данных.
        /// </summary>
        private List<T> _items = new List<T>();

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Count => _items.Count;

        /// <summary>
        /// Добавить элемент в очередь.
        /// </summary>
        /// <param name="item"> Добавляемые данные. </param>
        public void Enqueue(T item)
        {
            // Проверяем входные данные на пустоту.
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            // Добавляем данные в коллекцию элементов.
            _items.Add(item);
        }

        /// <summary>
        /// Получить элемент из очереди с удалением.
        /// </summary>
        /// <returns> Элемент данных. </returns>
        public T Dequeue()
        {
            // Получить элемент из начала очереди.
            var item = GetItem();

            // Удаляем элемент из коллекции.
            _items.Remove(item);

            // Возвращаем полученный элемент.
            return item;
        }

        /// <summary>
        /// Прочитать элемент из очереди без удаления.
        /// </summary>
        /// <returns> Элемент данных. </returns>
        public T Peek()
        {
            // Получаем элемент из начала очереди.
            var item = GetItem();

            // Возвращаем полученных элемент.
            return item;
        }

        /// <summary>
        /// Получить элемент из начала очереди.
        /// </summary>
        /// <returns> Начальный элемент очереди. </returns>
        private T GetItem()
        {
            // Получаем первый элемент.
            var item = _items.FirstOrDefault();

            // Если элемент пуст, то сообщаем об ошибке.
            if (item == null)
            {
                throw new NullReferenceException("Очередь пуста. Нет элементов для получения.");
            }

            return item;
        }
    }
}
