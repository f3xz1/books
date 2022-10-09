namespace books
{
    partial class Form1
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
            this.List_of_cotegoris_combobox = new System.Windows.Forms.ComboBox();
            this.Items_combobox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // List_of_cotegoris_combobox
            // 
            this.List_of_cotegoris_combobox.FormattingEnabled = true;
            this.List_of_cotegoris_combobox.Location = new System.Drawing.Point(12, 12);
            this.List_of_cotegoris_combobox.Name = "List_of_cotegoris_combobox";
            this.List_of_cotegoris_combobox.Size = new System.Drawing.Size(150, 23);
            this.List_of_cotegoris_combobox.TabIndex = 0;
            this.List_of_cotegoris_combobox.SelectedIndexChanged += new System.EventHandler(this.List_of_cotegoris_combobox_SelectedIndexChanged);
            // 
            // Items_combobox
            // 
            this.Items_combobox.FormattingEnabled = true;
            this.Items_combobox.Location = new System.Drawing.Point(269, 12);
            this.Items_combobox.Name = "Items_combobox";
            this.Items_combobox.Size = new System.Drawing.Size(149, 23);
            this.Items_combobox.TabIndex = 1;
            this.Items_combobox.SelectedIndexChanged += new System.EventHandler(this.Items_combobox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(406, 301);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Items_combobox);
            this.Controls.Add(this.List_of_cotegoris_combobox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox List_of_cotegoris_combobox;
        private ComboBox Items_combobox;
        private DataGridView dataGridView1;
    }
}