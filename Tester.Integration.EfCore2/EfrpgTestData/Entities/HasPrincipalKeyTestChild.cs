// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
{
    // HasPrincipalKeyTestChild
    public class HasPrincipalKeyTestChild
    {
        public int Id { get; set; } // Id (Primary key)
        public int A { get; set; } // A
        public int B { get; set; } // B
        public int? C { get; set; } // C
        public int? D { get; set; } // D

        // Foreign keys

        /// <summary>
        /// Parent HasPrincipalKeyTestParent pointed by [HasPrincipalKeyTestChild].([A], [B]) (FK_HasPrincipalKey_AB)
        /// </summary>
        public HasPrincipalKeyTestParent HasPrincipalKeyTestParent { get; set; } // FK_HasPrincipalKey_AB
    }

}
// </auto-generated>
