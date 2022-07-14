using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Заполните город отправителя.")]
        [Display(Name = "Город отправителя:")]
        public string CitySender { get; set; }
        [Required(ErrorMessage = "Заполните адрес отправителя.")]
        [Display(Name = "Адрес отправителя:")]
        public string AddressSender { get; set; }
        [Required(ErrorMessage = "Заполните город получателя.")]
        [Display(Name = "Город получателя:")]
        public string CityReceiver { get; set; }
        [Required(ErrorMessage = "Заполните адрес получателя.")]
        [Display(Name = "Адрес получателя:")]
        public string AddressReceiver { get; set; }
        [Required(ErrorMessage = "Заполните вес груза.")]
        [Display(Name = "Вес груза:")]
        [Range(1, int.MaxValue, ErrorMessage = "Вес должен быть больше 0")]
        public int Weight { get; set; }
        [Required(ErrorMessage = "Заполните дату забора груза.")]
        [Display(Name = "Дата забора груза:")]
        [Column(TypeName = "date")]
        public DateTime DateTakeCargo { get; set; }

    }
}
