﻿namespace ATM_ManagementSystem
{
    partial class Balance
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            labelBack = new Label();
            label1 = new Label();
            labelBalance = new Label();
            guna2ButtonDeposit = new Guna.UI2.WinForms.Guna2Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 98);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(544, -13);
            label2.Name = "label2";
            label2.Size = new Size(43, 51);
            label2.TabIndex = 2;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(48, 19);
            label3.Name = "label3";
            label3.Size = new Size(490, 51);
            label3.TabIndex = 0;
            label3.Text = "ATM Management System";
            // 
            // labelBack
            // 
            labelBack.AutoSize = true;
            labelBack.Font = new Font("Segoe UI Semibold", 16.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelBack.Location = new Point(256, 327);
            labelBack.Name = "labelBack";
            labelBack.Size = new Size(77, 38);
            labelBack.TabIndex = 17;
            labelBack.Text = "Back";
            labelBack.Click += labelBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 162);
            label1.Name = "label1";
            label1.Size = new Size(260, 51);
            label1.TabIndex = 18;
            label1.Text = "Your Balance:";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.Font = new Font("Segoe UI", 22.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelBalance.Location = new Point(298, 162);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(159, 51);
            labelBalance.TabIndex = 19;
            labelBalance.Text = "balance";
            // 
            // guna2ButtonDeposit
            // 
            guna2ButtonDeposit.BorderRadius = 20;
            guna2ButtonDeposit.BorderThickness = 2;
            guna2ButtonDeposit.CustomizableEdges = customizableEdges1;
            guna2ButtonDeposit.DisabledState.BorderColor = Color.DarkGray;
            guna2ButtonDeposit.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2ButtonDeposit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2ButtonDeposit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2ButtonDeposit.FillColor = Color.Yellow;
            guna2ButtonDeposit.Font = new Font("Segoe UI Semibold", 20.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ButtonDeposit.ForeColor = Color.Black;
            guna2ButtonDeposit.Location = new Point(159, 258);
            guna2ButtonDeposit.Name = "guna2ButtonDeposit";
            guna2ButtonDeposit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ButtonDeposit.Size = new Size(271, 66);
            guna2ButtonDeposit.TabIndex = 23;
            guna2ButtonDeposit.Text = "Deposit";
            guna2ButtonDeposit.Click += guna2ButtonDeposit_Click;
            // 
            // Balance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 374);
            Controls.Add(guna2ButtonDeposit);
            Controls.Add(labelBalance);
            Controls.Add(label1);
            Controls.Add(labelBack);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Balance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balance";
            Load += Balance_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label labelBack;
        private Label label1;
        public Label labelBalance;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeposit;
    }
}