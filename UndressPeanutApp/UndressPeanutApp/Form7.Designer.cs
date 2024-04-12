namespace UndressPeanutApp
{
    partial class Form7
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
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.pnlAccessBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDashBoard.SuspendLayout();
            this.pnlAccessBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Settings";
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDashBoard.Controls.Add(this.lblDashBoard);
            this.pnlDashBoard.ForeColor = System.Drawing.Color.White;
            this.pnlDashBoard.Location = new System.Drawing.Point(38, 121);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(724, 57);
            this.pnlDashBoard.TabIndex = 2;
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.Location = new System.Drawing.Point(3, 12);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(324, 31);
            this.lblDashBoard.TabIndex = 0;
            this.lblDashBoard.Text = "Change DashBoard Color";
            // 
            // pnlAccessBox
            // 
            this.pnlAccessBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlAccessBox.Controls.Add(this.label1);
            this.pnlAccessBox.ForeColor = System.Drawing.Color.White;
            this.pnlAccessBox.Location = new System.Drawing.Point(38, 197);
            this.pnlAccessBox.Name = "pnlAccessBox";
            this.pnlAccessBox.Size = new System.Drawing.Size(724, 112);
            this.pnlAccessBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access box";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.pnlAccessBox);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.label2);
            this.Name = "Form7";
            this.Text = "Form7";
            this.pnlDashBoard.ResumeLayout(false);
            this.pnlDashBoard.PerformLayout();
            this.pnlAccessBox.ResumeLayout(false);
            this.pnlAccessBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Panel pnlAccessBox;
        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.Label label1;
    }
}