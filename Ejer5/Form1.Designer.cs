namespace Ejer5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelIndices = new System.Windows.Forms.Label();
            this.TrasparAl2 = new System.Windows.Forms.Button();
            this.TraspasarAl1 = new System.Windows.Forms.Button();
            this.btAñadir = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(78, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(458, 47);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(214, 47);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 2;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelIndices
            // 
            this.labelIndices.AutoSize = true;
            this.labelIndices.Location = new System.Drawing.Point(406, 47);
            this.labelIndices.Name = "labelIndices";
            this.labelIndices.Size = new System.Drawing.Size(41, 13);
            this.labelIndices.TabIndex = 3;
            this.labelIndices.Text = "Indices";
            // 
            // TrasparAl2
            // 
            this.TrasparAl2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TrasparAl2.Location = new System.Drawing.Point(78, 161);
            this.TrasparAl2.Name = "TrasparAl2";
            this.TrasparAl2.Size = new System.Drawing.Size(120, 23);
            this.TrasparAl2.TabIndex = 4;
            this.TrasparAl2.Text = "Traspasar -->";
            this.TrasparAl2.UseVisualStyleBackColor = true;
            this.TrasparAl2.Click += new System.EventHandler(this.TrasparAl2_Click);
            // 
            // TraspasarAl1
            // 
            this.TraspasarAl1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TraspasarAl1.Location = new System.Drawing.Point(458, 161);
            this.TraspasarAl1.Name = "TraspasarAl1";
            this.TraspasarAl1.Size = new System.Drawing.Size(120, 23);
            this.TraspasarAl1.TabIndex = 5;
            this.TraspasarAl1.Text = "<-- Traspasar";
            this.TraspasarAl1.UseVisualStyleBackColor = true;
            this.TraspasarAl1.Click += new System.EventHandler(this.TraspasarAl1_Click);
            // 
            // btAñadir
            // 
            this.btAñadir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAñadir.Location = new System.Drawing.Point(289, 74);
            this.btAñadir.Name = "btAñadir";
            this.btAñadir.Size = new System.Drawing.Size(75, 23);
            this.btAñadir.TabIndex = 6;
            this.btAñadir.Text = "Añadir";
            this.btAñadir.UseVisualStyleBackColor = true;
            this.btAñadir.Click += new System.EventHandler(this.btAñadir_Click);
            // 
            // btQuitar
            // 
            this.btQuitar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btQuitar.Location = new System.Drawing.Point(289, 119);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(75, 23);
            this.btQuitar.TabIndex = 7;
            this.btQuitar.Text = "Quitar";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.btAñadir);
            this.Controls.Add(this.TraspasarAl1);
            this.Controls.Add(this.TrasparAl2);
            this.Controls.Add(this.labelIndices);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio 5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelIndices;
        private System.Windows.Forms.Button TrasparAl2;
        private System.Windows.Forms.Button TraspasarAl1;
        private System.Windows.Forms.Button btAñadir;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

