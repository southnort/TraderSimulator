namespace TradingSimulator
{
    partial class Form1
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
            this.tradingButton = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tradingButton
            // 
            this.tradingButton.Location = new System.Drawing.Point(495, 182);
            this.tradingButton.Name = "tradingButton";
            this.tradingButton.Size = new System.Drawing.Size(144, 59);
            this.tradingButton.TabIndex = 0;
            this.tradingButton.Text = "Торговля";
            this.tradingButton.UseVisualStyleBackColor = true;
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(204, 182);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(144, 59);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "Инвентарь";
            this.inventoryButton.UseVisualStyleBackColor = true;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(717, 29);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(35, 13);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.inventoryButton);
            this.Controls.Add(this.tradingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tradingButton;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Label moneyLabel;
    }
}

