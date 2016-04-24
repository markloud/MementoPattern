namespace MementoPattern
{
    //object that stores the historical state
    public class Memento<T>
    {
        private T state;

        public T GetState()
        {
            return state;
        }

        public void SetState(T state)
        {
            this.state = state;
        }
    }
}