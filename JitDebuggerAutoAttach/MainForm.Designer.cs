// MainForm.Designer.cs
//
// Comments : 
// Date     : 2020/12/20
// Author   : Maciej ext Regulski
// <copyright file="MainForm.Designer.cs" company="Carl Zeiss Microscopy GmbH">
//     Copyright (c) Carl Zeiss Microscopy GmbH. All rights reserved.
// </copyright>

namespace JitDebuggerAutoAttach
{
    /// <summary>
    /// Applications main form class.
    /// </summary>
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkAeDebug = new System.Windows.Forms.CheckBox();
            this.comboProcessList = new System.Windows.Forms.ComboBox();
            this.lblProcessList = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblAeDebug = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAeDebug
            // 
            this.chkAeDebug.AutoSize = true;
            this.chkAeDebug.Location = new System.Drawing.Point(186, 66);
            this.chkAeDebug.Name = "chkAeDebug";
            this.chkAeDebug.Size = new System.Drawing.Size(144, 17);
            this.chkAeDebug.TabIndex = 0;
            this.chkAeDebug.Text = "Set automatic debugging";
            this.chkAeDebug.UseVisualStyleBackColor = true;
            this.chkAeDebug.Click += new System.EventHandler(this.ChkAeDebug_Click);
            // 
            // comboProcessList
            // 
            this.comboProcessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProcessList.FormattingEnabled = true;
            this.comboProcessList.Location = new System.Drawing.Point(186, 24);
            this.comboProcessList.Name = "comboProcessList";
            this.comboProcessList.Size = new System.Drawing.Size(181, 21);
            this.comboProcessList.TabIndex = 1;
            // 
            // lblProcessList
            // 
            this.lblProcessList.AutoSize = true;
            this.lblProcessList.Location = new System.Drawing.Point(24, 27);
            this.lblProcessList.Name = "lblProcessList";
            this.lblProcessList.Size = new System.Drawing.Size(144, 13);
            this.lblProcessList.TabIndex = 2;
            this.lblProcessList.Text = "Application process to debug";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(292, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblAeDebug
            // 
            this.lblAeDebug.AutoSize = true;
            this.lblAeDebug.Location = new System.Drawing.Point(24, 66);
            this.lblAeDebug.Name = "lblAeDebug";
            this.lblAeDebug.Size = new System.Drawing.Size(145, 13);
            this.lblAeDebug.TabIndex = 5;
            this.lblAeDebug.Text = "Fix process has stopped error";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(105, 111);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 154);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblAeDebug);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblProcessList);
            this.Controls.Add(this.comboProcessList);
            this.Controls.Add(this.chkAeDebug);
            this.Name = "MainForm";
            this.Text = "Visual Studio Debugger Attach To Starting Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAeDebug;
        private System.Windows.Forms.ComboBox comboProcessList;
        private System.Windows.Forms.Label lblProcessList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblAeDebug;
        private System.Windows.Forms.Button btnRemove;
    }
}

