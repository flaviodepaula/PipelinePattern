
namespace Pipeline.Forward.Steps
{
   public class ValidatePipeline<T>
   {
      private List<IValidate> _steps = new List<IValidate>();

      public ValidatePipeline<T> Add(IValidate step)
      {
         _steps.Add(step);
         return this;
      }

      public bool Execute()
      {
         bool input = true;
         foreach (var step in _steps)
         {
            input = step.Validate(input);
            if (!input)
            {
               return false;
            }
         }
         return input;
      }
   }
}