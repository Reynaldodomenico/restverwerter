using System;
using System.Collections.Generic;
using System.Text;

namespace CommonInterfaces
{
    public interface IIngredient
    {
        public string Name { get; set; }
        public float Amount { get; set; }
        public string Unity { get; set; }
    }
}
