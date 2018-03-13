using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем новую очередь.
            var queue = new Queue<int>();

            // Добавляем новые элементы в очередь.
            queue.Enqueue(1);
            queue.Enqueue(7);
            queue.Enqueue(42);
            queue.Enqueue(69);
            queue.Enqueue(-17);
            Console.WriteLine($"Очередь содержит {queue.Count} элементов.");

            // Получаем элементы с удалением.
            var item1 = queue.Dequeue();
            Console.WriteLine($"Первый элемент из очереди {item1}.");
            var item2 = queue.Dequeue();
            Console.WriteLine($"Второй элемент из очереди {item2}.");

            // Добавляем новый элемент в очередь.
            queue.Enqueue(88);

            // Просматриваем элемент без удаления.
            var item3 = queue.Peek();
            Console.WriteLine($"Обзор элемента без удаления {item3}.");

            Console.ReadLine();
        }
    }
}
