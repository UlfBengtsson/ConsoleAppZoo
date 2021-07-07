using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppZoo.Models
{
    interface IDangerus
    {
        /// <summary>
        /// Score 1-9 low to high
        /// </summary>
        int DangerLevel { get; set; }
        string DangerInfo();
    }
}
