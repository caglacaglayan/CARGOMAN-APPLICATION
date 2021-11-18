
namespace CARGOMAN
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Gmap1 = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.toStatusButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitbutton = new System.Windows.Forms.Button();
            this.LatBox = new System.Windows.Forms.TextBox();
            this.LongBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddlocButton = new System.Windows.Forms.Button();
            this.Routebutton = new System.Windows.Forms.Button();
            this.Removebutton = new System.Windows.Forms.Button();
            this.chooseLocbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(700, 683);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Gmap1
            // 
            this.Gmap1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gmap1.Bearing = 0F;
            this.Gmap1.CanDragMap = true;
            this.Gmap1.EmptyTileColor = System.Drawing.Color.Navy;
            this.Gmap1.GrayScaleMode = false;
            this.Gmap1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Gmap1.LevelsKeepInMemory = 5;
            this.Gmap1.Location = new System.Drawing.Point(0, 0);
            this.Gmap1.MarkersEnabled = true;
            this.Gmap1.MaxZoom = 2;
            this.Gmap1.MinZoom = 2;
            this.Gmap1.MouseWheelZoomEnabled = true;
            this.Gmap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Gmap1.Name = "Gmap1";
            this.Gmap1.NegativeMode = false;
            this.Gmap1.PolygonsEnabled = true;
            this.Gmap1.RetryLoadTile = 0;
            this.Gmap1.RoutesEnabled = true;
            this.Gmap1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Gmap1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Gmap1.ShowTileGridLines = false;
            this.Gmap1.Size = new System.Drawing.Size(864, 683);
            this.Gmap1.TabIndex = 1;
            this.Gmap1.Zoom = 0D;
            this.Gmap1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Gmap1_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(932, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delivery Status\r\n      Screen";
            // 
            // toStatusButton
            // 
            this.toStatusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toStatusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toStatusButton.Location = new System.Drawing.Point(937, 523);
            this.toStatusButton.Name = "toStatusButton";
            this.toStatusButton.Size = new System.Drawing.Size(138, 43);
            this.toStatusButton.TabIndex = 3;
            this.toStatusButton.Text = "Go";
            this.toStatusButton.UseVisualStyleBackColor = true;
            this.toStatusButton.Click += new System.EventHandler(this.toStatusButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(926, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(927, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Latitude";
            // 
            // submitbutton
            // 
            this.submitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitbutton.Location = new System.Drawing.Point(954, 170);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(105, 36);
            this.submitbutton.TabIndex = 28;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // LatBox
            // 
            this.LatBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LatBox.Location = new System.Drawing.Point(932, 71);
            this.LatBox.Multiline = true;
            this.LatBox.Name = "LatBox";
            this.LatBox.Size = new System.Drawing.Size(143, 31);
            this.LatBox.TabIndex = 29;
            // 
            // LongBox
            // 
            this.LongBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LongBox.Location = new System.Drawing.Point(932, 133);
            this.LongBox.Multiline = true;
            this.LongBox.Name = "LongBox";
            this.LongBox.Size = new System.Drawing.Size(143, 31);
            this.LongBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(927, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Longitude";
            // 
            // AddlocButton
            // 
            this.AddlocButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddlocButton.Location = new System.Drawing.Point(932, 212);
            this.AddlocButton.Name = "AddlocButton";
            this.AddlocButton.Size = new System.Drawing.Size(143, 38);
            this.AddlocButton.TabIndex = 32;
            this.AddlocButton.Text = "Add Location";
            this.AddlocButton.UseVisualStyleBackColor = true;
            this.AddlocButton.Click += new System.EventHandler(this.AddlocButton_Click);
            // 
            // Routebutton
            // 
            this.Routebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Routebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Routebutton.Location = new System.Drawing.Point(932, 328);
            this.Routebutton.Name = "Routebutton";
            this.Routebutton.Size = new System.Drawing.Size(143, 52);
            this.Routebutton.TabIndex = 33;
            this.Routebutton.Text = "Get Route";
            this.Routebutton.UseVisualStyleBackColor = true;
            this.Routebutton.Click += new System.EventHandler(this.Routebutton_Click);
            // 
            // Removebutton
            // 
            this.Removebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Removebutton.Location = new System.Drawing.Point(954, 256);
            this.Removebutton.Name = "Removebutton";
            this.Removebutton.Size = new System.Drawing.Size(105, 38);
            this.Removebutton.TabIndex = 34;
            this.Removebutton.Text = "Remove";
            this.Removebutton.UseVisualStyleBackColor = true;
            this.Removebutton.Click += new System.EventHandler(this.Removebutton_Click);
            // 
            // chooseLocbutton
            // 
            this.chooseLocbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseLocbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chooseLocbutton.Location = new System.Drawing.Point(932, 402);
            this.chooseLocbutton.Name = "chooseLocbutton";
            this.chooseLocbutton.Size = new System.Drawing.Size(143, 65);
            this.chooseLocbutton.TabIndex = 35;
            this.chooseLocbutton.Text = "Choose Location";
            this.chooseLocbutton.UseVisualStyleBackColor = true;
            this.chooseLocbutton.Click += new System.EventHandler(this.chooseLocbutton_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1153, 683);
            this.Controls.Add(this.chooseLocbutton);
            this.Controls.Add(this.Removebutton);
            this.Controls.Add(this.Routebutton);
            this.Controls.Add(this.AddlocButton);
            this.Controls.Add(this.LongBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LatBox);
            this.Controls.Add(this.submitbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toStatusButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gmap1);
            this.Controls.Add(this.splitter1);
            this.Name = "Map";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Address Screen";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private GMap.NET.WindowsForms.GMapControl Gmap1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button toStatusButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.TextBox LatBox;
        private System.Windows.Forms.TextBox LongBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddlocButton;
        private System.Windows.Forms.Button Routebutton;
        private System.Windows.Forms.Button Removebutton;
        private System.Windows.Forms.Button chooseLocbutton;
    }
}