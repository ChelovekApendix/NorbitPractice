namespace Collections_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конструктор без параметров:");
            var stackNo = new SmartStack<int>();
            Console.WriteLine($"{stackNo}, Count = {stackNo.Count}, Capacity = {stackNo.Capacity}");

            Console.WriteLine("Конструктор с целочисленным параметром:");
            var stackOne = new SmartStack<string>(10);
            Console.WriteLine($"{stackOne}, Count = {stackOne.Count}, Capacity = {stackOne.Capacity}");

            Console.WriteLine("Конструктор с коллекцией:");
            var list = new List<string> { "A", "B", "C" };
            Console.WriteLine($"Коллекция (list): {list}, Элементы: {string.Join(", ", list)}");
            var stackCol = new SmartStack<string>(list);
            Console.WriteLine($"Стек = {stackCol}, Count = {stackCol.Count}, Capacity = {stackCol.Capacity}");

            Console.WriteLine("Push:");
            var stackPushPop = new SmartStack<int>();
            stackPushPop.Push(7);
            stackPushPop.Push(11);
            stackPushPop.Push(15);
            Console.WriteLine($"Push(7),(11),(15): {stackPushPop}");

            Console.WriteLine("PushRange:");
            stackPushPop.PushRange(new[] { 1, 2, 3 });
            Console.WriteLine($"PushRange(1,2,3): {stackPushPop}");

            Console.WriteLine("Pop:");
            Console.WriteLine($"Изначальный стек: {stackPushPop}");
            Console.WriteLine($"Вершина: {stackPushPop.Pop()}, Итоговый стек: {stackPushPop}");

            Console.WriteLine("Peek:");
            Console.WriteLine($"Вершина: {stackPushPop.Peek()}, Итоговый стек: {stackPushPop}");

            Console.WriteLine("Contains:");
            Console.WriteLine($"Стек содержит 3? {stackPushPop.Contains(2)}");
            Console.WriteLine($"Стек содержит 10? {stackPushPop.Contains(10)}");

            Console.WriteLine("Итерирование:");
            foreach (var item in stackPushPop)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine("Ошибки:");
            var stackEmpty = new SmartStack<double>();
            try
            {
                stackEmpty.Pop();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка при Pop: {ex.Message}");
            }

            try
            {
                stackEmpty.Peek();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка при Peek: {ex.Message}");
            }

            try
            {
                var stackNegative = new SmartStack<int>(-1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при создании стека с отрицательной ёмкостью: {ex.Message}");
            }
        }
    }
}
