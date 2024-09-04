namespace AlarmClockGUI
{
   partial class AlarmClockFrm
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
         Hourbtn1 = new Button();
         Minutebtn2 = new Button();
         Secbtn3 = new Button();
         Onbtn4 = new Button();
         Offbtn5 = new Button();
         Timerbtn6 = new Button();
         AmPmlbl1 = new Label();
         panel1 = new Panel();
         PMrbtn2 = new RadioButton();
         AMrbtn1 = new RadioButton();
         button1 = new Button();
         label1 = new Label();
         panel1.SuspendLayout();
         SuspendLayout();
         // 
         // Hourbtn1
         // 
         Hourbtn1.Location = new Point(30, 16);
         Hourbtn1.Margin = new Padding(4, 4, 4, 4);
         Hourbtn1.Name = "Hourbtn1";
         Hourbtn1.Size = new Size(316, 127);
         Hourbtn1.TabIndex = 1;
         Hourbtn1.Text = "Hour";
         Hourbtn1.UseVisualStyleBackColor = true;
         // 
         // Minutebtn2
         // 
         Minutebtn2.Location = new Point(386, 16);
         Minutebtn2.Margin = new Padding(4, 4, 4, 4);
         Minutebtn2.Name = "Minutebtn2";
         Minutebtn2.Size = new Size(316, 127);
         Minutebtn2.TabIndex = 2;
         Minutebtn2.Text = "Minute";
         Minutebtn2.UseVisualStyleBackColor = true;
         // 
         // Secbtn3
         // 
         Secbtn3.Location = new Point(760, 16);
         Secbtn3.Margin = new Padding(4, 4, 4, 4);
         Secbtn3.Name = "Secbtn3";
         Secbtn3.Size = new Size(316, 127);
         Secbtn3.TabIndex = 3;
         Secbtn3.Text = "Second";
         Secbtn3.UseVisualStyleBackColor = true;
         // 
         // Onbtn4
         // 
         Onbtn4.Location = new Point(1128, 16);
         Onbtn4.Margin = new Padding(4, 4, 4, 4);
         Onbtn4.Name = "Onbtn4";
         Onbtn4.Size = new Size(316, 127);
         Onbtn4.TabIndex = 4;
         Onbtn4.Text = "On";
         Onbtn4.UseVisualStyleBackColor = true;
         // 
         // Offbtn5
         // 
         Offbtn5.Location = new Point(1485, 16);
         Offbtn5.Margin = new Padding(4, 4, 4, 4);
         Offbtn5.Name = "Offbtn5";
         Offbtn5.Size = new Size(316, 127);
         Offbtn5.TabIndex = 5;
         Offbtn5.Text = "Off";
         Offbtn5.UseVisualStyleBackColor = true;
         // 
         // Timerbtn6
         // 
         Timerbtn6.Location = new Point(1485, 211);
         Timerbtn6.Margin = new Padding(4, 4, 4, 4);
         Timerbtn6.Name = "Timerbtn6";
         Timerbtn6.Size = new Size(316, 127);
         Timerbtn6.TabIndex = 6;
         Timerbtn6.Text = "Timer";
         Timerbtn6.UseVisualStyleBackColor = true;
         // 
         // AmPmlbl1
         // 
         AmPmlbl1.AutoSize = true;
         AmPmlbl1.Location = new Point(700, 190);
         AmPmlbl1.Margin = new Padding(4, 0, 4, 0);
         AmPmlbl1.Name = "AmPmlbl1";
         AmPmlbl1.Size = new Size(204, 65);
         AmPmlbl1.TabIndex = 7;
         AmPmlbl1.Text = "AM/PM";
         // 
         // panel1
         // 
         panel1.Controls.Add(PMrbtn2);
         panel1.Controls.Add(AMrbtn1);
         panel1.Location = new Point(664, 259);
         panel1.Margin = new Padding(4, 4, 4, 4);
         panel1.Name = "panel1";
         panel1.Size = new Size(435, 186);
         panel1.TabIndex = 8;
         // 
         // PMrbtn2
         // 
         PMrbtn2.AutoSize = true;
         PMrbtn2.Location = new Point(235, 57);
         PMrbtn2.Margin = new Padding(4, 4, 4, 4);
         PMrbtn2.Name = "PMrbtn2";
         PMrbtn2.Size = new Size(147, 69);
         PMrbtn2.TabIndex = 1;
         PMrbtn2.TabStop = true;
         PMrbtn2.Text = "PM";
         PMrbtn2.UseVisualStyleBackColor = true;
         // 
         // AMrbtn1
         // 
         AMrbtn1.AutoSize = true;
         AMrbtn1.Location = new Point(36, 57);
         AMrbtn1.Margin = new Padding(4, 4, 4, 4);
         AMrbtn1.Name = "AMrbtn1";
         AMrbtn1.Size = new Size(152, 69);
         AMrbtn1.TabIndex = 0;
         AMrbtn1.TabStop = true;
         AMrbtn1.Text = "AM";
         AMrbtn1.UseVisualStyleBackColor = true;
         // 
         // button1
         // 
         button1.Location = new Point(16, 478);
         button1.Margin = new Padding(4, 4, 4, 4);
         button1.Name = "button1";
         button1.Size = new Size(1794, 93);
         button1.TabIndex = 9;
         button1.Text = "SNOOZE";
         button1.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.BackColor = Color.Black;
         label1.BorderStyle = BorderStyle.Fixed3D;
         label1.ForeColor = Color.Silver;
         label1.Location = new Point(122, 295);
         label1.Margin = new Padding(4, 0, 4, 0);
         label1.Name = "label1";
         label1.Size = new Size(224, 67);
         label1.TabIndex = 10;
         label1.Text = "00:00:00";
         // 
         // AlarmClockFrm
         // 
         AutoScaleDimensions = new SizeF(29F, 65F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1830, 607);
         Controls.Add(label1);
         Controls.Add(button1);
         Controls.Add(panel1);
         Controls.Add(AmPmlbl1);
         Controls.Add(Timerbtn6);
         Controls.Add(Offbtn5);
         Controls.Add(Onbtn4);
         Controls.Add(Secbtn3);
         Controls.Add(Minutebtn2);
         Controls.Add(Hourbtn1);
         Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         Margin = new Padding(4, 4, 4, 4);
         Name = "AlarmClockFrm";
         Text = "Alarm Clock";
         panel1.ResumeLayout(false);
         panel1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button Hourbtn1;
      private Button Minutebtn2;
      private Button Secbtn3;
      private Button Onbtn4;
      private Button Offbtn5;
      private Button Timerbtn6;
      private Label AmPmlbl1;
      private Panel panel1;
      private RadioButton PMrbtn2;
      private RadioButton AMrbtn1;
      private Button button1;
      private Label label1;
   }
}
