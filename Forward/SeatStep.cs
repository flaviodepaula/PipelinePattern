using System.Text;

namespace Pipeline.Forward.Steps
{
   public class SeatStep : IStep<StringBuilder>
   {
      public StringBuilder Execute(StringBuilder input)
      {
         input.Append("[Seat] =>");
         return input;
      }
   }
}