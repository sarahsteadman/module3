namespace Library_GUI
{
  partial class Members
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memId = new System.Windows.Forms.Label();
            this.card = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.searchBtn.Location = new System.Drawing.Point(493, 118);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(107, 41);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.input.Location = new System.Drawing.Point(263, 99);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(126, 25);
            this.input.TabIndex = 9;
            this.input.Text = "Enter Search";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(268, 127);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(186, 26);
            this.searchBox.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // searchBy
            // 
            this.searchBy.AutoSize = true;
            this.searchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchBy.Location = new System.Drawing.Point(22, 99);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(103, 25);
            this.searchBy.TabIndex = 8;
            this.searchBy.Text = "Search By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Books Borrowed";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(570, 168);
            this.dataGridView1.TabIndex = 13;
            // 
            // memId
            // 
            this.memId.AutoSize = true;
            this.memId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memId.Location = new System.Drawing.Point(28, 254);
            this.memId.Name = "memId";
            this.memId.Size = new System.Drawing.Size(114, 25);
            this.memId.TabIndex = 15;
            this.memId.Text = "Member ID:";
            // 
            // card
            // 
            this.card.AutoSize = true;
            this.card.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card.Location = new System.Drawing.Point(28, 302);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(135, 25);
            this.card.TabIndex = 16;
            this.card.Text = "Card Number:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(28, 351);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 25);
            this.name.TabIndex = 17;
            this.name.Text = "Name:";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(27, 22);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(119, 42);
            this.menu.TabIndex = 18;
            this.menu.Text = "Main Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(966, 460);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.name);
            this.Controls.Add(this.card);
            this.Controls.Add(this.memId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.searchBy);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.comboBox1);
            this.Name = "Members";
            this.Text = "Members";
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button searchBtn;
    private System.Windows.Forms.Label input;
    private System.Windows.Forms.TextBox searchBox;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label searchBy;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label memId;
    private System.Windows.Forms.Label card;
    private System.Windows.Forms.Label name;
    private System.Windows.Forms.Button menu;
  }
}
