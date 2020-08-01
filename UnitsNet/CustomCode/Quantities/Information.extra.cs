using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

namespace UnitsNet
{
    public partial class Information
    {
        /// <summary>
        /// Copy of information
        /// </summary>
        /// <param name="i"></param>
        public Information(Information i) : this(i.Value, i.Unit) { }
        /// <summary>
        /// Empty Information object
        /// </summary>
        public Information() : this(Zero.Value, Zero.Unit) { }
    }
}
