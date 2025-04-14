
namespace Cortana
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.calendarCortana = new System.Windows.Forms.MonthCalendar();
            this.dataGridCortana = new System.Windows.Forms.DataGridView();
            this.picBoxCortana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCortana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCortana)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarCortana
            // 
            this.calendarCortana.Location = new System.Drawing.Point(1185, 48);
            this.calendarCortana.Name = "calendarCortana";
            this.calendarCortana.TabIndex = 0;
            this.calendarCortana.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarCortana_DateChanged);
            // 
            // dataGridCortana
            // 
            this.dataGridCortana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCortana.Location = new System.Drawing.Point(12, 12);
            this.dataGridCortana.Name = "dataGridCortana";
            this.dataGridCortana.Size = new System.Drawing.Size(1111, 594);
            this.dataGridCortana.TabIndex = 1;
            // 
            // picBoxCortana
            // 
            this.picBoxCortana.Location = new System.Drawing.Point(1147, 285);
            this.picBoxCortana.Name = "picBoxCortana";
            this.picBoxCortana.Size = new System.Drawing.Size(296, 321);
            this.picBoxCortana.TabIndex = 2;
            this.picBoxCortana.TabStop = false;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 792);
            this.Controls.Add(this.picBoxCortana);
            this.Controls.Add(this.dataGridCortana);
            this.Controls.Add(this.calendarCortana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCortana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCortana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarCortana;
        private System.Windows.Forms.DataGridView dataGridCortana;
        private System.Windows.Forms.PictureBox picBoxCortana;
    }
}