namespace _8LEDControlApplication
{
    partial class LEDControlApplication
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
            this.RedLED1button = new System.Windows.Forms.Button();
            this.BlueLED1Button = new System.Windows.Forms.Button();
            this.BlueLED2Button = new System.Windows.Forms.Button();
            this.GreenLED1Button = new System.Windows.Forms.Button();
            this.GreenLED2Button = new System.Windows.Forms.Button();
            this.YellowLED1Button = new System.Windows.Forms.Button();
            this.YellowLED2Button = new System.Windows.Forms.Button();
            this.RedLED2button = new System.Windows.Forms.Button();
            this.RedLED1ButtonOff = new System.Windows.Forms.Button();
            this.RedLED2ButtonOff = new System.Windows.Forms.Button();
            this.BlueLED1ButtonOff = new System.Windows.Forms.Button();
            this.GreenLED1ButtonOff = new System.Windows.Forms.Button();
            this.YellowLED1ButtonOff = new System.Windows.Forms.Button();
            this.BlueLED2ButtonOff = new System.Windows.Forms.Button();
            this.GreenLED2ButtonOff = new System.Windows.Forms.Button();
            this.YellowLED2ButtonOff = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.AllOnButton = new System.Windows.Forms.Button();
            this.AllOffButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.YellowLEDsOn = new System.Windows.Forms.Button();
            this.GreenLEDsOn = new System.Windows.Forms.Button();
            this.BlueLEDsOn = new System.Windows.Forms.Button();
            this.RedLEDsOn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedLED1button
            // 
            this.RedLED1button.BackColor = System.Drawing.Color.Red;
            this.RedLED1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLED1button.ForeColor = System.Drawing.Color.White;
            this.RedLED1button.Location = new System.Drawing.Point(20, 35);
            this.RedLED1button.Name = "RedLED1button";
            this.RedLED1button.Size = new System.Drawing.Size(153, 56);
            this.RedLED1button.TabIndex = 0;
            this.RedLED1button.Text = "Red LED 1 (ON)";
            this.RedLED1button.UseVisualStyleBackColor = false;
            this.RedLED1button.Click += new System.EventHandler(this.RedLED1button_Click);
            // 
            // BlueLED1Button
            // 
            this.BlueLED1Button.BackColor = System.Drawing.Color.Blue;
            this.BlueLED1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLED1Button.ForeColor = System.Drawing.Color.White;
            this.BlueLED1Button.Location = new System.Drawing.Point(20, 159);
            this.BlueLED1Button.Name = "BlueLED1Button";
            this.BlueLED1Button.Size = new System.Drawing.Size(153, 56);
            this.BlueLED1Button.TabIndex = 2;
            this.BlueLED1Button.Text = "Blue LED 1 (ON)";
            this.BlueLED1Button.UseVisualStyleBackColor = false;
            this.BlueLED1Button.Click += new System.EventHandler(this.BlueLED1Button_Click);
            // 
            // BlueLED2Button
            // 
            this.BlueLED2Button.BackColor = System.Drawing.Color.Blue;
            this.BlueLED2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLED2Button.ForeColor = System.Drawing.Color.White;
            this.BlueLED2Button.Location = new System.Drawing.Point(20, 221);
            this.BlueLED2Button.Name = "BlueLED2Button";
            this.BlueLED2Button.Size = new System.Drawing.Size(153, 56);
            this.BlueLED2Button.TabIndex = 3;
            this.BlueLED2Button.Text = "Blue LED 2 (ON)";
            this.BlueLED2Button.UseVisualStyleBackColor = false;
            this.BlueLED2Button.Click += new System.EventHandler(this.BlueLED2Button_Click);
            // 
            // GreenLED1Button
            // 
            this.GreenLED1Button.BackColor = System.Drawing.Color.Lime;
            this.GreenLED1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLED1Button.ForeColor = System.Drawing.Color.Black;
            this.GreenLED1Button.Location = new System.Drawing.Point(20, 283);
            this.GreenLED1Button.Name = "GreenLED1Button";
            this.GreenLED1Button.Size = new System.Drawing.Size(153, 56);
            this.GreenLED1Button.TabIndex = 4;
            this.GreenLED1Button.Text = "Green LED 1 (ON)";
            this.GreenLED1Button.UseVisualStyleBackColor = false;
            this.GreenLED1Button.Click += new System.EventHandler(this.GreenLED1Button_Click);
            // 
            // GreenLED2Button
            // 
            this.GreenLED2Button.BackColor = System.Drawing.Color.Lime;
            this.GreenLED2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLED2Button.ForeColor = System.Drawing.Color.Black;
            this.GreenLED2Button.Location = new System.Drawing.Point(20, 345);
            this.GreenLED2Button.Name = "GreenLED2Button";
            this.GreenLED2Button.Size = new System.Drawing.Size(153, 56);
            this.GreenLED2Button.TabIndex = 5;
            this.GreenLED2Button.Text = "Green LED 2 (ON)";
            this.GreenLED2Button.UseVisualStyleBackColor = false;
            this.GreenLED2Button.Click += new System.EventHandler(this.GreenLED2Button_Click);
            // 
            // YellowLED1Button
            // 
            this.YellowLED1Button.BackColor = System.Drawing.Color.Yellow;
            this.YellowLED1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLED1Button.ForeColor = System.Drawing.Color.Black;
            this.YellowLED1Button.Location = new System.Drawing.Point(20, 407);
            this.YellowLED1Button.Name = "YellowLED1Button";
            this.YellowLED1Button.Size = new System.Drawing.Size(153, 56);
            this.YellowLED1Button.TabIndex = 6;
            this.YellowLED1Button.Text = "Yellow LED 1 (ON)";
            this.YellowLED1Button.UseVisualStyleBackColor = false;
            this.YellowLED1Button.Click += new System.EventHandler(this.YellowLED1Button_Click);
            // 
            // YellowLED2Button
            // 
            this.YellowLED2Button.BackColor = System.Drawing.Color.Yellow;
            this.YellowLED2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLED2Button.ForeColor = System.Drawing.Color.Black;
            this.YellowLED2Button.Location = new System.Drawing.Point(20, 469);
            this.YellowLED2Button.Name = "YellowLED2Button";
            this.YellowLED2Button.Size = new System.Drawing.Size(153, 56);
            this.YellowLED2Button.TabIndex = 7;
            this.YellowLED2Button.Text = "Yellow LED 2 (ON)";
            this.YellowLED2Button.UseVisualStyleBackColor = false;
            this.YellowLED2Button.Click += new System.EventHandler(this.YellowLED2Button_Click);
            // 
            // RedLED2button
            // 
            this.RedLED2button.BackColor = System.Drawing.Color.Red;
            this.RedLED2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLED2button.ForeColor = System.Drawing.Color.White;
            this.RedLED2button.Location = new System.Drawing.Point(20, 97);
            this.RedLED2button.Name = "RedLED2button";
            this.RedLED2button.Size = new System.Drawing.Size(153, 56);
            this.RedLED2button.TabIndex = 1;
            this.RedLED2button.Text = "Red  LED 2 (ON)";
            this.RedLED2button.UseVisualStyleBackColor = false;
            this.RedLED2button.Click += new System.EventHandler(this.RedLED2button_Click);
            // 
            // RedLED1ButtonOff
            // 
            this.RedLED1ButtonOff.BackColor = System.Drawing.Color.Red;
            this.RedLED1ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLED1ButtonOff.ForeColor = System.Drawing.Color.White;
            this.RedLED1ButtonOff.Location = new System.Drawing.Point(191, 35);
            this.RedLED1ButtonOff.Name = "RedLED1ButtonOff";
            this.RedLED1ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.RedLED1ButtonOff.TabIndex = 8;
            this.RedLED1ButtonOff.Text = "OFF";
            this.RedLED1ButtonOff.UseVisualStyleBackColor = false;
            this.RedLED1ButtonOff.Click += new System.EventHandler(this.RedLED1ButtonOff_Click);
            // 
            // RedLED2ButtonOff
            // 
            this.RedLED2ButtonOff.BackColor = System.Drawing.Color.Red;
            this.RedLED2ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLED2ButtonOff.ForeColor = System.Drawing.Color.White;
            this.RedLED2ButtonOff.Location = new System.Drawing.Point(191, 97);
            this.RedLED2ButtonOff.Name = "RedLED2ButtonOff";
            this.RedLED2ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.RedLED2ButtonOff.TabIndex = 9;
            this.RedLED2ButtonOff.Text = "OFF";
            this.RedLED2ButtonOff.UseVisualStyleBackColor = false;
            this.RedLED2ButtonOff.Click += new System.EventHandler(this.RedLED2ButtonOff_Click);
            // 
            // BlueLED1ButtonOff
            // 
            this.BlueLED1ButtonOff.BackColor = System.Drawing.Color.Blue;
            this.BlueLED1ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLED1ButtonOff.ForeColor = System.Drawing.Color.White;
            this.BlueLED1ButtonOff.Location = new System.Drawing.Point(191, 159);
            this.BlueLED1ButtonOff.Name = "BlueLED1ButtonOff";
            this.BlueLED1ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.BlueLED1ButtonOff.TabIndex = 10;
            this.BlueLED1ButtonOff.Text = "OFF";
            this.BlueLED1ButtonOff.UseVisualStyleBackColor = false;
            this.BlueLED1ButtonOff.Click += new System.EventHandler(this.BlueLED1ButtonOff_Click);
            // 
            // GreenLED1ButtonOff
            // 
            this.GreenLED1ButtonOff.BackColor = System.Drawing.Color.Lime;
            this.GreenLED1ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLED1ButtonOff.ForeColor = System.Drawing.Color.Black;
            this.GreenLED1ButtonOff.Location = new System.Drawing.Point(191, 283);
            this.GreenLED1ButtonOff.Name = "GreenLED1ButtonOff";
            this.GreenLED1ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.GreenLED1ButtonOff.TabIndex = 12;
            this.GreenLED1ButtonOff.Text = "OFF";
            this.GreenLED1ButtonOff.UseVisualStyleBackColor = false;
            this.GreenLED1ButtonOff.Click += new System.EventHandler(this.GreenLED1ButtonOff_Click);
            // 
            // YellowLED1ButtonOff
            // 
            this.YellowLED1ButtonOff.BackColor = System.Drawing.Color.Yellow;
            this.YellowLED1ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLED1ButtonOff.ForeColor = System.Drawing.Color.Black;
            this.YellowLED1ButtonOff.Location = new System.Drawing.Point(191, 407);
            this.YellowLED1ButtonOff.Name = "YellowLED1ButtonOff";
            this.YellowLED1ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.YellowLED1ButtonOff.TabIndex = 14;
            this.YellowLED1ButtonOff.Text = "OFF";
            this.YellowLED1ButtonOff.UseVisualStyleBackColor = false;
            this.YellowLED1ButtonOff.Click += new System.EventHandler(this.YellowLED1ButtonOff_Click);
            // 
            // BlueLED2ButtonOff
            // 
            this.BlueLED2ButtonOff.BackColor = System.Drawing.Color.Blue;
            this.BlueLED2ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLED2ButtonOff.ForeColor = System.Drawing.Color.White;
            this.BlueLED2ButtonOff.Location = new System.Drawing.Point(191, 221);
            this.BlueLED2ButtonOff.Name = "BlueLED2ButtonOff";
            this.BlueLED2ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.BlueLED2ButtonOff.TabIndex = 16;
            this.BlueLED2ButtonOff.Text = "OFF";
            this.BlueLED2ButtonOff.UseVisualStyleBackColor = false;
            this.BlueLED2ButtonOff.Click += new System.EventHandler(this.BlueLED2ButtonOff_Click);
            // 
            // GreenLED2ButtonOff
            // 
            this.GreenLED2ButtonOff.BackColor = System.Drawing.Color.Lime;
            this.GreenLED2ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLED2ButtonOff.ForeColor = System.Drawing.Color.Black;
            this.GreenLED2ButtonOff.Location = new System.Drawing.Point(191, 345);
            this.GreenLED2ButtonOff.Name = "GreenLED2ButtonOff";
            this.GreenLED2ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.GreenLED2ButtonOff.TabIndex = 17;
            this.GreenLED2ButtonOff.Text = "OFF";
            this.GreenLED2ButtonOff.UseVisualStyleBackColor = false;
            this.GreenLED2ButtonOff.Click += new System.EventHandler(this.GreenLED2ButtonOff_Click);
            // 
            // YellowLED2ButtonOff
            // 
            this.YellowLED2ButtonOff.BackColor = System.Drawing.Color.Yellow;
            this.YellowLED2ButtonOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLED2ButtonOff.ForeColor = System.Drawing.Color.Black;
            this.YellowLED2ButtonOff.Location = new System.Drawing.Point(191, 469);
            this.YellowLED2ButtonOff.Name = "YellowLED2ButtonOff";
            this.YellowLED2ButtonOff.Size = new System.Drawing.Size(153, 56);
            this.YellowLED2ButtonOff.TabIndex = 18;
            this.YellowLED2ButtonOff.Text = "OFF";
            this.YellowLED2ButtonOff.UseVisualStyleBackColor = false;
            this.YellowLED2ButtonOff.Click += new System.EventHandler(this.YellowLED2ButtonOff_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(365, 544);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(220, 53);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AllOnButton
            // 
            this.AllOnButton.BackColor = System.Drawing.Color.Black;
            this.AllOnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOnButton.ForeColor = System.Drawing.Color.White;
            this.AllOnButton.Location = new System.Drawing.Point(8, 523);
            this.AllOnButton.Name = "AllOnButton";
            this.AllOnButton.Size = new System.Drawing.Size(153, 56);
            this.AllOnButton.TabIndex = 20;
            this.AllOnButton.Text = "ALL ON";
            this.AllOnButton.UseVisualStyleBackColor = false;
            this.AllOnButton.Click += new System.EventHandler(this.AllOnButton_Click);
            // 
            // AllOffButton
            // 
            this.AllOffButton.BackColor = System.Drawing.Color.Black;
            this.AllOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOffButton.ForeColor = System.Drawing.Color.White;
            this.AllOffButton.Location = new System.Drawing.Point(179, 523);
            this.AllOffButton.Name = "AllOffButton";
            this.AllOffButton.Size = new System.Drawing.Size(153, 56);
            this.AllOffButton.TabIndex = 21;
            this.AllOffButton.Text = "ALL OFF";
            this.AllOffButton.UseVisualStyleBackColor = false;
            this.AllOffButton.Click += new System.EventHandler(this.AllOffButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.AllOffButton);
            this.groupBox1.Controls.Add(this.AllOnButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 585);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED ON/OFF CONTROL";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox2.Controls.Add(this.YellowLEDsOn);
            this.groupBox2.Controls.Add(this.GreenLEDsOn);
            this.groupBox2.Controls.Add(this.BlueLEDsOn);
            this.groupBox2.Controls.Add(this.RedLEDsOn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(365, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 273);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED GROUP CONTROL";
            // 
            // YellowLEDsOn
            // 
            this.YellowLEDsOn.BackColor = System.Drawing.Color.Yellow;
            this.YellowLEDsOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLEDsOn.ForeColor = System.Drawing.Color.Black;
            this.YellowLEDsOn.Location = new System.Drawing.Point(12, 212);
            this.YellowLEDsOn.Name = "YellowLEDsOn";
            this.YellowLEDsOn.Size = new System.Drawing.Size(207, 52);
            this.YellowLEDsOn.TabIndex = 3;
            this.YellowLEDsOn.Text = "Yellow LED°s ON";
            this.YellowLEDsOn.UseVisualStyleBackColor = false;
            this.YellowLEDsOn.Click += new System.EventHandler(this.YellowLEDsOn_Click);
            // 
            // GreenLEDsOn
            // 
            this.GreenLEDsOn.BackColor = System.Drawing.Color.Lime;
            this.GreenLEDsOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenLEDsOn.ForeColor = System.Drawing.Color.Black;
            this.GreenLEDsOn.Location = new System.Drawing.Point(12, 150);
            this.GreenLEDsOn.Name = "GreenLEDsOn";
            this.GreenLEDsOn.Size = new System.Drawing.Size(207, 52);
            this.GreenLEDsOn.TabIndex = 2;
            this.GreenLEDsOn.Text = "Green LED°s ON";
            this.GreenLEDsOn.UseVisualStyleBackColor = false;
            this.GreenLEDsOn.Click += new System.EventHandler(this.GreenLEDsOn_Click);
            // 
            // BlueLEDsOn
            // 
            this.BlueLEDsOn.BackColor = System.Drawing.Color.Blue;
            this.BlueLEDsOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueLEDsOn.ForeColor = System.Drawing.Color.White;
            this.BlueLEDsOn.Location = new System.Drawing.Point(12, 88);
            this.BlueLEDsOn.Name = "BlueLEDsOn";
            this.BlueLEDsOn.Size = new System.Drawing.Size(207, 52);
            this.BlueLEDsOn.TabIndex = 1;
            this.BlueLEDsOn.Text = "Blue LED°s ON";
            this.BlueLEDsOn.UseVisualStyleBackColor = false;
            this.BlueLEDsOn.Click += new System.EventHandler(this.BlueLEDsOn_Click);
            // 
            // RedLEDsOn
            // 
            this.RedLEDsOn.BackColor = System.Drawing.Color.Red;
            this.RedLEDsOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLEDsOn.ForeColor = System.Drawing.Color.White;
            this.RedLEDsOn.Location = new System.Drawing.Point(12, 26);
            this.RedLEDsOn.Name = "RedLEDsOn";
            this.RedLEDsOn.Size = new System.Drawing.Size(207, 52);
            this.RedLEDsOn.TabIndex = 0;
            this.RedLEDsOn.Text = "Red LED°s ON";
            this.RedLEDsOn.UseVisualStyleBackColor = false;
            this.RedLEDsOn.Click += new System.EventHandler(this.RedLEDsOn_Click);
            // 
            // LEDControlApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(614, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.YellowLED2ButtonOff);
            this.Controls.Add(this.GreenLED2ButtonOff);
            this.Controls.Add(this.BlueLED2ButtonOff);
            this.Controls.Add(this.YellowLED1ButtonOff);
            this.Controls.Add(this.GreenLED1ButtonOff);
            this.Controls.Add(this.BlueLED1ButtonOff);
            this.Controls.Add(this.RedLED2ButtonOff);
            this.Controls.Add(this.RedLED1ButtonOff);
            this.Controls.Add(this.YellowLED2Button);
            this.Controls.Add(this.YellowLED1Button);
            this.Controls.Add(this.GreenLED2Button);
            this.Controls.Add(this.GreenLED1Button);
            this.Controls.Add(this.BlueLED2Button);
            this.Controls.Add(this.BlueLED1Button);
            this.Controls.Add(this.RedLED2button);
            this.Controls.Add(this.RedLED1button);
            this.Controls.Add(this.groupBox1);
            this.Name = "LEDControlApplication";
            this.RightToLeftLayout = true;
            this.Text = "LED Control Application";
            this.Load += new System.EventHandler(this.LEDControlApplication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RedLED1button;
        private System.Windows.Forms.Button BlueLED1Button;
        private System.Windows.Forms.Button BlueLED2Button;
        private System.Windows.Forms.Button GreenLED1Button;
        private System.Windows.Forms.Button GreenLED2Button;
        private System.Windows.Forms.Button YellowLED1Button;
        private System.Windows.Forms.Button YellowLED2Button;
        private System.Windows.Forms.Button RedLED2button;
        private System.Windows.Forms.Button RedLED1ButtonOff;
        private System.Windows.Forms.Button RedLED2ButtonOff;
        private System.Windows.Forms.Button BlueLED1ButtonOff;
        private System.Windows.Forms.Button GreenLED1ButtonOff;
        private System.Windows.Forms.Button YellowLED1ButtonOff;
        private System.Windows.Forms.Button BlueLED2ButtonOff;
        private System.Windows.Forms.Button GreenLED2ButtonOff;
        private System.Windows.Forms.Button YellowLED2ButtonOff;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button AllOnButton;
        private System.Windows.Forms.Button AllOffButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button YellowLEDsOn;
        private System.Windows.Forms.Button GreenLEDsOn;
        private System.Windows.Forms.Button BlueLEDsOn;
        private System.Windows.Forms.Button RedLEDsOn;
    }
}

