// <auto-generated>
// ReSharper disable All

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3
{
    // Car
    public class Car
    {
        public int Id { get; set; } // Id (Primary key)
        public int PrimaryColourId { get; set; } // PrimaryColourId
        public string CarMake { get; set; } // CarMake (length: 255)
        public int? ComputedColumn { get; private set; } // computed_column
        public int ComputedColumnPersisted { get; private set; } // computed_column_persisted

        // Reverse navigation

        /// <summary>
        /// Child CarToColours where [CarToColour].[CarId] point to this entity (CarToColour_CarId)
        /// </summary>
        public ICollection<CarToColour> CarToColours { get; set; } // CarToColour.CarToColour_CarId

        // Foreign keys

        /// <summary>
        /// Parent Colour pointed by [Car].([PrimaryColourId]) (CarPrimaryColourFK)
        /// </summary>
        public Colour Colour { get; set; } // CarPrimaryColourFK

        public Car()
        {
            CarToColours = new List<CarToColour>();
        }
    }

}
// </auto-generated>
