using System.Text;

namespace Pipeline
{
   public class Card : IValidate
   {
      public bool Validate(bool input)
      {
         return true;
      }
   }
}