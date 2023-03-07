

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
namespace RegistrationApp
{
    public class RegForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ckBoxSwim;
        private System.Windows.Forms.CheckBox ckBoxSnorkel;
        private System.Windows.Forms.CheckBox ckBoxDive;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.RadioButton radAdvanc;
        private System.Windows.Forms.RadioButton radInterm;
        private System.Windows.Forms.RadioButton radBeginner;
        private System.ComponentModel.Container components = null;

        public RegForm()
        {
            InitializeComponent();
        }
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }
        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ckBoxSwim = new System.Windows.Forms.CheckBox();
            this.ckBoxSnorkel = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckBoxDive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdvanc = new System.Windows.Forms.RadioButton();
            this.radInterm = new System.Windows.Forms.RadioButton();
            this.radBeginner = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check all that apply";
            // 
            // ckBoxSwim
            // 
            this.ckBoxSwim.Location = new System.Drawing.Point(32, 88);
            this.ckBoxSwim.Name = "ckBoxSwim";
            this.ckBoxSwim.Size = new System.Drawing.Size(112, 24);
            this.ckBoxSwim.TabIndex = 1;
            this.ckBoxSwim.Text = "Swim - $50";
            this.ckBoxSwim.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // ckBoxSnorkel
            // 
            this.ckBoxSnorkel.Location = new System.Drawing.Point(32, 116);
            this.ckBoxSnorkel.Name = "ckBoxSnorkel";
            this.ckBoxSnorkel.Size = new System.Drawing.Size(128, 24);
            this.ckBoxSnorkel.TabIndex = 2;
            this.ckBoxSnorkel.Text = "Snorkel - $25";
            this.ckBoxSnorkel.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select lesson ";
            // 
            // ckBoxDive
            // 
            this.ckBoxDive.Location = new System.Drawing.Point(32, 144);
            this.ckBoxDive.Name = "ckBoxDive";
            this.ckBoxDive.Size = new System.Drawing.Size(112, 24);
            this.ckBoxDive.TabIndex = 4;
            this.ckBoxDive.Text = "Dive - $100";
            this.ckBoxDive.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 27);
            this.textBox1.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(32, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 23);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Total:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(96, 216);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(80, 27);
            this.txtResult.TabIndex = 8;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAdvanc);
            this.groupBox1.Controls.Add(this.radInterm);
            this.groupBox1.Controls.Add(this.radBeginner);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(208, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill level";
            // 
            // radAdvanc
            // 
            this.radAdvanc.Location = new System.Drawing.Point(16, 88);
            this.radAdvanc.Name = "radAdvanc";
            this.radAdvanc.Size = new System.Drawing.Size(136, 24);
            this.radAdvanc.TabIndex = 2;
            this.radAdvanc.Text = "Advanced";
            this.radAdvanc.Click += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radInterm
            // 
            this.radInterm.Checked = true;
            this.radInterm.Location = new System.Drawing.Point(16, 56);
            this.radInterm.Name = "radInterm";
            this.radInterm.Size = new System.Drawing.Size(136, 24);
            this.radInterm.TabIndex = 1;
            this.radInterm.TabStop = true;
            this.radInterm.Text = "Intermediate";
            this.radInterm.Click += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radBeginner
            // 
            this.radBeginner.Location = new System.Drawing.Point(16, 24);
            this.radBeginner.Name = "radBeginner";
            this.radBeginner.Size = new System.Drawing.Size(136, 24);
            this.radBeginner.TabIndex = 0;
            this.radBeginner.Text = "Beginner";
            this.radBeginner.Click += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblMsg.Location = new System.Drawing.Point(192, 224);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(192, 24);
            this.lblMsg.TabIndex = 10;
            // 
            // RegForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 20);
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(392, 273);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckBoxDive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckBoxSnorkel);
            this.Controls.Add(this.ckBoxSwim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        static void Main(   ) 
        {
            Application.Run(new RegForm());
        }

        private void ComputeCost_CheckedChanged
            (object sender, System.EventArgs e)
        {
            decimal cost = 0;
            this.lblMsg.Text = "  ";
            if (this.ckBoxSwim.Checked)
            {
                cost += 50;
            }
            if (this.ckBoxSnorkel.Checked)
            {
                cost += 25;
            }
            if (this.ckBoxDive.Checked)
            {
                cost += 100;
            }
            if(this.radBeginner.Checked)
            {
                cost +=10;
                this.lblMsg.Text = "Beginner -- Extra $10 charge";
            }
            else
                if(this.radAdvanc.Checked)
            {
                cost -=15;
                this.lblMsg.Text = "Advanced -- Discount $15";
            }
            else
            {
                this.lblMsg.Text = "  ";
            }
            this.txtResult.Text = cost.ToString("C");
        }
    }
}