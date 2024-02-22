using System.Text;

namespace Pipeline
{
   public class Address : IValidate
   {
      public bool Validate(bool input)
      {
         return true;
      }
   }
}