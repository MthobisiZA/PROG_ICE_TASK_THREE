
namespace PROG_ICE_TASK_THREE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPriorities = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.ListBox();
            this.dtpDateCreation = new System.Windows.Forms.DateTimePicker();
            this.txbPriorities = new System.Windows.Forms.TextBox();
            this.listViewName = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(72, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Your Name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(72, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date of Creation:";
            // 
            // lblPriorities
            // 
            this.lblPriorities.AutoSize = true;
            this.lblPriorities.Location = new System.Drawing.Point(72, 144);
            this.lblPriorities.Name = "lblPriorities";
            this.lblPriorities.Size = new System.Drawing.Size(56, 15);
            this.lblPriorities.TabIndex = 2;
            this.lblPriorities.Text = "Priorities:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(72, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(226, 23);
            this.txbName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(72, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(226, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbName
            // 
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 15;
            this.lbName.Location = new System.Drawing.Point(359, 52);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(153, 259);
            this.lbName.TabIndex = 6;
            // 
            // dtpDateCreation
            // 
            this.dtpDateCreation.Location = new System.Drawing.Point(72, 101);
            this.dtpDateCreation.Name = "dtpDateCreation";
            this.dtpDateCreation.Size = new System.Drawing.Size(226, 23);
            this.dtpDateCreation.TabIndex = 9;
            // 
            // txbPriorities
            // 
            this.txbPriorities.Location = new System.Drawing.Point(72, 171);
            this.txbPriorities.Multiline = true;
            this.txbPriorities.Name = "txbPriorities";
            this.txbPriorities.Size = new System.Drawing.Size(226, 99);
            this.txbPriorities.TabIndex = 10;
            // 
            // listViewName
            // 
            this.listViewName.HideSelection = false;
            this.listViewName.Location = new System.Drawing.Point(542, 52);
            this.listViewName.Name = "listViewName";
            this.listViewName.Size = new System.Drawing.Size(227, 259);
            this.listViewName.TabIndex = 7;
            this.listViewName.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.txbPriorities);
            this.Controls.Add(this.dtpDateCreation);
            this.Controls.Add(this.listViewName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblPriorities);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TODO ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPriorities;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.DateTimePicker dtpDateCreation;
        private System.Windows.Forms.TextBox txbPriorities;
        private System.Windows.Forms.ListView listViewName;
    }
}

