namespace KeyboardRemapping
{
    partial class RemapForm
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
            this.listBoxFromKey = new System.Windows.Forms.ListBox();
            this.listBoxToKey = new System.Windows.Forms.ListBox();
            this.btnWriteToRegistry = new System.Windows.Forms.Button();
            this.labelFromKey = new System.Windows.Forms.Label();
            this.labelToKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFromKey
            // 
            this.listBoxFromKey.FormattingEnabled = true;
            this.listBoxFromKey.ItemHeight = 16;
            this.listBoxFromKey.Location = new System.Drawing.Point(29, 37);
            this.listBoxFromKey.Name = "listBoxFromKey";
            this.listBoxFromKey.Size = new System.Drawing.Size(297, 340);
            this.listBoxFromKey.TabIndex = 2;
            this.listBoxFromKey.SelectedIndexChanged += new System.EventHandler(this.listBoxFromKey_SelectedIndexChanged);
            // 
            // listBoxToKey
            // 
            this.listBoxToKey.FormattingEnabled = true;
            this.listBoxToKey.ItemHeight = 16;
            this.listBoxToKey.Location = new System.Drawing.Point(364, 37);
            this.listBoxToKey.Name = "listBoxToKey";
            this.listBoxToKey.Size = new System.Drawing.Size(297, 340);
            this.listBoxToKey.TabIndex = 4;
            this.listBoxToKey.SelectedIndexChanged += new System.EventHandler(this.listBoxToKey_SelectedIndexChanged);
            // 
            // btnWriteToRegistry
            // 
            this.btnWriteToRegistry.Location = new System.Drawing.Point(262, 429);
            this.btnWriteToRegistry.Name = "btnWriteToRegistry";
            this.btnWriteToRegistry.Size = new System.Drawing.Size(158, 34);
            this.btnWriteToRegistry.TabIndex = 7;
            this.btnWriteToRegistry.Text = "Write to Registry";
            this.btnWriteToRegistry.UseVisualStyleBackColor = true;
            this.btnWriteToRegistry.Click += new System.EventHandler(this.btnWriteToRegistry_Click);
            // 
            // labelFromKey
            // 
            this.labelFromKey.AutoSize = true;
            this.labelFromKey.Location = new System.Drawing.Point(26, 18);
            this.labelFromKey.Name = "labelFromKey";
            this.labelFromKey.Size = new System.Drawing.Size(152, 16);
            this.labelFromKey.TabIndex = 8;
            this.labelFromKey.Text = "Map this key (From key):";
            this.labelFromKey.Click += new System.EventHandler(this.labelFromKey_Click);
            // 
            // labelToKey
            // 
            this.labelToKey.AutoSize = true;
            this.labelToKey.Location = new System.Drawing.Point(361, 18);
            this.labelToKey.Name = "labelToKey";
            this.labelToKey.Size = new System.Drawing.Size(129, 16);
            this.labelToKey.TabIndex = 9;
            this.labelToKey.Text = "To this key (To Key):";
            this.labelToKey.Click += new System.EventHandler(this.labelToKey_Click);
            // 
            // RemapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 492);
            this.Controls.Add(this.labelToKey);
            this.Controls.Add(this.labelFromKey);
            this.Controls.Add(this.btnWriteToRegistry);
            this.Controls.Add(this.listBoxToKey);
            this.Controls.Add(this.listBoxFromKey);
            this.Name = "RemapForm";
            this.Text = "Key Remapping Utility";
            this.Load += new System.EventHandler(this.RemapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxFromKey;
        private System.Windows.Forms.ListBox listBoxToKey;
        private System.Windows.Forms.Button btnWriteToRegistry;
        private System.Windows.Forms.Label labelFromKey;
        private System.Windows.Forms.Label labelToKey;
    }
}

