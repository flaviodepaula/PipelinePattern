using System.Collections.Generic;

namespace Pipeline.Forward.Steps
{
   public class Pipeline<T>
   {
      private List<IStep<T>> _steps = new List<IStep<T>>();

      public Pipeline<T> Add(IStep<T> step)
      {
         _steps.Add(step);
         return this;
      }

      public T Execute(T input)
      {
         foreach (var step in _steps)
         {
            input = step.Execute(input);
         }
         return input;
      }
   }
}