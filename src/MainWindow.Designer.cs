namespace DaneeCalculator
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Number0 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.Equals = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Problem = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Number0
            // 
            this.Number0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number0.Location = new System.Drawing.Point(45, 262);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(207, 50);
            this.Number0.TabIndex = 0;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.button_click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Result.Location = new System.Drawing.Point(289, 40);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(103, 34);
            this.Result.TabIndex = 14;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Equals
            // 
            this.Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Equals.Location = new System.Drawing.Point(329, 206);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(65, 106);
            this.Equals.TabIndex = 15;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Plus.Location = new System.Drawing.Point(258, 262);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(65, 50);
            this.Plus.TabIndex = 17;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.operator_click);
            // 
            // Number3
            // 
            this.Number3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number3.Location = new System.Drawing.Point(187, 206);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(65, 50);
            this.Number3.TabIndex = 20;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.button_click);
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number2.Location = new System.Drawing.Point(116, 206);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(65, 50);
            this.Number2.TabIndex = 19;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.button_click);
            // 
            // Number1
            // 
            this.Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number1.Location = new System.Drawing.Point(45, 206);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(65, 50);
            this.Number1.TabIndex = 18;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.button_click);
            // 
            // Number6
            // 
            this.Number6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number6.Location = new System.Drawing.Point(187, 150);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(65, 50);
            this.Number6.TabIndex = 23;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.button_click);
            // 
            // Number5
            // 
            this.Number5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number5.Location = new System.Drawing.Point(116, 150);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(65, 50);
            this.Number5.TabIndex = 22;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.button_click);
            // 
            // Number4
            // 
            this.Number4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number4.Location = new System.Drawing.Point(45, 150);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(65, 50);
            this.Number4.TabIndex = 21;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.button_click);
            // 
            // Number9
            // 
            this.Number9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number9.Location = new System.Drawing.Point(187, 94);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(65, 50);
            this.Number9.TabIndex = 26;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.button_click);
            // 
            // Number8
            // 
            this.Number8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number8.Location = new System.Drawing.Point(116, 94);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(65, 50);
            this.Number8.TabIndex = 25;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.button_click);
            // 
            // Number7
            // 
            this.Number7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Number7.Location = new System.Drawing.Point(45, 94);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(65, 50);
            this.Number7.TabIndex = 24;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.button_click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Minus.Location = new System.Drawing.Point(258, 206);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(65, 50);
            this.Minus.TabIndex = 27;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.operator_click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Multiply.Location = new System.Drawing.Point(258, 150);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(65, 50);
            this.Multiply.TabIndex = 28;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.operator_click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Divide.Location = new System.Drawing.Point(258, 94);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(65, 50);
            this.Divide.TabIndex = 29;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.operator_click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Clear.Location = new System.Drawing.Point(329, 94);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(65, 106);
            this.Clear.TabIndex = 30;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Problem
            // 
            this.Problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Problem.Location = new System.Drawing.Point(45, 40);
            this.Problem.Name = "Problem";
            this.Problem.ReadOnly = true;
            this.Problem.Size = new System.Drawing.Size(226, 34);
            this.Problem.TabIndex = 31;
            this.Problem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 329);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "DaneeCalculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Equals;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox Problem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

