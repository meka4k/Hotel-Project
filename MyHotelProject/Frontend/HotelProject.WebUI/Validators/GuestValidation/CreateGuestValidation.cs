using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Validators.GuestValidation
{
    public class CreateGuestValidation:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez.")
                .MinimumLength(2).WithMessage("Minimum 2 karakter olmalıdır.")
                .MaximumLength(30).WithMessage("Maksimum 30 karakter olmalıdır.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez.")
               .MinimumLength(2).WithMessage("Minimum 2 karakter olmalıdır.")
               .MaximumLength(30).WithMessage("Maksimum 30 karakter olmalıdır.");

            RuleFor(x => x.City).NotEmpty().WithMessage("{PropertyName} alanı boş geçilemez.")
               .MinimumLength(2).WithMessage("Minimum 2 karakter olmalıdır.")
               .MaximumLength(30).WithMessage("Maksimum 30 karakter olmalıdır.");
        }
    }
}
