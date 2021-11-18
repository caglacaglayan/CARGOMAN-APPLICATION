
using CARGOMAN;

namespace CARGOMAN
{
    partial class Status
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.cargoManDataSet = new CARGOMAN.CargoManDataSet();
            this.cargoManDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toMapButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toAddButton = new System.Windows.Forms.Button();
            this.Guncelbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cargoManDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoManDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cargoManDataSet
            // 
            this.cargoManDataSet.DataSetName = "CargoManDataSet";
            this.cargoManDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargoManDataSetBindingSource
            // 
            this.cargoManDataSetBindingSource.DataSource = this.cargoManDataSet;
            this.cargoManDataSetBindingSource.Position = 0;
            // 
            // listButton
            // 
            this.listButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listButton.Location = new System.Drawing.Point(293, 533);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(180, 52);
            this.listButton.TabIndex = 1;
            this.listButton.Text = "List/Refresh";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(702, 415);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // toMapButton
            // 
            this.toMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toMapButton.Location = new System.Drawing.Point(827, 406);
            this.toMapButton.Name = "toMapButton";
            this.toMapButton.Size = new System.Drawing.Size(243, 60);
            this.toMapButton.TabIndex = 14;
            this.toMapButton.Text = "Open on Map";
            this.toMapButton.UseVisualStyleBackColor = true;
            this.toMapButton.Click += new System.EventHandler(this.toMapButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(846, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add New Cargo";
            // 
            // toAddButton
            // 
            this.toAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toAddButton.Location = new System.Drawing.Point(874, 94);
            this.toAddButton.Name = "toAddButton";
            this.toAddButton.Size = new System.Drawing.Size(161, 50);
            this.toAddButton.TabIndex = 16;
            this.toAddButton.Text = "Add Cargo";
            this.toAddButton.UseVisualStyleBackColor = true;
            this.toAddButton.Click += new System.EventHandler(this.toAddButton_Click);
            // 
            // Guncelbutton
            // 
            this.Guncelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Guncelbutton.Location = new System.Drawing.Point(966, 314);
            this.Guncelbutton.Name = "Guncelbutton";
            this.Guncelbutton.Size = new System.Drawing.Size(107, 61);
            this.Guncelbutton.TabIndex = 18;
            this.Guncelbutton.Text = "Change Status";
            this.Guncelbutton.UseVisualStyleBackColor = true;
            this.Guncelbutton.Click += new System.EventHandler(this.Guncelbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(795, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Change Delivery Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(874, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // DelButton
            // 
            this.DelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DelButton.Location = new System.Drawing.Point(874, 202);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(161, 50);
            this.DelButton.TabIndex = 28;
            this.DelButton.Text = "Delete Cargo";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(846, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Delete a Cargo";
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusBox.Location = new System.Drawing.Point(827, 329);
            this.statusBox.Multiline = true;
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(133, 35);
            this.statusBox.TabIndex = 29;
            // 
            // logoutbutton
            // 
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutbutton.Location = new System.Drawing.Point(49, 540);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(116, 40);
            this.logoutbutton.TabIndex = 30;
            this.logoutbutton.Text = "Log Out";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(237, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 37);
            this.label4.TabIndex = 31;
            this.label4.Text = "LIST OF CARGOES";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1148, 609);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Guncelbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toMapButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listButton);
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Status Screen";
            ((System.ComponentModel.ISupportInitialize)(this.cargoManDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoManDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource cargoManDataSetBindingSource;
        private CargoManDataSet cargoManDataSet;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button toMapButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toAddButton;
        private System.Windows.Forms.Button Guncelbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Label label4;
    }
}