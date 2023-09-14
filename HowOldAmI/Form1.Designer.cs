namespace HowOldAmI
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            btnGo = new Button();
            lblAge = new Label();
            tmrRefresh = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your DOB:";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(109, 12);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 1;
            // 
            // btnGo
            // 
            btnGo.Location = new Point(315, 12);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 2;
            btnGo.Text = "Go!";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(109, 75);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(38, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "label2";
            lblAge.Visible = false;
            // 
            // tmrRefresh
            // 
            tmrRefresh.Tick += tmrRefresh_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 146);
            Controls.Add(lblAge);
            Controls.Add(btnGo);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Age App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDateOfBirth;
        private Button btnGo;
        private Label lblAge;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}