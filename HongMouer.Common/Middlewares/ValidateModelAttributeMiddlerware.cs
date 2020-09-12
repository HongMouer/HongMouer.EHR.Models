using System;
using System.Collections.Generic;
using System.Text;

namespace HongMouer.Common.Middlewares
{
  //public  class ValidateModelAttributeMiddlerware : ActionFilterAttribute
  //  {
  //      public override void OnActionExecuting(ActionExecutingContext context)
  //      {
  //          if (!context.ModelState.IsValid)
  //          {
  //              var result = context.ModelState.Keys
  //                      .SelectMany(key => context.ModelState[key].Errors.Select(x => new ValidationError(key, x.ErrorMessage)))
  //                      .ToList();
  //              context.Result = new ObjectResult(result);
  //          }
  //      }
  //  }
  //  public class ValidationError
  //  {
  //      [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
  //      public string Field { get; }
  //      public string Message { get; }
  //      public ValidationError(string field, string message)
  //      {
  //          Field = field != string.Empty ? field : null;
  //          Message = message;
  //      }
  //  }
}
