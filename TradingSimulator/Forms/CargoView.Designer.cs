namespace TradingSimulator.Forms
{
    partial class CargoView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemCountLabel = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.dropButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemNameLabel.Location = new System.Drawing.Point(8, 0);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(72, 17);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Название";
            // 
            // itemCountLabel
            // 
            this.itemCountLabel.AutoSize = true;
            this.itemCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemCountLabel.Location = new System.Drawing.Point(14, 73);
            this.itemCountLabel.Name = "itemCountLabel";
            this.itemCountLabel.Size = new System.Drawing.Size(42, 17);
            this.itemCountLabel.TabIndex = 1;
            this.itemCountLabel.Text = "x 400";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(11, 20);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(115, 23);
            this.sellButton.TabIndex = 2;
            this.sellButton.Text = "Продать";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // dropButton
            // 
            this.dropButton.Location = new System.Drawing.Point(11, 47);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(115, 23);
            this.dropButton.TabIndex = 3;
            this.dropButton.Text = "Выкинуть";
            this.dropButton.UseVisualStyleBackColor = true;
            // 
            // CargoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.itemCountLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Name = "CargoView";
            this.Size = new System.Drawing.Size(140, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label itemCountLabel;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button dropButton;
    }
}
