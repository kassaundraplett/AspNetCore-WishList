using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required()]
        public string Description { get; set; }

    }
}
