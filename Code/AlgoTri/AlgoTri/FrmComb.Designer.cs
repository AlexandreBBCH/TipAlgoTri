namespace AlgoTri
{
    partial class FrmComb
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
            btnStartSort = new Button();
            txbComb = new TextBox();
            rbStepByStep = new RadioButton();
            rbVerySlow = new RadioButton();
            rbSlow = new RadioButton();
            rbNormal = new RadioButton();
            rbFast = new RadioButton();
            gbSpeedAnimation = new GroupBox();
            gbSpeedAnimation.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartSort
            // 
            btnStartSort.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartSort.Location = new Point(422, 373);
            btnStartSort.Name = "btnStartSort";
            btnStartSort.Size = new Size(279, 46);
            btnStartSort.TabIndex = 0;
            btnStartSort.Text = "Trie";
            btnStartSort.UseVisualStyleBackColor = true;
            btnStartSort.Click += btnStartSort_Click;
            // 
            // txbComb
            // 
            txbComb.Location = new Point(236, 80);
            txbComb.Multiline = true;
            txbComb.Name = "txbComb";
            txbComb.Size = new Size(672, 249);
            txbComb.TabIndex = 1;
            // 
            // rbStepByStep
            // 
            rbStepByStep.AutoSize = true;
            rbStepByStep.Checked = true;
            rbStepByStep.Location = new Point(6, 22);
            rbStepByStep.Name = "rbStepByStep";
            rbStepByStep.Size = new Size(73, 19);
            rbStepByStep.TabIndex = 2;
            rbStepByStep.TabStop = true;
            rbStepByStep.Text = "Pas à pas";
            rbStepByStep.UseVisualStyleBackColor = true;
            // 
            // rbVerySlow
            // 
            rbVerySlow.AutoSize = true;
            rbVerySlow.Location = new Point(6, 47);
            rbVerySlow.Name = "rbVerySlow";
            rbVerySlow.Size = new Size(68, 19);
            rbVerySlow.TabIndex = 3;
            rbVerySlow.Text = "Très lent";
            rbVerySlow.UseVisualStyleBackColor = true;
            // 
            // rbSlow
            // 
            rbSlow.AutoSize = true;
            rbSlow.Location = new Point(6, 72);
            rbSlow.Name = "rbSlow";
            rbSlow.Size = new Size(48, 19);
            rbSlow.TabIndex = 4;
            rbSlow.Text = "Lent";
            rbSlow.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(6, 97);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(65, 19);
            rbNormal.TabIndex = 5;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbFast
            // 
            rbFast.AutoSize = true;
            rbFast.Location = new Point(6, 122);
            rbFast.Name = "rbFast";
            rbFast.Size = new Size(61, 19);
            rbFast.TabIndex = 6;
            rbFast.Text = "Rapide";
            rbFast.UseVisualStyleBackColor = true;
            // 
            // gbSpeedAnimation
            // 
            gbSpeedAnimation.Controls.Add(rbStepByStep);
            gbSpeedAnimation.Controls.Add(rbFast);
            gbSpeedAnimation.Controls.Add(rbVerySlow);
            gbSpeedAnimation.Controls.Add(rbNormal);
            gbSpeedAnimation.Controls.Add(rbSlow);
            gbSpeedAnimation.Location = new Point(12, 133);
            gbSpeedAnimation.Name = "gbSpeedAnimation";
            gbSpeedAnimation.Size = new Size(193, 154);
            gbSpeedAnimation.TabIndex = 7;
            gbSpeedAnimation.TabStop = false;
            gbSpeedAnimation.Text = "Vitesse d'éxécution";
            // 
            // FrmComb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 450);
            Controls.Add(gbSpeedAnimation);
            Controls.Add(txbComb);
            Controls.Add(btnStartSort);
            Name = "FrmComb";
            Text = "FrmComb";
            gbSpeedAnimation.ResumeLayout(false);
            gbSpeedAnimation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartSort;
        private TextBox txbComb;
        private RadioButton rbStepByStep;
        private RadioButton rbVerySlow;
        private RadioButton rbSlow;
        private RadioButton rbNormal;
        private RadioButton rbFast;
        private GroupBox gbSpeedAnimation;
    }
}