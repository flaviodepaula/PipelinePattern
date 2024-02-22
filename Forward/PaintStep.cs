using System.Text;

namespace Pipeline.Forward.Steps
{
   public class PaintStep : IStep<StringBuilder>
   {
      public StringBuilder Execute(StringBuilder input)
      {
         input.Append("[Paint] ");
         return input;
      }
   }
}