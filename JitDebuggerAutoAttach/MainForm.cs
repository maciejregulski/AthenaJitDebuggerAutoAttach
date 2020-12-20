// MainForm.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="MainForm.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// Applications main form class.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// References combo box data source.
        /// </summary>
        private IList<ComboItem> comboDataSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();

            this.InitializeComboBox();

            this.Load += (s, e) =>
            {
                this.timer.Enabled = true;
            };
        }

        /// <summary>
        /// Gets combo box selected item.
        /// </summary>
        private ComboItem ComboSelectedItem => this.comboProcessList.SelectedItem as ComboItem;

        /// <summary>
        /// Populates combo box items.
        /// </summary>
        private void InitializeComboBox()
        {
            this.comboDataSource = this.CreateProcessList();
            this.comboProcessList.DisplayMember = "Name";
            this.comboProcessList.ValueMember = "Process";
            this.comboProcessList.DataSource = this.comboDataSource;
        }

        /// <summary>
        /// Creates combo box default data set.
        /// </summary>
        /// <returns>Combo box item collection.</returns>
        private List<ComboItem> CreateProcessList()
        {
            return new List<ComboItem>
            {
                new ComboItem { Name = "Simulation Config for Athena", Process = "SimulationConfig.exe" },
                new ComboItem { Name = "System Config for Athena", Process = "SystemConfig.exe" }
            };
        }

        /// <summary>
        /// Timer tick handler.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                var autoDebug = new Registry.AeDebugRegistryManager().GetAeDebugEntry();
                chkAeDebug.Checked = autoDebug?.Enabled ?? false;
            }
            catch (Exception)
            {
                ////MessageBox.Show(this, ex.Message);
            }
        }

        /// <summary>
        /// Add button click handler.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this.ComboSelectedItem;
                if (selectedItem != null)
                {
                    var processEntry = new Registry.ProcessEntry(selectedItem.Process);
                    if (new Registry.ProcessRegistryManager().AddProcessEntry(processEntry))
                    {
                        MessageBox.Show(this, $"Added registry record to launch debugger for {processEntry.ProcessName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        /// <summary>
        /// Remove button click handler.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = this.ComboSelectedItem;
                if (selectedItem != null)
                {
                    var processEntry = new Registry.ProcessEntry(selectedItem.Process);
                    if (new Registry.ProcessRegistryManager().RemoveProcessEntry(processEntry))
                    {
                        MessageBox.Show(this, $"Removed registry key for {processEntry.ProcessName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        /// <summary>
        /// Checkbox click handler.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void ChkAeDebug_Click(object sender, EventArgs e)
        {
            try
            {
                new Registry.AeDebugRegistryManager().SetAeDebugEntry(new Registry.AeDebugEntry(chkAeDebug.Checked));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        /// <summary>
        /// Exit application button click handler.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event data.</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
