// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // A
    public class A
    {
        public int AId { get; set; } // AId (Primary key)
        public int C1 { get; set; } // C1
        public int C2 { get; set; } // C2

        // Foreign keys

        /// <summary>
        /// Parent Aaref pointed by [A].([C1], [C2]) (FK_A_A)
        /// </summary>
        public Aaref Aaref { get; set; } // FK_A_A
    }

}
// </auto-generated>
