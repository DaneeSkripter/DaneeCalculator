namespace DaneeCalculator
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.about_label = new System.Windows.Forms.Label();
            this.aboutlabel2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // about_label
            // 
            this.about_label.AutoSize = true;
            this.about_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.about_label.Location = new System.Drawing.Point(81, 34);
            this.about_label.Name = "about_label";
            this.about_label.Size = new System.Drawing.Size(183, 16);
            this.about_label.TabIndex = 0;
            this.about_label.Text = "Developed by DaneeSkripter";
            // 
            // aboutlabel2
            // 
            this.aboutlabel2.AutoSize = true;
            this.aboutlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutlabel2.Location = new System.Drawing.Point(120, 59);
            this.aboutlabel2.Name = "aboutlabel2";
            this.aboutlabel2.Size = new System.Drawing.Size(86, 16);
            this.aboutlabel2.TabIndex = 1;
            this.aboutlabel2.Text = "Version: 1.0.0";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(56, 97);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 2;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check for updates";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.aboutlabel2);
            this.Controls.Add(this.about_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label about_label;
        private System.Windows.Forms.Label aboutlabel2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button1;
    }
}