namespace NotepadGUI
{
   partial class Form1
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
         menuStrip1 = new MenuStrip();
         fileToolStripMenuItem = new ToolStripMenuItem();
         editToolStripMenuItem = new ToolStripMenuItem();
         viewToolStripMenuItem = new ToolStripMenuItem();
         aboutToolStripMenuItem = new ToolStripMenuItem();
         richTextBox1 = new RichTextBox();
         menuStrip1.SuspendLayout();
         SuspendLayout();
         // 
         // menuStrip1
         // 
         menuStrip1.ImageScalingSize = new Size(48, 48);
         menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem });
         menuStrip1.Location = new Point(0, 0);
         menuStrip1.Name = "menuStrip1";
         menuStrip1.Size = new Size(1284, 56);
         menuStrip1.TabIndex = 0;
         menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         fileToolStripMenuItem.Size = new Size(103, 52);
         fileToolStripMenuItem.Text = "File";
         // 
         // editToolStripMenuItem
         // 
         editToolStripMenuItem.Name = "editToolStripMenuItem";
         editToolStripMenuItem.Size = new Size(108, 52);
         editToolStripMenuItem.Text = "Edit";
         // 
         // viewToolStripMenuItem
         // 
         viewToolStripMenuItem.Name = "viewToolStripMenuItem";
         viewToolStripMenuItem.Size = new Size(124, 52);
         viewToolStripMenuItem.Text = "View";
         // 
         // aboutToolStripMenuItem
         // 
         aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         aboutToolStripMenuItem.Size = new Size(145, 52);
         aboutToolStripMenuItem.Text = "About";
         // 
         // richTextBox1
         // 
         richTextBox1.Location = new Point(9, 80);
         richTextBox1.Name = "richTextBox1";
         richTextBox1.Size = new Size(1270, 703);
         richTextBox1.TabIndex = 1;
         richTextBox1.Text = "Enter text here.";
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(20F, 48F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(1284, 785);
         Controls.Add(richTextBox1);
         Controls.Add(menuStrip1);
         MainMenuStrip = menuStrip1;
         Name = "Form1";
         Text = "My Notepad";
         menuStrip1.ResumeLayout(false);
         menuStrip1.PerformLayout();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private MenuStrip menuStrip1;
      private ToolStripMenuItem fileToolStripMenuItem;
      private ToolStripMenuItem editToolStripMenuItem;
      private ToolStripMenuItem viewToolStripMenuItem;
      private ToolStripMenuItem aboutToolStripMenuItem;
      private RichTextBox richTextBox1;
   }
}
