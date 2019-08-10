using NutritionControl.BLL.Concrete.Validations;
using FluentValidation.Attributes;

namespace NutritionControl.BLL.Concrete
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {        
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
