
namespace Algimed
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewListData = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.dataGridViewDataBase = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadData = new System.Windows.Forms.Button();
            this.CreateMatrix = new System.Windows.Forms.Button();
            this.SaveDataBase = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonClosePanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.databaseDataSet = new Algimed.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListData
            // 
            this.dataGridViewListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListData.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewListData.Name = "dataGridViewListData";
            this.dataGridViewListData.Size = new System.Drawing.Size(329, 232);
            this.dataGridViewListData.TabIndex = 0;
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(347, 12);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidth = 60;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(329, 232);
            this.dataGridViewMatrix.TabIndex = 1;
            // 
            // dataGridViewDataBase
            // 
            this.dataGridViewDataBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cells,
            this.Value});
            this.dataGridViewDataBase.Location = new System.Drawing.Point(682, 12);
            this.dataGridViewDataBase.Name = "dataGridViewDataBase";
            this.dataGridViewDataBase.Size = new System.Drawing.Size(329, 232);
            this.dataGridViewDataBase.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Cells
            // 
            this.Cells.HeaderText = "Cells";
            this.Cells.Name = "Cells";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // LoadData
            // 
            this.LoadData.Location = new System.Drawing.Point(135, 250);
            this.LoadData.Name = "LoadData";
            this.LoadData.Size = new System.Drawing.Size(75, 23);
            this.LoadData.TabIndex = 3;
            this.LoadData.Text = "LoadData";
            this.LoadData.UseVisualStyleBackColor = true;
            this.LoadData.Click += new System.EventHandler(this.LoadData_Click);
            // 
            // CreateMatrix
            // 
            this.CreateMatrix.Location = new System.Drawing.Point(463, 250);
            this.CreateMatrix.Name = "CreateMatrix";
            this.CreateMatrix.Size = new System.Drawing.Size(75, 23);
            this.CreateMatrix.TabIndex = 4;
            this.CreateMatrix.Text = "CreateMatrix";
            this.CreateMatrix.UseVisualStyleBackColor = true;
            this.CreateMatrix.Click += new System.EventHandler(this.CreateMatrix_Click);
            // 
            // SaveDataBase
            // 
            this.SaveDataBase.Location = new System.Drawing.Point(802, 250);
            this.SaveDataBase.Name = "SaveDataBase";
            this.SaveDataBase.Size = new System.Drawing.Size(89, 23);
            this.SaveDataBase.TabIndex = 5;
            this.SaveDataBase.Text = "SaveDataBase";
            this.SaveDataBase.UseVisualStyleBackColor = true;
            this.SaveDataBase.Click += new System.EventHandler(this.SaveDataBase_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.buttonClosePanel);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.User);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxName);
            this.panelLogin.Location = new System.Drawing.Point(381, 72);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(252, 186);
            this.panelLogin.TabIndex = 6;
            this.panelLogin.Visible = false;
            // 
            // buttonClosePanel
            // 
            this.buttonClosePanel.Location = new System.Drawing.Point(140, 148);
            this.buttonClosePanel.Name = "buttonClosePanel";
            this.buttonClosePanel.Size = new System.Drawing.Size(89, 23);
            this.buttonClosePanel.TabIndex = 11;
            this.buttonClosePanel.Text = "Close";
            this.buttonClosePanel.UseVisualStyleBackColor = true;
            this.buttonClosePanel.Click += new System.EventHandler(this.buttonClosePanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 50);
            this.label1.TabIndex = 10;
            this.label1.Text = "Log in to access \r\nthe database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(24, 63);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(29, 13);
            this.User.TabIndex = 8;
            this.User.Text = "User";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(24, 149);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(89, 23);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(25, 123);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(204, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(24, 82);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(205, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 319);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.SaveDataBase);
            this.Controls.Add(this.CreateMatrix);
            this.Controls.Add(this.LoadData);
            this.Controls.Add(this.dataGridViewDataBase);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.dataGridViewListData);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBase)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListData;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.DataGridView dataGridViewDataBase;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button CreateMatrix;
        private System.Windows.Forms.Button SaveDataBase;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cells;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClosePanel;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
    }
}

