using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WBA.PE2.KurbanovD.Web.ViewModels
{
    public class HeroesUpdateCreateViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(3,ErrorMessage = "Name should be at least 3 characters long!")]
        [MaxLength(42,ErrorMessage = "Name can't be more than 42 characters!")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Action Points")]
        [Range(1, 5, ErrorMessage = "Actionpoints value should be between 1 and 5")]
        public int ActionPoints { get; set; }

        [Required]
        [Display(Name= "Hero Class")]
        public int HeroClass { get; set; }

        [Required]
        [Display(Name = "Damage Type")]
        public int DamageType { get; set; }

        [Required]
        [Range(100,double.MaxValue,ErrorMessage = "Health should be at least 100!")]
        public double Health { get; set; }

        [Required]
        [Display(Name = "Health Regeneration")]
        public double HealthRegeneration  { get; set; }

        [Required]
        public double Mana { get; set; }

        [Required]
        [Display(Name = "Mana Regeneration")]
        public double ManaRegeneration { get; set; }

        [Required]
        [Range(1,double.MaxValue,ErrorMessage = "Damage should be at least 1!")]
        public double Damage { get; set; }

        [Required]
        [Range(1,double.MaxValue,ErrorMessage = "Armor should be at least 1!")]
        public double Armor { get; set; }

        [Required]
        [MaxLength(2000,ErrorMessage = "Description can't be more than 2000 characters!")]
        public string Description { get; set; }
        [Required]
        public List<Guid> SkillSet { get; set; }
        [Required]
        public string Image { get; set; }
        public List<SelectListItem> Images { get; set; }
        public List<SelectListItem> HeroClasses { get; set; }
        public List<SelectListItem> Skills { get; set; }
        public List<SelectListItem> DamageTypes { get; set; }

        public HeroesUpdateCreateViewModel()
        {
            SkillSet = new List<Guid>();
            Skills = new List<SelectListItem>();

        }
    }
}
