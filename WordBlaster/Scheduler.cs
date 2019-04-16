using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WordBlaster
{
    public class Scheduler
    {
        private Thread runningThread;
        private List<Object> waitingRequests = new List<Object>();
        private List<Object> waitingThreads = new List<Object>();
        Object o = new object();

        public void enter(Thread s)
        {
            Thread thisThread = Thread.CurrentThread;

          lock(this)
          {
            if (runningThread == null)
            {
                runningThread = thisThread;
                return;
            } // if
            waitingThreads.Add(thisThread);
            waitingRequests.Add(s);
        } // synchronized (this)
        lock(o)
        {
            while (thisThread != runningThread)
            {
                    Monitor.PulseAll(o);
            } // while
        } // synchronized (thisThread)
        lock(this)
        {
            int i = waitingThreads.IndexOf(thisThread);
            waitingThreads.Remove(i);
        } // synchronized (this)
    } // enter(ScheduleOrdering)

    public void done()
    {
        if (runningThread != Thread.CurrentThread)
            throw new Exception("Wrong Thread");
        int waitCount = waitingThreads.Count();
        if (waitCount <= 0)
        {
            runningThread = null;
        }
        else if (waitCount == 1)
        {
            runningThread = (Thread)waitingThreads.ElementAt(0);
        }
        else
        {
            int next = waitCount - 1;
            Scheduler nextRequest;
            nextRequest = (Scheduler)waitingRequests.ElementAt(next);
            runningThread = (Thread)waitingThreads.ElementAt(next);
        } // if waitCount
        lock(o) {
                Monitor.PulseAll(o);
        } // synchronized (runningThread)
    } // done()

         public async void task1(Object form)
        {
            WordBlasterForm form1 = (WordBlasterForm)form;
            do
            {
                    form1.charpermin += (form1.chararray[0] * 60); 
                    form1.chararray[0] = 0;
                await Task.Delay(1000); //wait one second
            } while (!form1.getDone());
        }

        public async void task2(Object form)
        {
            WordBlasterForm form1 = (WordBlasterForm)form; //Thread 2's Task associated with Lane 2
            do
            {
                    form1.charpermin += (form1.chararray[1] * 60);
                    form1.chararray[1] = 0;
                await Task.Delay(1000);
            } while (!form1.getDone());
        }

        public async void task3(Object form)
        {
            WordBlasterForm form1 = (WordBlasterForm)form;//Thread 3's Task associated with Lane 3
            do
            {
                await Task.Delay(5000);
                    form1.charpermin += (form1.chararray[2] * 60);
                    form1.chararray[2] = 0;
            } while (!form1.getDone());
        }

        public async void task4(Object form)//Thread 4's Task associated with Lane 4
        {
            WordBlasterForm form1 = (WordBlasterForm)form;
            do
            {
                await Task.Delay(1000);
                    form1.charpermin += (form1.chararray[3] * 60);
                    form1.chararray[3] = 0;
            } while (!form1.getDone());
        }

        public async void task5(Object form) //Thread 5's Task associated with Lane 5
        {
            WordBlasterForm form1 = (WordBlasterForm)form;
            do
            {
                await Task.Delay(5000);
                    form1.charpermin += (form1.chararray[4] * 12);
                    form1.chararray[4] = 0;
                form1.charpermin = 0; //reset number after five seconds
            } while (!form1.getDone());
        }
    } // class Scheduler
}
