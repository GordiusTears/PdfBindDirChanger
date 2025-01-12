namespace PdfBindDirChanger
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
            buttonSrcFlder = new Button();
            textBoxSrcFlder = new TextBox();
            textBoxDstFlder = new TextBox();
            textBoxSrcFileList = new TextBox();
            textBoxDstFileList = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // buttonSrcFlder
            // 
            buttonSrcFlder.Location = new Point(30, 12);
            buttonSrcFlder.Name = "buttonSrcFlder";
            buttonSrcFlder.Size = new Size(120, 30);
            buttonSrcFlder.TabIndex = 0;
            buttonSrcFlder.Text = "変換前フォルダ";
            buttonSrcFlder.UseVisualStyleBackColor = true;
            buttonSrcFlder.Click += Button1_Click;
            // 
            // textBoxSrcFlder
            // 
            textBoxSrcFlder.Location = new Point(176, 16);
            textBoxSrcFlder.Name = "textBoxSrcFlder";
            textBoxSrcFlder.Size = new Size(450, 26);
            textBoxSrcFlder.TabIndex = 5;
            // 
            // textBoxDstFlder
            // 
            textBoxDstFlder.Location = new Point(176, 48);
            textBoxDstFlder.Name = "textBoxDstFlder";
            textBoxDstFlder.Size = new Size(450, 26);
            textBoxDstFlder.TabIndex = 6;
            // 
            // textBoxSrcFileList
            // 
            textBoxSrcFileList.Location = new Point(12, 183);
            textBoxSrcFileList.Multiline = true;
            textBoxSrcFileList.Name = "textBoxSrcFileList";
            textBoxSrcFileList.Size = new Size(381, 255);
            textBoxSrcFileList.TabIndex = 7;
            // 
            // textBoxDstFileList
            // 
            textBoxDstFileList.Location = new Point(417, 183);
            textBoxDstFileList.Multiline = true;
            textBoxDstFileList.Name = "textBoxDstFileList";
            textBoxDstFileList.Size = new Size(381, 255);
            textBoxDstFileList.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(30, 48);
            button2.Name = "button2";
            button2.Size = new Size(120, 30);
            button2.TabIndex = 9;
            button2.Text = "変換後フォルダ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(30, 84);
            button3.Name = "button3";
            button3.Size = new Size(120, 30);
            button3.TabIndex = 10;
            button3.Text = "右綴じ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 120);
            button4.Name = "button4";
            button4.Size = new Size(120, 30);
            button4.TabIndex = 11;
            button4.Text = "変換実行";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(653, 12);
            button5.Name = "button5";
            button5.Size = new Size(120, 30);
            button5.TabIndex = 12;
            button5.Text = "閉じる";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBoxDstFileList);
            Controls.Add(textBoxSrcFileList);
            Controls.Add(textBoxDstFlder);
            Controls.Add(textBoxSrcFlder);
            Controls.Add(buttonSrcFlder);
            Name = "Form1";
            Text = "PDF Bind Direction Changer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSrcFlder;
        private TextBox textBoxSrcFlder;
        private TextBox textBoxDstFlder;
        private TextBox textBoxSrcFileList;
        private TextBox textBoxDstFileList;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
