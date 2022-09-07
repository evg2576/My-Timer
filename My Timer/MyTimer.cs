using System;
using System.Threading;
using System.Threading.Tasks;

namespace My_Timer
{
    public static class MyTimer
    {
        public static void SetTimeout(int time, Action callback)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(time);
                callback.Invoke();
            });
        }

        public static void SetInterval(int time, Action callback, int count = 0)
        {
            var T = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i <= count;)
                {
                    Thread.Sleep(time);
                    callback.Invoke();
                    if (count > 0)
                    {
                        i++;
                        if (i == count) break;
                    }
                }
            });
        }
    }
}
