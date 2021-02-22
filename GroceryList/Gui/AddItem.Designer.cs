
namespace GroceryList.Gui
{
    partial class AddItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.labName = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 3;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayout.Controls.Add(this.labName, 0, 0);
            this.tableLayout.Controls.Add(this.labPrice, 1, 0);
            this.tableLayout.Controls.Add(this.txtName, 0, 1);
            this.tableLayout.Controls.Add(this.txtPrice, 1, 1);
            this.tableLayout.Controls.Add(this.button1, 2, 1);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(358, 80);
            this.tableLayout.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(45, 13);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(35, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name";
            // 
            // labPrice
            // 
            this.labPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(172, 13);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(31, 13);
            this.labPrice.TabIndex = 1;
            this.labPrice.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(3, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(128, 43);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(253, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayout);
            this.Name = "AddItem";
            this.Size = new System.Drawing.Size(358, 80);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
    }
}
