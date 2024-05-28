namespace VAPW_ZK
{
    partial class Hrac
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
            components = new System.ComponentModel.Container();
            Score_text = new TextBox();
            Send_button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Num_text = new TextBox();
            label1 = new Label();
            gameName = new TextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Score_text
            // 
            Score_text.Location = new Point(308, 225);
            Score_text.Name = "Score_text";
            Score_text.Size = new Size(83, 27);
            Score_text.TabIndex = 0;
            // 
            // Send_button
            // 
            Send_button.Location = new Point(277, 258);
            Send_button.Name = "Send_button";
            Send_button.Size = new Size(132, 56);
            Send_button.TabIndex = 1;
            Send_button.Text = "Send";
            Send_button.UseVisualStyleBackColor = true;
            Send_button.Click += button1_Click;
            // 
            // Num_text
            // 
            Num_text.Location = new Point(277, 124);
            Num_text.Name = "Num_text";
            Num_text.Size = new Size(125, 27);
            Num_text.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 166);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 3;
            label1.Text = "Score";
            // 
            // gameName
            // 
            gameName.Location = new Point(277, 12);
            gameName.Name = "gameName";
            gameName.Size = new Size(125, 27);
            gameName.TabIndex = 4;
            gameName.Text = "Hrac";
            gameName.TextChanged += gameName_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(439, 370);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(451, 124);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 101);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 7;
            label2.Text = "interval = 0.1 sec *";
            // 
            // Hrac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(gameName);
            Controls.Add(label1);
            Controls.Add(Num_text);
            Controls.Add(Send_button);
            Controls.Add(Score_text);
            Name = "Hrac";
            Text = "Hrac";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Score_text;
        private Button Send_button;
        private System.Windows.Forms.Timer timer1;
        private TextBox Num_text;
        private Label label1;
        private TextBox gameName;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
    }
}