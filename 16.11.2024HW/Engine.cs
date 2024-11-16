using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._11._2024HW
{
    public interface IEngine
    {
        void Start();
        void Stop();
        bool IsRunning();
    }

    public abstract class Engine : IEngine
    {
        protected float _hp;
        protected float _fuelConsumptionRate;

        public bool Running { get; protected set; }

        public virtual void Start()
        {
            Running = true;
            Console.WriteLine("The engine starts running");
        }

        public void Stop()
        {
            Running = false;
        }

        public bool IsRunning()
        {
            return Running;
        }
    }
}
