#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;

namespace SearchPanel
{
    public class ShipCountries : List<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipCountries"/> class.
        /// </summary>
        public ShipCountries()
        {
            var model = new OrderInfoRepository();
            this.AddRange(model.ShipCountries);
        }
    }
}
