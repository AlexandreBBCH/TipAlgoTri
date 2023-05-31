namespace AlgoTri
{
    partial class FrmShell
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
            components = new System.ComponentModel.Container();
            rbStepByStep = new RadioButton();
            rbFast = new RadioButton();
            rbVerySlow = new RadioButton();
            rbNormal = new RadioButton();
            rbSlow = new RadioButton();
            gbSpeedAnimation = new GroupBox();
            buttonStartSort = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelResultat = new Panel();
            txbPseudoCode = new TextBox();
            btnStop = new Button();
            btnContinuer = new Button();
            gbSpeedAnimation.SuspendLayout();
            SuspendLayout();
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
            // gbSpeedAnimation
            // 
            gbSpeedAnimation.Controls.Add(rbStepByStep);
            gbSpeedAnimation.Controls.Add(rbFast);
            gbSpeedAnimation.Controls.Add(rbVerySlow);
            gbSpeedAnimation.Controls.Add(rbNormal);
            gbSpeedAnimation.Controls.Add(rbSlow);
            gbSpeedAnimation.Location = new Point(12, 139);
            gbSpeedAnimation.Name = "gbSpeedAnimation";
            gbSpeedAnimation.Size = new Size(193, 154);
            gbSpeedAnimation.TabIndex = 10;
            gbSpeedAnimation.TabStop = false;
            gbSpeedAnimation.Text = "Vitesse d'éxécution";
            // 
            // buttonStartSort
            // 
            buttonStartSort.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStartSort.Location = new Point(12, 299);
            buttonStartSort.Name = "buttonStartSort";
            buttonStartSort.Size = new Size(193, 46);
            buttonStartSort.TabIndex = 13;
            buttonStartSort.Text = "Trie";
            buttonStartSort.UseVisualStyleBackColor = true;
            buttonStartSort.Click += buttonStartSort_Click;
            // 
            // panelResultat
            // 
            panelResultat.Location = new Point(211, 12);
            panelResultat.Name = "panelResultat";
            panelResultat.Size = new Size(830, 361);
            panelResultat.TabIndex = 14;
            // 
            // txbPseudoCode
            // 
            txbPseudoCode.Location = new Point(1057, 12);
            txbPseudoCode.Multiline = true;
            txbPseudoCode.Name = "txbPseudoCode";
            txbPseudoCode.Size = new Size(300, 200);
            txbPseudoCode.TabIndex = 22;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(527, 392);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(92, 46);
            btnStop.TabIndex = 23;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnContinuer
            // 
            btnContinuer.Location = new Point(625, 392);
            btnContinuer.Name = "btnContinuer";
            btnContinuer.Size = new Size(92, 46);
            btnContinuer.TabIndex = 21;
            btnContinuer.Text = "Continuer";
            btnContinuer.UseVisualStyleBackColor = true;
            btnContinuer.Click += btnContinuer_Click;
            // 
            // FrmShell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 450);
            Controls.Add(btnContinuer);
            Controls.Add(btnStop);
            Controls.Add(txbPseudoCode);
            Controls.Add(panelResultat);
            Controls.Add(buttonStartSort);
            Controls.Add(gbSpeedAnimation);
            Name = "FrmShell";
            Text = "FrmShell";
            gbSpeedAnimation.ResumeLayout(false);
            gbSpeedAnimation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbStepByStep;
        private RadioButton rbFast;
        private RadioButton rbVerySlow;
        private RadioButton rbNormal;
        private RadioButton rbSlow;
        private GroupBox gbSpeedAnimation;
        private Button buttonStartSort;
        private System.Windows.Forms.Timer timer1;
        private Panel panelResultat;
        private TextBox txbPseudoCode;
        private Button btnStop;
        private Button btnContinuer;
    }
}
