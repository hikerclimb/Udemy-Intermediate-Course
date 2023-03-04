namespace MoreControls
{
    partial class FrmMoreControls
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
            txtNumber = new TextBox();
            hzscrollbar = new HScrollBar();
            menuStrip1 = new MenuStrip();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            yellowToolStripMenuItem = new ToolStripMenuItem();
            btnGoTo = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(506, 364);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(125, 27);
            txtNumber.TabIndex = 0;
            // 
            // hzscrollbar
            // 
            hzscrollbar.LargeChange = 1;
            hzscrollbar.Location = new Point(166, 365);
            hzscrollbar.Maximum = 50;
            hzscrollbar.Name = "hzscrollbar";
            hzscrollbar.Size = new Size(150, 26);
            hzscrollbar.TabIndex = 1;
            hzscrollbar.Scroll += hzscrollbar_Scroll;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { colorsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redToolStripMenuItem, blueToolStripMenuItem, yellowToolStripMenuItem });
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.Size = new Size(65, 24);
            colorsToolStripMenuItem.Text = "Colors";
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(135, 26);
            redToolStripMenuItem.Text = "Red";
            redToolStripMenuItem.Click += redToolStripMenuItem_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(135, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // yellowToolStripMenuItem
            // 
            yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            yellowToolStripMenuItem.Size = new Size(135, 26);
            yellowToolStripMenuItem.Text = "Yellow";
            yellowToolStripMenuItem.Click += yellowToolStripMenuItem_Click;
            // 
            // btnGoTo
            // 
            btnGoTo.Location = new Point(307, 169);
            btnGoTo.Name = "btnGoTo";
            btnGoTo.Size = new Size(94, 29);
            btnGoTo.TabIndex = 3;
            btnGoTo.Text = "Go To 2nd Form";
            btnGoTo.UseVisualStyleBackColor = true;
            btnGoTo.Click += btnGoTo_Click;
            // 
            // FrmMoreControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoTo);
            Controls.Add(hzscrollbar);
            Controls.Add(txtNumber);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMoreControls";
            Text = "MoreControls";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private HScrollBar hzscrollbar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem;
        private Button btnGoTo;
    }
}