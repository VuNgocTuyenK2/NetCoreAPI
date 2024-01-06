using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace NetMVC.Models
{
    [Table("Khachhang")]

    public class Khachhang
    {
        [Key]
        // tự sinh ra id khi create
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Mã khach hang không được để trống.")]
        public string? IdKh { get; set; }
        [Required(ErrorMessage = "Hãy chọn san pham can mua")]
        public int? IdClothes { get; set; }
        [Required(ErrorMessage = "Họ và tên khach hang không được để trống.")]
        public string? NameKh { get; set; }
        [Required(ErrorMessage = "dia chi không được để trống.")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Số điện thoại khach hang không được để trống.")]
        public string? PhoneKh { get; set; }
        
        [Required(ErrorMessage = "Ngày mua không được để trống.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Purchasedate { get; set; }
        
        
        public int Status { get; set; }

    }
    public class KhachhangWithClothesViewModel
    {
        public int Id { get; set; }
        public string? IdKh { get; set; }
        public string? NameKh { get; set; }
        public string? Address { get; set; }
        
        public string? PhoneKh { get; set; }
       
        public string? ClothesName { get; set; }
        public DateTime? Purchasedate { get; set; }
        public bool ClearFilter { get; set; }
        
        public int Status { get; set; }
        public int? ClothesId { get; set; }
    }
}