// AeDebugEntry.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="AeDebugEntry.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach.Registry
{
    using System;

    /// <summary>
    /// Stores registry information for automatic debugging entry.
    /// </summary>
    public class AeDebugEntry
    {
        /// <summary>
        /// Auto and Enabled properties backing field.
        /// </summary>
        private readonly bool enabled;

        /// <summary>
        /// Initializes a new instance of the <see cref="AeDebugEntry" /> class.
        /// </summary>
        /// <param name="enabled">Enable or disable automatic debugging.</param>
        public AeDebugEntry(bool enabled)
        {
            this.enabled = enabled;
        }

        /// <summary>
        /// Gets current automatic debugging status as boolean.
        /// </summary>
        public bool Enabled => this.enabled;

        /// <summary>
        /// Gets current automatic debugging status as DWORD registry representation.
        /// </summary>
        public int Auto => this.enabled ? 1 : 0;
    }
}
