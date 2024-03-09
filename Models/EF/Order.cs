﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebBanHang.Models.EF
{
    [Table("tb_Order")]
    public class Order:CommonAbstract
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage ="Tên khách hàng không để trống !")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage ="Số điện thoại không để trống!")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Địa chỉ không để trống!")]
        public string Address { get; set; }
        public string Email { get; set; }
        public decimal TotalAmount { get; set; }
        public int TypePayment { get; set; }
        public int Quantity { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}