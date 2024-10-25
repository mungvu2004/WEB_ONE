
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseMy
{
    [Table("Cart")]
    public partial class Cart
    {
        // Khóa chính của bảng
        [Key]
        public int Id { get; set; }

        // ID người dùng, không được để trống
        [ForeignKey("User")]
        public int UserId { get; set; }

        // ID sản phẩm, không được để trống
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        // Số lượng sản phẩm, không được để trống
        public int Quantity { get; set; }

        // Các thuộc tính điều hướng
        public virtual User User { get; set; }
        public virtual Shirt Product { get; set; }
    }
}
