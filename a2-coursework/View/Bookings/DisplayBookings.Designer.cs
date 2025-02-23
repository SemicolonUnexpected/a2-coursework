namespace a2_coursework.View.Bookings {
    partial class DisplayBookings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dateTimePicker1 = new DateTimePicker();
            printPreviewControl1 = new PrintPreviewControl();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Location = new Point(398, 114);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(253, 249);
            printPreviewControl1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.Red;
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Font = new Font("Segoe UI", 12F);
            monthCalendar1.ForeColor = Color.Red;
            monthCalendar1.Location = new Point(91, 133);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.TabIndex = 2;
            // 
            // DisplayBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(printPreviewControl1);
            Controls.Add(dateTimePicker1);
            Name = "DisplayBookings";
            Text = "DisplayBookings";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private PrintPreviewControl printPreviewControl1;
        private MonthCalendar monthCalendar1;
    }
}