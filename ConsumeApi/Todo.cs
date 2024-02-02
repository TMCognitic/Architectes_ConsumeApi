using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeApi
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public bool Done { get; set; }
    }
}
