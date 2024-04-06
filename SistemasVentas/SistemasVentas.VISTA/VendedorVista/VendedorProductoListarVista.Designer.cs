namespace SistemasVentas.VISTA.VendedorVista
{
    partial class VendedorProductoListarVista
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
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 120);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Chocolate;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 26);
            label2.Name = "label2";
            label2.Size = new Size(459, 54);
            label2.TabIndex = 13;
            label2.Text = "LISTA DE PRODUCTOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(2, 116);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 485);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(235, 399);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(114, 45);
            button1.TabIndex = 19;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Chocolate;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(64, 399);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(111, 45);
            button3.TabIndex = 18;
            button3.Text = "GUARDAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(424, 355);
            dataGridView1.TabIndex = 11;
            // 
            // VendedorProductoListarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 600);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VendedorProductoListarVista";
            Text = "VendedorProductoListarVista";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
    }
}