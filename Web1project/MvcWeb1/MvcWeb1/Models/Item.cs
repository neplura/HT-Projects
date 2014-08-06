using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcWeb1.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Item_num { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public DateTime Inbound_date { get; set; }
        public DateTime Outbound_date { get; set; }
        public string Creator { get; set; }
        public DateTime Modify_date { get; set; }
        public string Editor { get; set; }

    }
    public class ItemsList : DbContext
    {
        public DbSet<Item> Database1 { get; set; }
    }
}