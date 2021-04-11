using System.Collections.Generic;

namespace QueueWithStackConsoleApp.Models
{
    public class MyQueue<T> where T : class
    {
        private Stack<T> StackNewest;
        private Stack<T> StackOldest;

        public MyQueue() => (StackNewest, StackOldest) = (new Stack<T>(), new Stack<T>());

        #region snippet_GetSize

        /// <summary>Returns the size of MyQueue</summary>
        /// <returns>Integer</returns>
        public int GetSize() => StackNewest.Count + StackOldest.Count;

        #endregion

        #region snippet_Add

        /// <summary>Adds new element into the queue</summary>
        /// <param name="value">T class value</param>
        public void Add(T value) => StackNewest.Push(value);

        #endregion

        #region snippet_Peek

        /// <summary>Returns the first element</summary>
        /// <returns>T class value</returns>
        public T Peek()
        {
            ShiftStacks();
            if (StackOldest.Count == 0) return null;
            return StackOldest.Peek();
        }

        #endregion

        #region snippet_Remove

        /// <summary>Remove the first element</summary>
        /// <returns>T class value</returns>
        public T Remove()
        {
            ShiftStacks();
            if (StackOldest.Count == 0) return null;
            return StackOldest.Pop();
        }

        #endregion

        #region snippet_Shifts

        /// <summary>Interchanges the values from the StackNewest to the StackOldest</summary>
        private void ShiftStacks()
        {
            if (StackOldest.Count == 0)
            {
                while (StackNewest.Count != 0)
                {
                    StackOldest.Push(StackNewest.Pop());
                }
            }
        }

        #endregion
    }
}