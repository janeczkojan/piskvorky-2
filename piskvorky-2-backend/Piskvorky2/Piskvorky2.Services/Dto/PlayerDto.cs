using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piskvorky2.Services.Dto
{
    public class PlayerDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Symbol { get; set; }

        public string BackgroundColor { get; set; }

        public string TextColor { get; set; }

        public DateTime LastActivity { get; set; }
    }
}
