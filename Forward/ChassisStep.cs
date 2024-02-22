using System.Text;

namespace Pipeline.Forward.Steps
{
   public class ChassisStep : IStep<StringBuilder>
   {
      public StringBuilder Execute(StringBuilder input)
      {
         input.Append("[Chassi] =>");
         return input;
      }
   }
}