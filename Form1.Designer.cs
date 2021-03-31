
namespace Event_Planner
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
            this.checkout = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.registorPage = new System.Windows.Forms.TabPage();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guestNumber = new System.Windows.Forms.NumericUpDown();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.noButton = new System.Windows.Forms.RadioButton();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.occasionBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkoutPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelcost = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkout.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.registorPage.SuspendLayout();
            this.submitButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestNumber)).BeginInit();
            this.checkoutPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkout
            // 
            this.checkout.Controls.Add(this.tabPage1);
            this.checkout.Controls.Add(this.registorPage);
            this.checkout.Controls.Add(this.submitButton);
            this.checkout.Controls.Add(this.checkoutPage);
            this.checkout.Location = new System.Drawing.Point(3, -1);
            this.checkout.Name = "checkout";
            this.checkout.SelectedIndex = 0;
            this.checkout.Size = new System.Drawing.Size(1206, 539);
            this.checkout.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1198, 506);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to elle event planner";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // registorPage
            // 
            this.registorPage.BackColor = System.Drawing.Color.RosyBrown;
            this.registorPage.Controls.Add(this.phoneTextBox);
            this.registorPage.Controls.Add(this.label12);
            this.registorPage.Controls.Add(this.emailTextBox);
            this.registorPage.Controls.Add(this.lastName);
            this.registorPage.Controls.Add(this.firstName);
            this.registorPage.Controls.Add(this.label5);
            this.registorPage.Controls.Add(this.label4);
            this.registorPage.Controls.Add(this.label3);
            this.registorPage.Controls.Add(this.label2);
            this.registorPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registorPage.Location = new System.Drawing.Point(4, 29);
            this.registorPage.Name = "registorPage";
            this.registorPage.Padding = new System.Windows.Forms.Padding(3);
            this.registorPage.Size = new System.Drawing.Size(1198, 506);
            this.registorPage.TabIndex = 0;
            this.registorPage.Text = "Register";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(458, 333);
            this.phoneTextBox.Mask = "(999) 000-0000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(208, 30);
            this.phoneTextBox.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(68, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(307, 43);
            this.label12.TabIndex = 9;
            this.label12.Text = "Let`s get started...";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(458, 273);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(180, 30);
            this.emailTextBox.TabIndex = 6;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(458, 208);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(180, 30);
            this.lastName.TabIndex = 5;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(458, 135);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(180, 30);
            this.firstName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.RosyBrown;
            this.submitButton.Controls.Add(this.button2);
            this.submitButton.Controls.Add(this.zipcodeTextBox);
            this.submitButton.Controls.Add(this.label21);
            this.submitButton.Controls.Add(this.stateTextBox);
            this.submitButton.Controls.Add(this.label20);
            this.submitButton.Controls.Add(this.cityTextBox);
            this.submitButton.Controls.Add(this.label17);
            this.submitButton.Controls.Add(this.streetTextBox);
            this.submitButton.Controls.Add(this.label16);
            this.submitButton.Controls.Add(this.messageBox);
            this.submitButton.Controls.Add(this.label11);
            this.submitButton.Controls.Add(this.label9);
            this.submitButton.Controls.Add(this.guestNumber);
            this.submitButton.Controls.Add(this.datePicker);
            this.submitButton.Controls.Add(this.noButton);
            this.submitButton.Controls.Add(this.yesButton);
            this.submitButton.Controls.Add(this.occasionBox);
            this.submitButton.Controls.Add(this.label10);
            this.submitButton.Controls.Add(this.label8);
            this.submitButton.Controls.Add(this.label7);
            this.submitButton.Controls.Add(this.label6);
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(4, 29);
            this.submitButton.Name = "submitButton";
            this.submitButton.Padding = new System.Windows.Forms.Padding(3);
            this.submitButton.Size = new System.Drawing.Size(1198, 506);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Event detail";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 75);
            this.button2.TabIndex = 28;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.Location = new System.Drawing.Point(224, 253);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(100, 30);
            this.zipcodeTextBox.TabIndex = 27;
            this.zipcodeTextBox.TextChanged += new System.EventHandler(this.zipcodeTextBox_TextChanged_1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(132, 256);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 25);
            this.label21.TabIndex = 26;
            this.label21.Text = "Zipcode";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(433, 208);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(71, 30);
            this.stateTextBox.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(355, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 25);
            this.label20.TabIndex = 24;
            this.label20.Text = "State";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(224, 208);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 30);
            this.cityTextBox.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(167, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 25);
            this.label17.TabIndex = 22;
            this.label17.Text = "City";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(224, 165);
            this.streetTextBox.Multiline = true;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(213, 28);
            this.streetTextBox.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(128, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Address";
            // 
            // messageBox
            // 
            this.messageBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.messageBox.Location = new System.Drawing.Point(701, 82);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(480, 156);
            this.messageBox.TabIndex = 18;
            this.messageBox.Text = "Is there anything else you want us to know?";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged_1);
            this.messageBox.Enter += new System.EventHandler(this.messageBox_Enter_1);
            this.messageBox.Leave += new System.EventHandler(this.messageBox_Leave_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(829, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Message";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Event detail ";
            // 
            // guestNumber
            // 
            this.guestNumber.Location = new System.Drawing.Point(244, 332);
            this.guestNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.guestNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.guestNumber.Name = "guestNumber";
            this.guestNumber.Size = new System.Drawing.Size(120, 30);
            this.guestNumber.TabIndex = 15;
            this.guestNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(224, 296);
            this.datePicker.MaxDate = new System.DateTime(2022, 8, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2021, 3, 8, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(319, 30);
            this.datePicker.TabIndex = 14;
            this.datePicker.Value = new System.DateTime(2021, 3, 8, 18, 52, 33, 0);
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Location = new System.Drawing.Point(351, 377);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(62, 29);
            this.noButton.TabIndex = 11;
            this.noButton.TabStop = true;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Location = new System.Drawing.Point(253, 375);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(71, 29);
            this.yesButton.TabIndex = 10;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // occasionBox
            // 
            this.occasionBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.occasionBox.FormattingEnabled = true;
            this.occasionBox.Items.AddRange(new object[] {
            "Wedding",
            "Birthday",
            "Coorporate",
            "Other"});
            this.occasionBox.Location = new System.Drawing.Point(224, 104);
            this.occasionBox.Name = "occasionBox";
            this.occasionBox.Size = new System.Drawing.Size(213, 33);
            this.occasionBox.TabIndex = 9;
            this.occasionBox.Text = "Select event type";
            this.occasionBox.SelectedIndexChanged += new System.EventHandler(this.occasionBox_SelectedIndexChanged_2);
            this.occasionBox.Enter += new System.EventHandler(this.occasionBox_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Guest amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Occasion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Day of cordinator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // checkoutPage
            // 
            this.checkoutPage.BackColor = System.Drawing.Color.RosyBrown;
            this.checkoutPage.Controls.Add(this.button1);
            this.checkoutPage.Controls.Add(this.textBox1);
            this.checkoutPage.Controls.Add(this.labelTotal);
            this.checkoutPage.Controls.Add(this.labelDoc);
            this.checkoutPage.Controls.Add(this.labelcost);
            this.checkoutPage.Controls.Add(this.labelTax);
            this.checkoutPage.Controls.Add(this.label19);
            this.checkoutPage.Controls.Add(this.label18);
            this.checkoutPage.Controls.Add(this.label15);
            this.checkoutPage.Controls.Add(this.label14);
            this.checkoutPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutPage.Location = new System.Drawing.Point(4, 29);
            this.checkoutPage.Name = "checkoutPage";
            this.checkoutPage.Size = new System.Drawing.Size(1198, 506);
            this.checkoutPage.TabIndex = 2;
            this.checkoutPage.Text = "Checkout";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 56);
            this.button1.TabIndex = 25;
            this.button1.Text = "Estimate cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 30);
            this.textBox1.TabIndex = 24;
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotal.Location = new System.Drawing.Point(452, 310);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(81, 35);
            this.labelTotal.TabIndex = 23;
            // 
            // labelDoc
            // 
            this.labelDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDoc.Location = new System.Drawing.Point(452, 168);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(81, 35);
            this.labelDoc.TabIndex = 22;
            // 
            // labelcost
            // 
            this.labelcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelcost.Location = new System.Drawing.Point(452, 116);
            this.labelcost.Name = "labelcost";
            this.labelcost.Size = new System.Drawing.Size(81, 35);
            this.labelcost.TabIndex = 21;
            this.labelcost.Click += new System.EventHandler(this.labelcost_Click);
            // 
            // labelTax
            // 
            this.labelTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTax.Location = new System.Drawing.Point(452, 233);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(81, 35);
            this.labelTax.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(315, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 25);
            this.label19.TabIndex = 19;
            this.label19.Text = "DOC";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(315, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 25);
            this.label18.TabIndex = 17;
            this.label18.Text = "Total cost";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(315, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "Tax";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1201, 572);
            this.Controls.Add(this.checkout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.checkout.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.registorPage.ResumeLayout(false);
            this.registorPage.PerformLayout();
            this.submitButton.ResumeLayout(false);
            this.submitButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestNumber)).EndInit();
            this.checkoutPage.ResumeLayout(false);
            this.checkoutPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TabControl checkout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage registorPage;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage submitButton;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown guestNumber;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.RadioButton yesButton;
        private System.Windows.Forms.ComboBox occasionBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage checkoutPage;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelcost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

