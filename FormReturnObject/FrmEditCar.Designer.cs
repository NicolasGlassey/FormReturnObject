namespace FormReturnObject
{
    partial class FrmEditCar
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
            this.txtBModel = new System.Windows.Forms.TextBox();
            this.txtBBrand = new System.Windows.Forms.TextBox();
            this.cmdUpdateCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBModel
            // 
            this.txtBModel.Location = new System.Drawing.Point(59, 44);
            this.txtBModel.Name = "txtBModel";
            this.txtBModel.Size = new System.Drawing.Size(100, 20);
            this.txtBModel.TabIndex = 5;
            // 
            // txtBBrand
            // 
            this.txtBBrand.Location = new System.Drawing.Point(59, 18);
            this.txtBBrand.Name = "txtBBrand";
            this.txtBBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBBrand.TabIndex = 4;
            // 
            // cmdUpdateCar
            // 
            this.cmdUpdateCar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdUpdateCar.Location = new System.Drawing.Point(70, 82);
            this.cmdUpdateCar.Name = "cmdUpdateCar";
            this.cmdUpdateCar.Size = new System.Drawing.Size(75, 23);
            this.cmdUpdateCar.TabIndex = 3;
            this.cmdUpdateCar.Text = "Update Car";
            this.cmdUpdateCar.UseVisualStyleBackColor = true;
            this.cmdUpdateCar.Click += new System.EventHandler(this.cmdUpdateCar_Click);
            // 
            // FrmEditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 122);
            this.Controls.Add(this.txtBModel);
            this.Controls.Add(this.txtBBrand);
            this.Controls.Add(this.cmdUpdateCar);
            this.Name = "FrmEditCar";
            this.Text = "FrmEditCar";
            this.Load += new System.EventHandler(this.FrmEditCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBModel;
        private System.Windows.Forms.TextBox txtBBrand;
        private System.Windows.Forms.Button cmdUpdateCar;
    }
}