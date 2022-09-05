namespace MordorLauncher
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.AddToAutoStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(218, 12);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(138, 52);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Обновить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(12, 12);
            this.IPBox.Name = "IPBox";
            this.IPBox.PlaceholderText = "IP компа TOPa";
            this.IPBox.Size = new System.Drawing.Size(200, 23);
            this.IPBox.TabIndex = 1;
            // 
            // AddToAutoStart
            // 
            this.AddToAutoStart.AutoSize = true;
            this.AddToAutoStart.Location = new System.Drawing.Point(12, 44);
            this.AddToAutoStart.Name = "AddToAutoStart";
            this.AddToAutoStart.Size = new System.Drawing.Size(200, 20);
            this.AddToAutoStart.TabIndex = 2;
            this.AddToAutoStart.Text = "Добавить в планировщик задач";
            this.AddToAutoStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 72);
            this.Controls.Add(this.AddToAutoStart);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.UpdateBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button UpdateBtn;
        private TextBox IPBox;
        private CheckBox AddToAutoStart;
    }
}