// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // Parent
    public class Synonyms_Parent
    {
        public int ParentId { get; set; } // ParentId (Primary key)
        public string ParentName { get; set; } // ParentName (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child Synonyms_Children where [Child].[ParentId] point to this entity (FK_Child_Parent)
        /// </summary>
        public ICollection<Synonyms_Child> Synonyms_Children { get; set; } // Child.FK_Child_Parent

        public Synonyms_Parent()
        {
            Synonyms_Children = new List<Synonyms_Child>();
        }
    }

}
// </auto-generated>
