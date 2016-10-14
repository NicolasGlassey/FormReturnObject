namespace FormReturnObject
{
    partial class FrmCar
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
            this.cmdUpdateCar = new System.Windows.Forms.Button();
            this.txtBBrand = new System.Windows.Forms.TextBox();
            this.txtBModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdUpdateCar
            // 
            this.cmdUpdateCar.Location = new System.Drawing.Point(50, 76);
            this.cmdUpdateCar.Name = "cmdUpdateCar";
            this.cmdUpdateCar.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateCar.TabIndex = 0;
            this.cmdUpdateCar.Text = "Update Car";
            this.cmdUpdateCar.UseVisualStyleBackColor = true;
            this.cmdUpdateCar.Click += new System.EventHandler(this.cmdUpdateCar_Click);
            // 
            // txtBBrand
            // 
            this.txtBBrand.Enabled = false;
            this.txtBBrand.Location = new System.Drawing.Point(39, 12);
            this.txtBBrand.Name = "txtBBrand";
            this.txtBBrand.Size = new System.Drawing.Size(153, 20);
            this.txtBBrand.TabIndex = 1;
            // 
            // txtBModel
            // 
            this.txtBModel.Enabled = false;
            this.txtBModel.Location = new System.Drawing.Point(39, 38);
            this.txtBModel.Name = "txtBModel";
            this.txtBModel.Size = new System.Drawing.Size(153, 20);
            this.txtBModel.TabIndex = 2;
            // 
            // FrmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 108);
            this.Controls.Add(this.txtBModel);
            this.Controls.Add(this.txtBBrand);
            this.Controls.Add(this.cmdUpdateCar);
            this.Name = "FrmCar";
            this.Text = "Show Car";
            this.Load += new System.EventHandler(this.FrmCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdUpdateCar;
        private System.Windows.Forms.TextBox txtBBrand;
        private System.Windows.Forms.TextBox txtBModel;
    }
}

