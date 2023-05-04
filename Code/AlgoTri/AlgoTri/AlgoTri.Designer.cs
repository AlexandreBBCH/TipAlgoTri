namespace AlgoTri
{
    partial class AlgoTri
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
            btnSelect = new Button();
            btnInsert = new Button();
            btnBubble = new Button();
            btnComb = new Button();
            btnShell = new Button();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(22, 229);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(282, 23);
            btnSelect.TabIndex = 3;
            btnSelect.Text = "Selection";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(22, 130);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(282, 23);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insertion";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnBubble
            // 
            btnBubble.Location = new Point(22, 177);
            btnBubble.Name = "btnBubble";
            btnBubble.Size = new Size(282, 23);
            btnBubble.TabIndex = 2;
            btnBubble.Text = "Bulle";
            btnBubble.UseVisualStyleBackColor = true;
            btnBubble.Click += btnBubble_Click;
            // 
            // btnComb
            // 
            btnComb.Location = new Point(22, 271);
            btnComb.Name = "btnComb";
            btnComb.Size = new Size(282, 23);
            btnComb.TabIndex = 4;
            btnComb.Text = "Peigne";
            btnComb.UseVisualStyleBackColor = true;
            btnComb.Click += btnComb_Click;
            // 
            // btnShell
            // 
            btnShell.Location = new Point(22, 314);
            btnShell.Name = "btnShell";
            btnShell.Size = new Size(282, 23);
            btnShell.TabIndex = 5;
            btnShell.Text = "Shell";
            btnShell.UseVisualStyleBackColor = true;
            btnShell.Click += btnShell_Click;
            // 
            // AlgoTri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 450);
            Controls.Add(btnShell);
            Controls.Add(btnComb);
            Controls.Add(btnBubble);
            Controls.Add(btnInsert);
            Controls.Add(btnSelect);
            Name = "AlgoTri";
            Text = "Selection de l'algo";
            Load += AlgoTrie_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private Button btnInsert;
        private Button btnBubble;
        private Button btnComb;
        private Button btnShell;
    }
}