using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Payment
{
    /// <summary>
    /// Customer form
    /// </summary>
    /// <remarks>
    /// Murach's C# by Joel Murach & Doug Lowe. 
    /// Chapter 10 Payment application. 
    /// (c) 2004 by Mike Murach & Associates, Inc. 
    /// www.murach.com
    /// </remarks>
    public class frmCustomer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSelectPayment;
		private System.Windows.Forms.Label lblPayment;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cboNames;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmCustomer()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
        // Downloaded from www.murach.com (Chapter 10 Payment application)
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboNames
            // 
            this.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNames.Location = new System.Drawing.Point(136, 16);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(200, 21);
            this.cboNames.TabIndex = 0;
            this.cboNames.SelectedIndexChanged += new System.EventHandler(this.DataChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment method:";
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Location = new System.Drawing.Point(232, 80);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(104, 23);
            this.btnSelectPayment.TabIndex = 3;
            this.btnSelectPayment.Text = "Select Payment";
            this.btnSelectPayment.Click += new System.EventHandler(this.btnSelectPayment_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Location = new System.Drawing.Point(16, 80);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(200, 80);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(168, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(256, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(352, 222);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNames);
            this.Name = "frmCustomer";
            this.Tag = "The Customer form in C# from www.murach.com";
            this.Text = "Customer";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmCustomer_Closing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmCustomer());
		}

		bool isDataSaved = true;

		private void frmCustomer_Load(object sender, System.EventArgs e)
		{
			cboNames.Items.Add("Mike Smith");
			cboNames.Items.Add("Nancy Jones");
		}

		private void DataChanged(object sender, System.EventArgs e)
		{
			isDataSaved = false;
		}

		private void btnSelectPayment_Click(object sender, System.EventArgs e)
		{
			Form paymentForm = new frmPayment();
			DialogResult button = paymentForm.ShowDialog();
			if (button == DialogResult.OK)
				lblPayment.Text = paymentForm.Tag.ToString();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (IsValidData())
				SaveData();
		}

		private void SaveData()
		{
			cboNames.SelectedIndex = -1;
			lblPayment.Text = "";
			isDataSaved = true;
			cboNames.Focus();
		}

		private bool IsValidData()
		{
			if (cboNames.SelectedIndex == -1)
			{
				MessageBox.Show("You must select a customer.", "Entry Error");
				cboNames.Focus();
				return false;
			}
			if (lblPayment.Text == "")
			{
				MessageBox.Show("You must enter a payment.", "Entry Error");
				return false;
			}
			return true;
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void frmCustomer_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (isDataSaved == false)
			{
				string message = 
					"This form contains unsaved data.\n\n" +
					"Do you want to save it?";

				DialogResult button =  
					MessageBox.Show(message, "Customer", 
					MessageBoxButtons.YesNoCancel, 
					MessageBoxIcon.Warning);

				if (button == DialogResult.Yes)
				{
					if (IsValidData())
						this.SaveData();
					else
						e.Cancel = true;
				}
				if (button == DialogResult.Cancel)
					e.Cancel = true;
			}
		}

	}
}
