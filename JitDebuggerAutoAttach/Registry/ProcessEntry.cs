// ProcessEntry.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="ProcessEntry.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach.Registry
{
    using System;

    /// <summary>
    /// Stores registry information for process image.
    /// </summary>
    public class ProcessEntry
    {
        /// <summary>
        /// Default Just In Time debugger path.
        /// </summary>
        private const string VsJitDebugger = @"%windir%\system32\vsjitdebugger.exe";

        /// <summary>
        /// Process name backing field.
        /// </summary>
        private readonly string processName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessEntry" /> class.
        /// </summary>
        /// <param name="processName">Application process name to be debugged.</param>
        public ProcessEntry(string processName)
        {
            this.processName = processName.EndsWith(".exe") ? processName : string.Format("{0}{1}", processName, ".exe");
        }

        /// <summary>
        /// Gets a directory path to store in the registry.
        /// </summary>
        public string DebuggerPath => Environment.ExpandEnvironmentVariables(VsJitDebugger);

        /// <summary>
        /// Gets process image name.
        /// </summary>
        public string ProcessName => this.processName;
    }
}
