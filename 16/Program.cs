using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] array = new int[10];
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart(2);
            for (int i = 0; i < 10; i++)
            {
                array[i] = geomProgression.getNext();
                Console.WriteLine(array[i]);
            }
            int[] array2 = new int[10];
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.setStart(2);
            for (int i = 0; i < 10; i++)
            {
                array[i] = arithProgression.getNext();
                Console.WriteLine(array[i]);
            }
        }
    }
    interface ISeries
    {
        public void setStart(int x);
        public int getNext();
        public void reset();
    }

    class ArithProgression : ISeries
    {
        public int Step { get; set; }
        public int Start { get; set; }

        public void setStart(int x)
            { 
            Start = x;
            Step = Start;
            }
        public int getNext()
        {
            Start = Start+Step;
            return Start;
        }
        public void reset()
        {
            Start = Step;
        }

    }
    class GeomProgression : ISeries
    {

        public int Step { get; set; }
        public int Start { get; set; }

        public void setStart(int x)
        {
            Start = x;
            Step = Start;
        }
        public int getNext()
        {
            Start = Start * Step;
             
            return Start;
        }
        public void reset()
        {
            Start =  Step;
        }

    }
}