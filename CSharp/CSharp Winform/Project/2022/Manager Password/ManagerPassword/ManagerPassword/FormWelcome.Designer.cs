namespace ManagerPassword
{
    partial class FormWelcome
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
            this.label7 = new System.Windows.Forms.Label();
            this.cbbSelecter = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Chọn Form";
            // 
            // cbbSelecter
            // 
            this.cbbSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSelecter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbbSelecter.Font = new System.Drawing.Font("Arial", 10.2F);
            this.cbbSelecter.FormattingEnabled = true;
            this.cbbSelecter.Items.AddRange(new object[] {
            "Bookmark",
            "Passwords"});
            this.cbbSelecter.Location = new System.Drawing.Point(16, 42);
            this.cbbSelecter.MaxDropDownItems = 5;
            this.cbbSelecter.Name = "cbbSelecter";
            this.cbbSelecter.Size = new System.Drawing.Size(387, 27);
            this.cbbSelecter.Sorted = true;
            this.cbbSelecter.TabIndex = 21;
            this.cbbSelecter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbbSelecter_KeyDown);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(16, 114);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(387, 36);
            this.btnOpen.TabIndex = 22;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 162);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cbbSelecter);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWelcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.ComboBox cbbSelecter;
        private System.Windows.Forms.Button btnOpen;
    }
}