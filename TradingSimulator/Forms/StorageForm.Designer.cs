namespace TradingSimulator.Forms
{
    partial class StorageForm
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
            this.storagePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // storagePanel
            // 
            this.storagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storagePanel.AutoScroll = true;
            this.storagePanel.Location = new System.Drawing.Point(12, 12);
            this.storagePanel.Name = "storagePanel";
            this.storagePanel.Size = new System.Drawing.Size(960, 381);
            this.storagePanel.TabIndex = 0;
            this.storagePanel.Resize += new System.EventHandler(this.storagePanel_SizeChanged);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 481);
            this.Controls.Add(this.storagePanel);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel storagePanel;
    }
}