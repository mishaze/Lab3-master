using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Lab3
    {
        object mutex = new object();
        public List<int> ConsumersTimeList = new List<int>();
        public List<int> ProducersTimeList = new List<int>();
        public List<Thread> consumers = new List<Thread>();
        public List<Thread> produsers = new List<Thread>();
        public ProducerConsumer<string> q = new ProducerConsumer<string>();
        public int NumberProces = 0;//счетчик date

          public  void Producer()
          {
                int number = ProducersTimeList.Count;
                while (ProducersTimeList[number - 1] > 0)
                {
                    if (q.queue.Count < 11)
                    {
                        Thread.Sleep(ProducersTimeList[number - 1] * 1000);//имитация выполнения

                        lock (mutex)
                        {
                            NumberProces++;
                            q.Enqueue("Date: " + NumberProces.ToString());
                            Console.WriteLine("Produser[{0}] Added: [Data {1}].", number, NumberProces);
                        }
                        
                    }
                }
          }

          public  void Consumer()
          {
                int number = ConsumersTimeList.Count;
                while (ConsumersTimeList[number - 1] > 0)
                {
                    string s = q.Dequeue();
                    if (s == null)
                        continue;
                
                    Console.WriteLine("Consumer[{0}] Pic Up: [{1}].", number, s);
                    Thread.Sleep(ConsumersTimeList[number - 1] * 1000);
                    
                }
          }
         
    }


    public class ProducerConsumer<T> where T : class
    {
        object mutexEnqueue = new object();
        object mutexDequeue = new object();
        public Queue<T> queue = new Queue<T>();
        bool isDead = false;
        public T[] Q = new T[11];

        public void Enqueue(T task)//add
        {
            if (task == null)
                throw new ArgumentNullException("task");
            lock (mutexEnqueue)
            {
                queue.Enqueue(task);
            }
        }

        public T Dequeue()//extract
        {
            lock (mutexDequeue)
            {
                if (queue.Count == 0)
                    return null;

                return queue.Dequeue();
            }
        }

        public T[] getQueue()//для отображения
        {
            for (int i = 0; i < Q.Length; i++)
            { Q[i] = null; }

            queue.CopyTo(Q, 0);
            return Q;
        }

    }
}
