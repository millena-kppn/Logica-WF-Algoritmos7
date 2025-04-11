namespace WF_Login
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtBoxOne = new TextBox();
            txtBoxTwo = new TextBox();
            btnVerificar = new Button();
            linkLabel1 = new LinkLabel();
            pictureBoxSair = new PictureBox();
            pictureBoxMin = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(47, 157);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(174, 165);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // txtBoxOne
            // 
            txtBoxOne.ForeColor = SystemColors.AppWorkspace;
            txtBoxOne.Location = new Point(360, 178);
            txtBoxOne.Name = "txtBoxOne";
            txtBoxOne.Size = new Size(353, 31);
            txtBoxOne.TabIndex = 1;
            txtBoxOne.Text = "Nome...";
            txtBoxOne.Enter += txtBoxOne_Enter;
            txtBoxOne.Leave += txtBoxOne_Leave;
            // 
            // txtBoxTwo
            // 
            txtBoxTwo.ForeColor = SystemColors.AppWorkspace;
            txtBoxTwo.Location = new Point(360, 237);
            txtBoxTwo.Name = "txtBoxTwo";
            txtBoxTwo.Size = new Size(353, 31);
            txtBoxTwo.TabIndex = 2;
            txtBoxTwo.Text = "Senha...";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(491, 288);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(112, 34);
            btnVerificar.TabIndex = 3;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(456, 348);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(176, 25);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Esqueci minha senha";
            // 
            // pictureBoxSair
            // 
            pictureBoxSair.Image = (Image)resources.GetObject("pictureBoxSair.Image");
            pictureBoxSair.Location = new Point(766, 0);
            pictureBoxSair.Name = "pictureBoxSair";
            pictureBoxSair.Size = new Size(35, 31);
            pictureBoxSair.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSair.TabIndex = 5;
            pictureBoxSair.TabStop = false;
            pictureBoxSair.Click += pictureBoxSair_Click;
            // 
            // pictureBoxMin
            // 
            pictureBoxMin.Image = (Image)resources.GetObject("pictureBoxMin.Image");
            pictureBoxMin.Location = new Point(744, 0);
            pictureBoxMin.Name = "pictureBoxMin";
            pictureBoxMin.Size = new Size(26, 31);
            pictureBoxMin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMin.TabIndex = 6;
            pictureBoxMin.TabStop = false;
            pictureBoxMin.Click += pictureBoxMin_Click;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxMin);
            Controls.Add(pictureBoxSair);
            Controls.Add(linkLabel1);
            Controls.Add(btnVerificar);
            Controls.Add(txtBoxTwo);
            Controls.Add(txtBoxOne);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formulario";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSair).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtBoxOne;
        private TextBox txtBoxTwo;
        private Button btnVerificar;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxSair;
        private PictureBox pictureBoxMin;
    }
}
