namespace FourthLaba
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
            btnRefill = new Button();
            btnGet = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            txtTurnLine = new RichTextBox();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(45, 32);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(299, 29);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(250, 140);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(94, 146);
            btnGet.TabIndex = 1;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtInfo
            // 
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(45, 67);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(299, 67);
            txtInfo.TabIndex = 2;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(45, 140);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(199, 146);
            txtOut.TabIndex = 3;
            txtOut.Text = "";
            // 
            // txtTurnLine
            // 
            txtTurnLine.Location = new Point(378, 33);
            txtTurnLine.Name = "txtTurnLine";
            txtTurnLine.Size = new Size(204, 259);
            txtTurnLine.TabIndex = 4;
            txtTurnLine.Text = "";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(45, 298);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(537, 295);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 616);
            Controls.Add(pictureBox);
            Controls.Add(txtTurnLine);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Name = "Form1";
            Text = "Лаб. работа №4, вариант 10";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private RichTextBox txtTurnLine;
        private PictureBox pictureBox;
    }
}
