// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore2
{
    // Harish3485
    public class Alpha_Harish3485
    {
        public int Id { get; set; } // id (Primary key)
        public int HarishId { get; set; } // harish_id

        // Foreign keys

        /// <summary>
        /// Parent FkTest_SmallDecimalTestAttribute pointed by [Harish3485].([HarishId]) (FK_Harish)
        /// </summary>
        public FkTest_SmallDecimalTestAttribute FkTest_SmallDecimalTestAttribute { get; set; } // FK_Harish
    }

}
// </auto-generated>
