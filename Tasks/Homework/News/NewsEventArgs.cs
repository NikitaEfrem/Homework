using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    public class NewsEventArgs : EventArgs
    {
        public string Category { get; set; }
        public string News { get; set; }
    }
}
