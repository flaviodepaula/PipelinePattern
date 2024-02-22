using System.Text;

namespace Pipeline
{
   public class Customer : IValidate
   {
      public bool Validate(bool input)
      {
         return false;
      }
   }
}