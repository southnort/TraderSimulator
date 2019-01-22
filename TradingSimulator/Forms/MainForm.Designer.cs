namespace TradingSimulator.Forms
{
    partial class MainForm
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
            this.categoryButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.tradingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(12, 12);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(75, 23);
            this.categoryButton.TabIndex = 0;
            this.categoryButton.Text = "Категории";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.Location = new System.Drawing.Point(12, 41);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(75, 23);
            this.itemsButton.TabIndex = 1;
            this.itemsButton.Text = "Предметы";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.moneyLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moneyLabel.Location = new System.Drawing.Point(691, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.moneyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.moneyLabel.Size = new System.Drawing.Size(109, 29);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "MONEY TEXT";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tradingButton
            // 
            this.tradingButton.Location = new System.Drawing.Point(155, 169);
            this.tradingButton.Name = "tradingButton";
            this.tradingButton.Size = new System.Drawing.Size(109, 58);
            this.tradingButton.TabIndex = 3;
            this.tradingButton.Text = "Торговля";
            this.tradingButton.UseVisualStyleBackColor = true;
            this.tradingButton.Click += new System.EventHandler(this.tradingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tradingButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.itemsButton);
            this.Controls.Add(this.categoryButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button tradingButton;
    }
}