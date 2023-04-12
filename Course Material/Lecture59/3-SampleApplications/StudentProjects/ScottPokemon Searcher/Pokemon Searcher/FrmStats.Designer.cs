namespace WindowsFormsApplication1
{
    partial class FrmStats
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
            this.components = new System.ComponentModel.Container();
            this.BtnSet = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TimSpeed = new System.Windows.Forms.Timer(this.components);
            this.RdoAtk = new System.Windows.Forms.RadioButton();
            this.RdoDef = new System.Windows.Forms.RadioButton();
            this.RdoSpd = new System.Windows.Forms.RadioButton();
            this.TimAttack = new System.Windows.Forms.Timer(this.components);
            this.TimDefence = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new WindowsFormsApplication1.DoubleBufferPanel();
            this.SuspendLayout();
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(12, 362);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(73, 24);
            this.BtnSet.TabIndex = 1;
            this.BtnSet.Text = "Set Team";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(12, 392);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TimSpeed
            // 
            this.TimSpeed.Interval = 50;
            this.TimSpeed.Tick += new System.EventHandler(this.TimRun_Tick);
            // 
            // RdoAtk
            // 
            this.RdoAtk.AutoSize = true;
            this.RdoAtk.Checked = true;
            this.RdoAtk.Location = new System.Drawing.Point(694, 365);
            this.RdoAtk.Name = "RdoAtk";
            this.RdoAtk.Size = new System.Drawing.Size(56, 17);
            this.RdoAtk.TabIndex = 3;
            this.RdoAtk.TabStop = true;
            this.RdoAtk.Text = "Attack";
            this.RdoAtk.UseVisualStyleBackColor = true;
            this.RdoAtk.CheckedChanged += new System.EventHandler(this.RdoAtk_CheckedChanged);
            // 
            // RdoDef
            // 
            this.RdoDef.AutoSize = true;
            this.RdoDef.Location = new System.Drawing.Point(694, 388);
            this.RdoDef.Name = "RdoDef";
            this.RdoDef.Size = new System.Drawing.Size(66, 17);
            this.RdoDef.TabIndex = 4;
            this.RdoDef.Text = "Defence";
            this.RdoDef.UseVisualStyleBackColor = true;
            this.RdoDef.CheckedChanged += new System.EventHandler(this.RdoDef_CheckedChanged);
            // 
            // RdoSpd
            // 
            this.RdoSpd.AutoSize = true;
            this.RdoSpd.Location = new System.Drawing.Point(694, 411);
            this.RdoSpd.Name = "RdoSpd";
            this.RdoSpd.Size = new System.Drawing.Size(56, 17);
            this.RdoSpd.TabIndex = 5;
            this.RdoSpd.Text = "Speed";
            this.RdoSpd.UseVisualStyleBackColor = true;
            this.RdoSpd.CheckedChanged += new System.EventHandler(this.RdoSpd_CheckedChanged);
            // 
            // TimAttack
            // 
            this.TimAttack.Tick += new System.EventHandler(this.TimAttack_Tick);
            // 
            // TimDefence
            // 
            this.TimDefence.Interval = 50;
            this.TimDefence.Tick += new System.EventHandler(this.TimDefence_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlGame.Location = new System.Drawing.Point(12, 12);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(778, 344);
            this.PnlGame.TabIndex = 6;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // FrmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 431);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.RdoSpd);
            this.Controls.Add(this.RdoDef);
            this.Controls.Add(this.RdoAtk);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnSet);
            this.Name = "FrmStats";
            this.Text = "Stats Visualizer";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer TimSpeed;
        private System.Windows.Forms.RadioButton RdoAtk;
        private System.Windows.Forms.RadioButton RdoDef;
        private System.Windows.Forms.RadioButton RdoSpd;
        private System.Windows.Forms.Timer TimAttack;
        private System.Windows.Forms.Timer TimDefence;
        private DoubleBufferPanel PnlGame;
    }
}