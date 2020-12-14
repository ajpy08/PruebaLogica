
namespace PruebaLogica
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
      this.LblCasos = new System.Windows.Forms.Label();
      this.TxtCasos = new System.Windows.Forms.TextBox();
      this.btnGo = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // LblCasos
      // 
      this.LblCasos.AutoSize = true;
      this.LblCasos.Location = new System.Drawing.Point(69, 30);
      this.LblCasos.Name = "LblCasos";
      this.LblCasos.Size = new System.Drawing.Size(59, 13);
      this.LblCasos.TabIndex = 0;
      this.LblCasos.Text = "No. Casos:";
      // 
      // TxtCasos
      // 
      this.TxtCasos.Location = new System.Drawing.Point(134, 27);
      this.TxtCasos.Name = "TxtCasos";
      this.TxtCasos.Size = new System.Drawing.Size(100, 20);
      this.TxtCasos.TabIndex = 1;
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(159, 66);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 2;
      this.btnGo.Text = "Go";
      this.btnGo.UseVisualStyleBackColor = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 120);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 20);
      this.label1.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(324, 159);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.TxtCasos);
      this.Controls.Add(this.LblCasos);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Prueba Lógica";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblCasos;
    private System.Windows.Forms.TextBox TxtCasos;
    private System.Windows.Forms.Button btnGo;
    private System.Windows.Forms.Label label1;
  }
}

