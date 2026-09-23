namespace HomeAssigment1
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
            this.lbldayOfWeekPrompt = new System.Windows.Forms.Label();
            this.lblmonthprompt = new System.Windows.Forms.Label();
            this.lbldayOfMonthNumeric = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtdayOfWeek = new System.Windows.Forms.TextBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtmonthNumeric = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btnshowData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldayOfWeekPrompt
            // 
            this.lbldayOfWeekPrompt.AutoSize = true;
            this.lbldayOfWeekPrompt.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayOfWeekPrompt.Location = new System.Drawing.Point(176, 130);
            this.lbldayOfWeekPrompt.Name = "lbldayOfWeekPrompt";
            this.lbldayOfWeekPrompt.Size = new System.Drawing.Size(317, 40);
            this.lbldayOfWeekPrompt.TabIndex = 0;
            this.lbldayOfWeekPrompt.Text = "Enter the day of the week :";
            this.lbldayOfWeekPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmonthprompt
            // 
            this.lblmonthprompt.AutoSize = true;
            this.lblmonthprompt.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthprompt.Location = new System.Drawing.Point(134, 184);
            this.lblmonthprompt.Name = "lblmonthprompt";
            this.lblmonthprompt.Size = new System.Drawing.Size(359, 40);
            this.lblmonthprompt.TabIndex = 1;
            this.lblmonthprompt.Text = "Enter the name of the month :";
            this.lblmonthprompt.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbldayOfMonthNumeric
            // 
            this.lbldayOfMonthNumeric.AutoSize = true;
            this.lbldayOfMonthNumeric.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayOfMonthNumeric.Location = new System.Drawing.Point(55, 237);
            this.lbldayOfMonthNumeric.Name = "lbldayOfMonthNumeric";
            this.lbldayOfMonthNumeric.Size = new System.Drawing.Size(438, 40);
            this.lbldayOfMonthNumeric.TabIndex = 2;
            this.lbldayOfMonthNumeric.Text = "Enter the numeric day of the month :";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(300, 290);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(193, 40);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Enter the year : ";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(62, 393);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(798, 95);
            this.lbloutput.TabIndex = 4;
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(384, 518);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(141, 60);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(719, 518);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(141, 60);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtdayOfWeek
            // 
            this.txtdayOfWeek.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdayOfWeek.Location = new System.Drawing.Point(537, 134);
            this.txtdayOfWeek.Name = "txtdayOfWeek";
            this.txtdayOfWeek.Size = new System.Drawing.Size(323, 33);
            this.txtdayOfWeek.TabIndex = 8;
            this.txtdayOfWeek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmonth
            // 
            this.txtmonth.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(536, 181);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(323, 33);
            this.txtmonth.TabIndex = 9;
            // 
            // txtmonthNumeric
            // 
            this.txtmonthNumeric.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthNumeric.Location = new System.Drawing.Point(537, 234);
            this.txtmonthNumeric.Name = "txtmonthNumeric";
            this.txtmonthNumeric.Size = new System.Drawing.Size(323, 33);
            this.txtmonthNumeric.TabIndex = 10;
            // 
            // txtyear
            // 
            this.txtyear.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyear.Location = new System.Drawing.Point(537, 295);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(323, 33);
            this.txtyear.TabIndex = 11;
            // 
            // btnshowData
            // 
            this.btnshowData.AutoSize = true;
            this.btnshowData.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowData.Location = new System.Drawing.Point(62, 518);
            this.btnshowData.Name = "btnshowData";
            this.btnshowData.Size = new System.Drawing.Size(182, 60);
            this.btnshowData.TabIndex = 12;
            this.btnshowData.Text = "Show Data";
            this.btnshowData.UseVisualStyleBackColor = true;
            this.btnshowData.Click += new System.EventHandler(this.btnshowData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 626);
            this.Controls.Add(this.btnshowData);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtmonthNumeric);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtdayOfWeek);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lbldayOfMonthNumeric);
            this.Controls.Add(this.lblmonthprompt);
            this.Controls.Add(this.lbldayOfWeekPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldayOfWeekPrompt;
        private System.Windows.Forms.Label lblmonthprompt;
        private System.Windows.Forms.Label lbldayOfMonthNumeric;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtdayOfWeek;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtmonthNumeric;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btnshowData;
    }
}

