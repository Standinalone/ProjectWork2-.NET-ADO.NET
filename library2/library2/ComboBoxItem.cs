using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library2
{
    public class ComboboxItem
    {
        public String Text { get; set; }
        public object Value { get; set; }

        public ComboboxItem(String text, object Value)
        {
            this.Text = text;
            this.Value = Value;
        }
        public override string ToString()
        {
            return this.Text;
        }
    }
}
