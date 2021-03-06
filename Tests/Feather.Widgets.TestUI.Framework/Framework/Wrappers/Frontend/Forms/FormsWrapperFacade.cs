﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feather.Widgets.TestUI.Framework.Framework.Wrappers.Frontend.Forms
{
    /// <summary>
    /// This is the entry point class for forms frontend wrappers.
    /// </summary>
    public class FormsWrapperFacade
    {
        /// <summary>
        /// Provides unified access to the FormsWrapper 
        /// </summary>
        /// <returns>Returns the FormsWrapper</returns>
        public FormsWrapper FormsWrapper()
        {
            return new FormsWrapper();
        }
    }
}
