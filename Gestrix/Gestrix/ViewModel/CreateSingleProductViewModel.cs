using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestrix.ViewModel
{
    public partial class CreateSingleProductViewModel
    {
       
        public string productId { get; set; }
        public string productGTIN { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productQuantity { get; set; }

    }
}
