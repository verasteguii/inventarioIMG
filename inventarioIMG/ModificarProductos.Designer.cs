
namespace inventarioIMG
{
    partial class ModificarProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbprod = new System.Windows.Forms.ComboBox();
            this.textproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textcategoria = new System.Windows.Forms.TextBox();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.textstock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // cmbprod
            // 
            this.cmbprod.FormattingEnabled = true;
            this.cmbprod.Location = new System.Drawing.Point(166, 55);
            this.cmbprod.Name = "cmbprod";
            this.cmbprod.Size = new System.Drawing.Size(121, 23);
            this.cmbprod.TabIndex = 1;
            // 
            // textproducto
            // 
            this.textproducto.Location = new System.Drawing.Point(166, 102);
            this.textproducto.Name = "textproducto";
            this.textproducto.Size = new System.Drawing.Size(100, 23);
            this.textproducto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock";
            // 
            // textcategoria
            // 
            this.textcategoria.Location = new System.Drawing.Point(166, 144);
            this.textcategoria.Name = "textcategoria";
            this.textcategoria.Size = new System.Drawing.Size(100, 23);
            this.textcategoria.TabIndex = 7;
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(166, 184);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(100, 23);
            this.textprecio.TabIndex = 8;
            // 
            // textstock
            // 
            this.textstock.Location = new System.Drawing.Point(166, 227);
            this.textstock.Name = "textstock";
            this.textstock.Size = new System.Drawing.Size(100, 23);
            this.textstock.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textstock);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.textcategoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textproducto);
            this.Controls.Add(this.cmbprod);
            this.Controls.Add(this.label1);
            this.Name = "ModificarProductos";
            this.Text = "ModificarProductos";
            this.Load += new System.EventHandler(this.ModificarProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbprod;
        private System.Windows.Forms.TextBox textproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textcategoria;
        private System.Windows.Forms.TextBox textprecio;
        private System.Windows.Forms.TextBox textstock;
        private System.Windows.Forms.Button button1;
    }
}