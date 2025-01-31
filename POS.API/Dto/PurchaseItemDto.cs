﻿using System.ComponentModel.DataAnnotations;

namespace WebApisPointOfSales.Dto
{
    public class PurchaseItemDto
    {
        [Required(ErrorMessage = "ProductId is required")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public int Quantity { get; set; }
    }
}
