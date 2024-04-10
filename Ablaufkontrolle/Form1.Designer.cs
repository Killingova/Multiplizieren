
namespace Ablaufkontrolle
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
            CmdZufallAufabe = new Button();
            CmdErgenis = new Button();
            PFarbe = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // CmdZufallAufabe
            // 
            CmdZufallAufabe.Location = new Point(48, 297);
            CmdZufallAufabe.Name = "CmdZufallAufabe";
            CmdZufallAufabe.Size = new Size(137, 29);
            CmdZufallAufabe.TabIndex = 0;
            CmdZufallAufabe.Text = "Aufgabe";
            CmdZufallAufabe.UseVisualStyleBackColor = true;
            CmdZufallAufabe.Click += CmdZufallAufabe_Click;
            // 
            // CmdErgenis
            // 
            CmdErgenis.Location = new Point(237, 297);
            CmdErgenis.Name = "CmdErgenis";
            CmdErgenis.Size = new Size(97, 29);
            CmdErgenis.TabIndex = 1;
            CmdErgenis.Text = "Ergebnis";
            CmdErgenis.UseVisualStyleBackColor = true;
            CmdErgenis.Click += CmdErgenis_Click;
            // 
            // PFarbe
            // 
            PFarbe.Location = new Point(386, 76);
            PFarbe.Name = "PFarbe";
            PFarbe.Size = new Size(302, 128);
            PFarbe.TabIndex = 2;
            PFarbe.Paint += PFarbe_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(386, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(PFarbe);
            Controls.Add(CmdErgenis);
            Controls.Add(CmdZufallAufabe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Button CmdZufallAufabe;
        private Button CmdErgenis;
        private Panel PFarbe;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
