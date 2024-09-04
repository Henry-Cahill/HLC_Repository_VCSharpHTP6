namespace Calendar_and_Appointments_GUI
{
   partial class MySchedulerFrm
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
         Calendarlb1 = new Label();
         Appointmentslb2 = new Label();
         monthCalendar1 = new MonthCalendar();
         Appointmentsrtb1 = new RichTextBox();
         SuspendLayout();
         // 
         // Calendarlb1
         // 
         Calendarlb1.BackColor = Color.Yellow;
         Calendarlb1.Location = new Point(48, 30);
         Calendarlb1.Name = "Calendarlb1";
         Calendarlb1.Size = new Size(580, 58);
         Calendarlb1.TabIndex = 0;
         Calendarlb1.Text = "Calendar";
         // 
         // Appointmentslb2
         // 
         Appointmentslb2.BackColor = Color.Yellow;
         Appointmentslb2.Location = new Point(48, 583);
         Appointmentslb2.Name = "Appointmentslb2";
         Appointmentslb2.Size = new Size(580, 58);
         Appointmentslb2.TabIndex = 1;
         Appointmentslb2.Text = "Appointments";
         // 
         // monthCalendar1
         // 
         monthCalendar1.Location = new Point(48, 97);
         monthCalendar1.Name = "monthCalendar1";
         monthCalendar1.TabIndex = 2;
         // 
         // Appointmentsrtb1
         // 
         Appointmentsrtb1.Location = new Point(48, 664);
         Appointmentsrtb1.Name = "Appointmentsrtb1";
         Appointmentsrtb1.Size = new Size(567, 333);
         Appointmentsrtb1.TabIndex = 3;
         Appointmentsrtb1.Text = "";
         // 
         // MySchedulerFrm
         // 
         AutoScaleDimensions = new SizeF(20F, 48F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(678, 1018);
         Controls.Add(Appointmentsrtb1);
         Controls.Add(monthCalendar1);
         Controls.Add(Appointmentslb2);
         Controls.Add(Calendarlb1);
         Name = "MySchedulerFrm";
         Text = "My Scheduler";
         ResumeLayout(false);
      }

      #endregion

      private Label Calendarlb1;
      private Label Appointmentslb2;
      private MonthCalendar monthCalendar1;
      private RichTextBox Appointmentsrtb1;
   }
}
