using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.UseCases.Commands;

namespace Application.Validators
{
    public class PropertyValidator : AbstractValidator<CreatePropertyCommand>
    {
        public PropertyValidator()
        {
            RuleFor(static x => x.Address).NotEmpty().WithMessage("Address is required.");
            RuleFor( x => x.Price).GreaterThan(0).WithMessage("Price must be greater than zero.");
            
        }

        private object RuleFor(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }

}
