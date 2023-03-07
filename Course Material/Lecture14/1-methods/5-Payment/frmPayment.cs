using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Payment
{
    
    public class frmPayment : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rdoCreditCard;
		private System.Windows.Forms.RadioButton rdoBillCustomer;
		private System.Windows.Forms.ComboBox cboExpirationMonth;
		private System.Windows.Forms.ComboBox cboExpirationYear;
		private System.Windows.Forms.TextBox txtCardNumber;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox chkDefault;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lstCreditCardType;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPayment()
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
				if (components != null) 
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this.cboExpirationYear = new System.Windows.Forms.ComboBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBillCustomer);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.Location = new System.Drawing.Point(154, 28);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(115, 27);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.Text = "Bill customer";
            this.rdoBillCustomer.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(19, 28);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(96, 27);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Credit card type:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(29, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Card number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expiration date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboExpirationMonth
            // 
            this.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationMonth.Location = new System.Drawing.Point(154, 240);
            this.cboExpirationMonth.Name = "cboExpirationMonth";
            this.cboExpirationMonth.Size = new System.Drawing.Size(96, 24);
            this.cboExpirationMonth.TabIndex = 2;
            // 
            // cboExpirationYear
            // 
            this.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationYear.Location = new System.Drawing.Point(269, 240);
            this.cboExpirationYear.Name = "cboExpirationYear";
            this.cboExpirationYear.Size = new System.Drawing.Size(86, 24);
            this.cboExpirationYear.TabIndex = 3;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(154, 203);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(201, 22);
            this.txtCardNumber.TabIndex = 1;
            this.txtCardNumber.Text = "1111390008727492";
            // 
            // chkDefault
            // 
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(29, 286);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(221, 28);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.Text = "Set as default billing method";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(163, 332);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 27);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(269, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.ItemHeight = 16;
            this.lstCreditCardType.Location = new System.Drawing.Point(154, 111);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(211, 68);
            this.lstCreditCardType.TabIndex = 0;
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(474, 394);
            this.ControlBox = false;
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.cboExpirationYear);
            this.Controls.Add(this.cboExpirationMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "The Payment form in C# ";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frmPayment_Load(object sender, System.EventArgs e)
		{
			lstCreditCardType.Items.Add("Visa");
			lstCreditCardType.Items.Add("Mastercard");
			lstCreditCardType.Items.Add("American Express");
			lstCreditCardType.SelectedIndex = 0;

			string[] months = {"Select a month...", 
								  "January", "February", "March", "April", 
								  "May", "June", "July", "August", 
								  "September", "October", "November", "December"};
			foreach (string month in months)
				cboExpirationMonth.Items.Add(month);
			cboExpirationMonth.SelectedIndex = 0;

			int year = DateTime.Today.Year;
			int endYear = year + 8;
			cboExpirationYear.Items.Add("Select a year...");
			while (year < endYear)
			{
				cboExpirationYear.Items.Add(year);
				year++;
			}
			cboExpirationYear.SelectedIndex = 0;
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (IsValidData())
			{
				string msg = null;
				if (rdoCreditCard.Checked == true)
				{
					msg += "Charge to credit card." + "\n";
					msg += "\n";
					msg += "Card type: " + lstCreditCardType.Text + "\n";
					msg += "Card number: " + txtCardNumber.Text + "\n";
					msg += "Expiration date: " 
						+ cboExpirationMonth.Text + "/" 
						+ cboExpirationYear.Text + "\n";
				}
				else
				{
					msg += "Send bill to customer." + "\n";
					msg += "\n";
				}

				bool isDefaultBilling = chkDefault.Checked;
				msg += "Default billing: " + isDefaultBilling;

				this.Tag = msg;
				this.DialogResult = DialogResult.OK;
			}
		}

		private bool IsValidData()
		{
			if (rdoCreditCard.Checked)
			{
				if (txtCardNumber.Text == "")
				{
					MessageBox.Show("You must enter a credit card number.", 
						"Entry Error");
					txtCardNumber.Focus();
					return false;
				}
				if (cboExpirationMonth.SelectedIndex == 0)
				{
					MessageBox.Show("You must select a month.", "Entry Error");
					cboExpirationMonth.Focus();
					return false;
				}
				if (cboExpirationYear.SelectedIndex == 0)
				{
					MessageBox.Show("You must select a year.", "Entry Error");
					cboExpirationYear.Focus();
					return false;
				}
			}
			return true;
		}

		private void Billing_CheckedChanged(object sender, System.EventArgs e)
		{
			if (rdoCreditCard.Checked)
				EnableControls();
			else
				DisableControls();		
		}

		private void EnableControls()
		{
			lstCreditCardType.Enabled = true;
			txtCardNumber.Enabled = true;
			cboExpirationMonth.Enabled = true;
			cboExpirationYear.Enabled = true;
		}

		private void DisableControls()
		{
			lstCreditCardType.Enabled = false;
			txtCardNumber.Enabled = false;
			cboExpirationMonth.Enabled = false;
			cboExpirationYear.Enabled = false;
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
