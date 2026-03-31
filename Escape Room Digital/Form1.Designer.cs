namespace Escape_Room_Digital
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.Location = new Point(549, 394);
            button1.Name = "button1";
            button1.Size = new Size(303, 50);
            button1.TabIndex = 0;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            label1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(250, 209);
            label1.Name = "label1";
            label1.Size = new Size(1005, 98);
            label1.TabIndex = 1;
            label1.Text = "ESCAPE ROOM DIGITAL💡 ";
            label1.Click += label1_Click;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1381, 647);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "inicio";
            Text = "ESCAPE ROOM 💡";
            TransparencyKey = Color.FromArgb(128, 128, 255);
            Load += inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}
