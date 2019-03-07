namespace Selenoid
{
    partial class SelenoidForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelenoidForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_ScreenName = new System.Windows.Forms.ComboBox();
            this.textBox_ObjectName = new System.Windows.Forms.TextBox();
            this.textBox_LocatorValue = new System.Windows.Forms.TextBox();
            this.comboBox_ObjectType = new System.Windows.Forms.ComboBox();
            this.comboBox_LocatorType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(568, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(108, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Screen Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(108, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Locator Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(108, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Object Type";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(108, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Object Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(108, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Locator Value";
            // 
            // comboBox_ScreenName
            // 
            this.comboBox_ScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_ScreenName.FormattingEnabled = true;
            this.comboBox_ScreenName.Location = new System.Drawing.Point(345, 194);
            this.comboBox_ScreenName.Name = "comboBox_ScreenName";
            this.comboBox_ScreenName.Size = new System.Drawing.Size(279, 33);
            this.comboBox_ScreenName.TabIndex = 6;
            // 
            // textBox_ObjectName
            // 
            this.textBox_ObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_ObjectName.Location = new System.Drawing.Point(345, 260);
            this.textBox_ObjectName.Name = "textBox_ObjectName";
            this.textBox_ObjectName.Size = new System.Drawing.Size(279, 30);
            this.textBox_ObjectName.TabIndex = 7;
            // 
            // textBox_LocatorValue
            // 
            this.textBox_LocatorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_LocatorValue.Location = new System.Drawing.Point(345, 454);
            this.textBox_LocatorValue.Name = "textBox_LocatorValue";
            this.textBox_LocatorValue.Size = new System.Drawing.Size(279, 30);
            this.textBox_LocatorValue.TabIndex = 8;
            // 
            // comboBox_ObjectType
            // 
            this.comboBox_ObjectType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_ObjectType.FormattingEnabled = true;
            this.comboBox_ObjectType.Location = new System.Drawing.Point(345, 326);
            this.comboBox_ObjectType.Name = "comboBox_ObjectType";
            this.comboBox_ObjectType.Size = new System.Drawing.Size(279, 33);
            this.comboBox_ObjectType.TabIndex = 9;
            // 
            // comboBox_LocatorType
            // 
            this.comboBox_LocatorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox_LocatorType.FormattingEnabled = true;
            this.comboBox_LocatorType.Location = new System.Drawing.Point(345, 385);
            this.comboBox_LocatorType.Name = "comboBox_LocatorType";
            this.comboBox_LocatorType.Size = new System.Drawing.Size(279, 33);
            this.comboBox_LocatorType.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(479, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(695, 549);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SelenoidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1505, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_LocatorType);
            this.Controls.Add(this.comboBox_ObjectType);
            this.Controls.Add(this.textBox_LocatorValue);
            this.Controls.Add(this.textBox_ObjectName);
            this.Controls.Add(this.comboBox_ScreenName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SelenoidForm";
            this.Text = "Selenoid";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_ScreenName;
        private System.Windows.Forms.TextBox textBox_ObjectName;
        private System.Windows.Forms.TextBox textBox_LocatorValue;
        private System.Windows.Forms.ComboBox comboBox_ObjectType;
        private System.Windows.Forms.ComboBox comboBox_LocatorType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

