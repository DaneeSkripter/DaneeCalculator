namespace DaneeCalculator
{
    partial class UpdateOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOld));
            this.Text = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Text.Location = new System.Drawing.Point(63, 40);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(268, 18);
            this.Text.TabIndex = 0;
            this.Text.Text = "Outdated version. Please update below.";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(104, 71);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(170, 23);
            this.Update.TabIndex = 1;
            this.Update.Text = "Download latest version";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UpdateOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 116);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateOld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Button Update;
    }
}