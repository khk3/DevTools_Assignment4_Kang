namespace KwonLab4
{
    partial class Form1
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFlightIncluded = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTripInformation = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTripInformation = new System.Windows.Forms.GroupBox();
            this.grpBook.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpTripInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCreditCard);
            this.grpBook.Controls.Add(this.groupBox3);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Location = new System.Drawing.Point(12, 12);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(209, 312);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // btnBook
            // 
            this.btnBook.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBook.Location = new System.Drawing.Point(128, 274);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 32);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(9, 274);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(87, 231);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(116, 24);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "label3";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(15, 199);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(72, 24);
            this.radCash.TabIndex = 3;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Location = new System.Drawing.Point(15, 174);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(127, 24);
            this.radCreditCard.TabIndex = 2;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.chkFlightIncluded);
            this.groupBox3.Controls.Add(this.radMexico);
            this.groupBox3.Controls.Add(this.radFlorida);
            this.groupBox3.Controls.Add(this.radCuba);
            this.groupBox3.Location = new System.Drawing.Point(9, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 123);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Location";
            // 
            // chkFlightIncluded
            // 
            this.chkFlightIncluded.AutoSize = true;
            this.chkFlightIncluded.Enabled = false;
            this.chkFlightIncluded.Location = new System.Drawing.Point(6, 97);
            this.chkFlightIncluded.Name = "chkFlightIncluded";
            this.chkFlightIncluded.Size = new System.Drawing.Size(154, 24);
            this.chkFlightIncluded.TabIndex = 3;
            this.chkFlightIncluded.Text = "Flight Included";
            this.chkFlightIncluded.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(6, 72);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(88, 24);
            this.radMexico.TabIndex = 2;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            this.radMexico.CheckedChanged += new System.EventHandler(this.radMexico_CheckedChanged);
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(6, 47);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(88, 24);
            this.radFlorida.TabIndex = 1;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            this.radFlorida.CheckedChanged += new System.EventHandler(this.radFlorida_CheckedChanged);
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(6, 22);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(74, 24);
            this.radCuba.TabIndex = 0;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(68, 16);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(100, 26);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "People:";
            // 
            // grpTripInformation
            // 
            this.grpTripInformation.Controls.Add(this.btnConfirm);
            this.grpTripInformation.Controls.Add(this.lblTripInformation);
            this.grpTripInformation.Location = new System.Drawing.Point(227, 12);
            this.grpTripInformation.Name = "grpTripInformation";
            this.grpTripInformation.Size = new System.Drawing.Size(255, 312);
            this.grpTripInformation.TabIndex = 1;
            this.grpTripInformation.TabStop = false;
            this.grpTripInformation.Text = "Trip Information";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(87, 274);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 32);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTripInformation
            // 
            this.lblTripInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTripInformation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripInformation.Location = new System.Drawing.Point(6, 22);
            this.lblTripInformation.Name = "lblTripInformation";
            this.lblTripInformation.Size = new System.Drawing.Size(243, 246);
            this.lblTripInformation.TabIndex = 1;
            this.lblTripInformation.TabStop = false;
            this.lblTripInformation.Text = "label4";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grpTripInformation);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Kang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpTripInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTripInformation;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFlightIncluded;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.GroupBox lblTripInformation;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
    }
}

