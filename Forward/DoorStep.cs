using System.Text;

namespace Pipeline.Forward.Steps
{
   public class DoorStep : IStep<StringBuilder>
   {
      public StringBuilder Execute(StringBuilder input)
      {
         input.Append(" [Door] =>");
         return input;
      }
   }
}