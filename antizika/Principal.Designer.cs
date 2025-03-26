namespace antizika
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btn_Calcular_Hash = new Button();
            btn_Escanear = new Button();
            btn_EscanPasta = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Calcular_Hash
            // 
            btn_Calcular_Hash.BackColor = Color.Tomato;
            btn_Calcular_Hash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Calcular_Hash.Location = new Point(46, 30);
            btn_Calcular_Hash.Name = "btn_Calcular_Hash";
            btn_Calcular_Hash.Size = new Size(161, 203);
            btn_Calcular_Hash.TabIndex = 0;
            btn_Calcular_Hash.Text = "Calcular Hash";
            btn_Calcular_Hash.UseVisualStyleBackColor = false;
            btn_Calcular_Hash.Click += btn_Calcular_Hash_Click;
            // 
            // btn_Escanear
            // 
            btn_Escanear.BackColor = Color.Tomato;
            btn_Escanear.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Escanear.Location = new Point(310, 30);
            btn_Escanear.Name = "btn_Escanear";
            btn_Escanear.Size = new Size(161, 203);
            btn_Escanear.TabIndex = 1;
            btn_Escanear.Text = "Escanear";
            btn_Escanear.UseVisualStyleBackColor = false;
            // 
            // btn_EscanPasta
            // 
            btn_EscanPasta.BackColor = Color.Tomato;
            btn_EscanPasta.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EscanPasta.Location = new Point(571, 30);
            btn_EscanPasta.Name = "btn_EscanPasta";
            btn_EscanPasta.Size = new Size(161, 203);
            btn_EscanPasta.TabIndex = 2;
            btn_EscanPasta.Text = "Escanear Pasta";
            btn_EscanPasta.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 362);
            label1.Name = "label1";
            label1.Size = new Size(265, 40);
            label1.TabIndex = 3;
            label1.Text = "AntiVirus Zika";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_EscanPasta);
            Controls.Add(btn_Escanear);
            Controls.Add(btn_Calcular_Hash);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Antizika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calcular_Hash;
        private Button btn_Escanear;
        private Button btn_EscanPasta;
        private Label label1;
    }
}
