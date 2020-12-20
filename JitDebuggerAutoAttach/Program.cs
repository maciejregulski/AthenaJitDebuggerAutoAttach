// Program.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="Program.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Application runner class.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
