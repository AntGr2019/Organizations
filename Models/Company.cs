using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Organizations.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Name { get; set; }

        [Display(Name = "ИНН")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(("[0-9]{12}|[0-9]{10}"), ErrorMessage = "ИНН должен состоять из 10 или 12 цифр")]
        public string INN { get; set; }
        public virtual ICollection<Founder> Founders { get; set; }
        public Company()
        {
            Founders = new List<Founder>();
        }
    }
}