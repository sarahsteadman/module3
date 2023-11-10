namespace Library_GUI
{
  partial class Search
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchBy = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(253, 127);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(213, 26);
            this.searchBox.TabIndex = 1;
            // 
            // searchBy
            // 
            this.searchBy.AutoSize = true;
            this.searchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBy.Location = new System.Drawing.Point(43, 97);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(103, 25);
            this.searchBy.TabIndex = 2;
            this.searchBy.Text = "Search By";
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(248, 99);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(126, 25);
            this.input.TabIndex = 3;
            this.input.Text = "Enter Search";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(502, 115);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(107, 38);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 279);
            this.dataGridView1.TabIndex = 5;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(21, 24);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(119, 42);
            this.menu.TabIndex = 19;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1324, 489);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.searchBy);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.comboBox1);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox searchBox;
    private System.Windows.Forms.Label searchBy;
    private System.Windows.Forms.Label input;
    private System.Windows.Forms.Button searchBtn;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button menu;
  }
}
