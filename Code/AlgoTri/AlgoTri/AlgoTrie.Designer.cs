namespace AlgoTri
{
    partial class AlgoTrie
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnComb = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(22, 229);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(282, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Selection";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(22, 130);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(282, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insertion";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(22, 177);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(282, 23);
            this.btnBubble.TabIndex = 2;
            this.btnBubble.Text = "Bulle";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnComb
            // 
            this.btnComb.Location = new System.Drawing.Point(22, 271);
            this.btnComb.Name = "btnComb";
            this.btnComb.Size = new System.Drawing.Size(282, 23);
            this.btnComb.TabIndex = 3;
            this.btnComb.Text = "Peigne";
            this.btnComb.UseVisualStyleBackColor = true;
            this.btnComb.Click += new System.EventHandler(this.btnComb_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(22, 314);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(282, 23);
            this.btnShell.TabIndex = 4;
            this.btnShell.Text = "Shell";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // AlgoTrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnComb);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnSelect);
            this.Name = "AlgoTrie";
            this.Text = "Selection de l\'algo";
            this.Load += new System.EventHandler(this.AlgoTrie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelect;
        private Button btnInsert;
        private Button btnBubble;
        private Button btnComb;
        private Button btnShell;
    }
}