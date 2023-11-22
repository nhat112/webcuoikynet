using Shopping_Tutorial.Repository.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_Tutorial.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Tên Sản Phẩm")]
        public string Name { get; set; }

        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Yêu cầu nhập Mô Tả Sản Phẩm")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập Giá Sản Phẩm")]
        [Range(0.01, double.MaxValue)]
        [Column(TypeName = "decimal(8, 2")]

        public decimal Price { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn Một Thương hiệu")]

        public int BrandId { get; set; }
        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn Một Danh Mục")]
        public int CategoryId { get; set; }

        public CategoryModel Category { get; set; }
        public BrandModel Brand { get; set; }
        public string Image { get; set; } = "image.jpg";

        [NotMapped]

		[FileExtension]

        public IFormFile ImageUpload {  get; set; }
    }
}
                