using System.Collections.Generic;

namespace Pipeline.Forward.Steps
{
   public interface IStep<T>
   {
      T Execute(T input);
   }
}
