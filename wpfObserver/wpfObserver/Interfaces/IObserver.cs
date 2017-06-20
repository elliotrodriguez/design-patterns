using System;

namespace wpfObserver.Interfaces
{
    public interface IObserver<in T> where T:EventArgs
    {
        void Update(Object sender, T e);
    }
}
