
namespace Tyuiu.Martysevich.Sprint6.TaskReview.V20
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView_MAD = new System.Windows.Forms.DataGridView();
            this.groupBoxIn_MAD = new System.Windows.Forms.GroupBox();
            this.textBoxRow_MAD = new System.Windows.Forms.TextBox();
            this.textBoxColumn_MAD = new System.Windows.Forms.TextBox();
            this.textBoxFinish_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStart_MAD = new System.Windows.Forms.TextBox();
            this.textBoxSelectL_MAD = new System.Windows.Forms.TextBox();
            this.textBoxSelectK_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStr_MAD = new System.Windows.Forms.TextBox();
            this.textBoxInf_MAD = new System.Windows.Forms.TextBox();
            this.buttonDo_MAD = new System.Windows.Forms.Button();
            this.textBoxResult_MAD = new System.Windows.Forms.TextBox();
            this.textBoxRes_MAD = new System.Windows.Forms.TextBox();
            this.textBoxL_MAD = new System.Windows.Forms.TextBox();
            this.textBoxK_MAD = new System.Windows.Forms.TextBox();
            this.textBoxSelectedRow_MAD = new System.Windows.Forms.TextBox();
            this.textBoxFinishIn_MAD = new System.Windows.Forms.TextBox();
            this.textBoxStartIn_MAD = new System.Windows.Forms.TextBox();
            this.textBoxColumnIn_MAD = new System.Windows.Forms.TextBox();
            this.textBoxRowIn_MAD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MAD)).BeginInit();
            this.groupBoxIn_MAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_MAD
            // 
            this.dataGridView_MAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MAD.Location = new System.Drawing.Point(13, 225);
            this.dataGridView_MAD.Name = "dataGridView_MAD";
            this.dataGridView_MAD.RowHeadersWidth = 51;
            this.dataGridView_MAD.RowTemplate.Height = 24;
            this.dataGridView_MAD.Size = new System.Drawing.Size(857, 354);
            this.dataGridView_MAD.TabIndex = 0;
            this.dataGridView_MAD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBoxIn_MAD
            // 
            this.groupBoxIn_MAD.Controls.Add(this.textBoxRowIn_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxL_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxK_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxSelectedRow_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxFinishIn_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxStartIn_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxColumnIn_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxRow_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxColumn_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxFinish_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxStart_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxSelectL_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxSelectK_MAD);
            this.groupBoxIn_MAD.Controls.Add(this.textBoxStr_MAD);
            this.groupBoxIn_MAD.Location = new System.Drawing.Point(13, 94);
            this.groupBoxIn_MAD.Name = "groupBoxIn_MAD";
            this.groupBoxIn_MAD.Size = new System.Drawing.Size(977, 125);
            this.groupBoxIn_MAD.TabIndex = 1;
            this.groupBoxIn_MAD.TabStop = false;
            this.groupBoxIn_MAD.Text = "Введите Данные:";
            // 
            // textBoxRow_MAD
            // 
            this.textBoxRow_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRow_MAD.Location = new System.Drawing.Point(6, 21);
            this.textBoxRow_MAD.Multiline = true;
            this.textBoxRow_MAD.Name = "textBoxRow_MAD";
            this.textBoxRow_MAD.ReadOnly = true;
            this.textBoxRow_MAD.Size = new System.Drawing.Size(150, 22);
            this.textBoxRow_MAD.TabIndex = 0;
            this.textBoxRow_MAD.Text = "Введите кол-во строк";
            // 
            // textBoxColumn_MAD
            // 
            this.textBoxColumn_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxColumn_MAD.Location = new System.Drawing.Point(162, 21);
            this.textBoxColumn_MAD.Multiline = true;
            this.textBoxColumn_MAD.Name = "textBoxColumn_MAD";
            this.textBoxColumn_MAD.ReadOnly = true;
            this.textBoxColumn_MAD.Size = new System.Drawing.Size(175, 22);
            this.textBoxColumn_MAD.TabIndex = 0;
            this.textBoxColumn_MAD.Text = "Введите кол-во столбцов";
            // 
            // textBoxFinish_MAD
            // 
            this.textBoxFinish_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFinish_MAD.Location = new System.Drawing.Point(538, 21);
            this.textBoxFinish_MAD.Multiline = true;
            this.textBoxFinish_MAD.Name = "textBoxFinish_MAD";
            this.textBoxFinish_MAD.ReadOnly = true;
            this.textBoxFinish_MAD.Size = new System.Drawing.Size(176, 22);
            this.textBoxFinish_MAD.TabIndex = 0;
            this.textBoxFinish_MAD.Text = "Введите конец дипазона";
            // 
            // textBoxStart_MAD
            // 
            this.textBoxStart_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStart_MAD.Location = new System.Drawing.Point(343, 21);
            this.textBoxStart_MAD.Multiline = true;
            this.textBoxStart_MAD.Name = "textBoxStart_MAD";
            this.textBoxStart_MAD.ReadOnly = true;
            this.textBoxStart_MAD.Size = new System.Drawing.Size(189, 22);
            this.textBoxStart_MAD.TabIndex = 0;
            this.textBoxStart_MAD.Text = "Введите начало диапазона";
            this.textBoxStart_MAD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSelectL_MAD
            // 
            this.textBoxSelectL_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSelectL_MAD.Location = new System.Drawing.Point(162, 70);
            this.textBoxSelectL_MAD.Multiline = true;
            this.textBoxSelectL_MAD.Name = "textBoxSelectL_MAD";
            this.textBoxSelectL_MAD.ReadOnly = true;
            this.textBoxSelectL_MAD.Size = new System.Drawing.Size(72, 22);
            this.textBoxSelectL_MAD.TabIndex = 0;
            this.textBoxSelectL_MAD.Text = "Введите L";
            this.textBoxSelectL_MAD.TextChanged += new System.EventHandler(this.textBoxStr_MAD_TextChanged);
            // 
            // textBoxSelectK_MAD
            // 
            this.textBoxSelectK_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSelectK_MAD.Location = new System.Drawing.Point(6, 70);
            this.textBoxSelectK_MAD.Multiline = true;
            this.textBoxSelectK_MAD.Name = "textBoxSelectK_MAD";
            this.textBoxSelectK_MAD.ReadOnly = true;
            this.textBoxSelectK_MAD.Size = new System.Drawing.Size(77, 22);
            this.textBoxSelectK_MAD.TabIndex = 0;
            this.textBoxSelectK_MAD.Text = "Введите K";
            this.textBoxSelectK_MAD.TextChanged += new System.EventHandler(this.textBoxStr_MAD_TextChanged);
            // 
            // textBoxStr_MAD
            // 
            this.textBoxStr_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStr_MAD.Location = new System.Drawing.Point(720, 21);
            this.textBoxStr_MAD.Multiline = true;
            this.textBoxStr_MAD.Name = "textBoxStr_MAD";
            this.textBoxStr_MAD.ReadOnly = true;
            this.textBoxStr_MAD.Size = new System.Drawing.Size(189, 22);
            this.textBoxStr_MAD.TabIndex = 0;
            this.textBoxStr_MAD.Text = "Введите выбранную строку ";
            this.textBoxStr_MAD.TextChanged += new System.EventHandler(this.textBoxStr_MAD_TextChanged);
            // 
            // textBoxInf_MAD
            // 
            this.textBoxInf_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInf_MAD.Location = new System.Drawing.Point(13, 13);
            this.textBoxInf_MAD.Multiline = true;
            this.textBoxInf_MAD.Name = "textBoxInf_MAD";
            this.textBoxInf_MAD.ReadOnly = true;
            this.textBoxInf_MAD.Size = new System.Drawing.Size(976, 75);
            this.textBoxInf_MAD.TabIndex = 2;
            this.textBoxInf_MAD.Text = resources.GetString("textBoxInf_MAD.Text");
            // 
            // buttonDo_MAD
            // 
            this.buttonDo_MAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDo_MAD.Location = new System.Drawing.Point(878, 225);
            this.buttonDo_MAD.Name = "buttonDo_MAD";
            this.buttonDo_MAD.Size = new System.Drawing.Size(99, 108);
            this.buttonDo_MAD.TabIndex = 3;
            this.buttonDo_MAD.Text = "Выполнить";
            this.buttonDo_MAD.UseVisualStyleBackColor = false;
            this.buttonDo_MAD.Click += new System.EventHandler(this.buttonDo_MAD_Click);
            // 
            // textBoxResult_MAD
            // 
            this.textBoxResult_MAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_MAD.Location = new System.Drawing.Point(877, 355);
            this.textBoxResult_MAD.Name = "textBoxResult_MAD";
            this.textBoxResult_MAD.ReadOnly = true;
            this.textBoxResult_MAD.Size = new System.Drawing.Size(100, 15);
            this.textBoxResult_MAD.TabIndex = 4;
            this.textBoxResult_MAD.Text = "РЕЗУЛЬТАТ";
            // 
            // textBoxRes_MAD
            // 
            this.textBoxRes_MAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRes_MAD.Location = new System.Drawing.Point(876, 376);
            this.textBoxRes_MAD.Name = "textBoxRes_MAD";
            this.textBoxRes_MAD.ReadOnly = true;
            this.textBoxRes_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxRes_MAD.TabIndex = 5;
            this.textBoxRes_MAD.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // textBoxL_MAD
            // 
            this.textBoxL_MAD.Location = new System.Drawing.Point(162, 97);
            this.textBoxL_MAD.Name = "textBoxL_MAD";
            this.textBoxL_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxL_MAD.TabIndex = 1;
            this.textBoxL_MAD.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBoxK_MAD
            // 
            this.textBoxK_MAD.Location = new System.Drawing.Point(6, 97);
            this.textBoxK_MAD.Name = "textBoxK_MAD";
            this.textBoxK_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxK_MAD.TabIndex = 1;
            this.textBoxK_MAD.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textBoxSelectedRow_MAD
            // 
            this.textBoxSelectedRow_MAD.Location = new System.Drawing.Point(720, 42);
            this.textBoxSelectedRow_MAD.Name = "textBoxSelectedRow_MAD";
            this.textBoxSelectedRow_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxSelectedRow_MAD.TabIndex = 1;
            // 
            // textBoxFinishIn_MAD
            // 
            this.textBoxFinishIn_MAD.Location = new System.Drawing.Point(538, 42);
            this.textBoxFinishIn_MAD.Name = "textBoxFinishIn_MAD";
            this.textBoxFinishIn_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxFinishIn_MAD.TabIndex = 1;
            // 
            // textBoxStartIn_MAD
            // 
            this.textBoxStartIn_MAD.Location = new System.Drawing.Point(343, 42);
            this.textBoxStartIn_MAD.Name = "textBoxStartIn_MAD";
            this.textBoxStartIn_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartIn_MAD.TabIndex = 1;
            // 
            // textBoxColumnIn_MAD
            // 
            this.textBoxColumnIn_MAD.Location = new System.Drawing.Point(162, 42);
            this.textBoxColumnIn_MAD.Name = "textBoxColumnIn_MAD";
            this.textBoxColumnIn_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxColumnIn_MAD.TabIndex = 1;
            // 
            // textBoxRowIn_MAD
            // 
            this.textBoxRowIn_MAD.Location = new System.Drawing.Point(7, 42);
            this.textBoxRowIn_MAD.Name = "textBoxRowIn_MAD";
            this.textBoxRowIn_MAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxRowIn_MAD.TabIndex = 2;
            this.textBoxRowIn_MAD.TextChanged += new System.EventHandler(this.textBoxRowIn_MAD_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 591);
            this.Controls.Add(this.textBoxRes_MAD);
            this.Controls.Add(this.textBoxResult_MAD);
            this.Controls.Add(this.buttonDo_MAD);
            this.Controls.Add(this.textBoxInf_MAD);
            this.Controls.Add(this.groupBoxIn_MAD);
            this.Controls.Add(this.dataGridView_MAD);
            this.Name = "FormMain";
            this.Text = "REVIEW";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MAD)).EndInit();
            this.groupBoxIn_MAD.ResumeLayout(false);
            this.groupBoxIn_MAD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MAD;
        private System.Windows.Forms.GroupBox groupBoxIn_MAD;
        private System.Windows.Forms.TextBox textBoxStr_MAD;
        private System.Windows.Forms.TextBox textBoxInf_MAD;
        private System.Windows.Forms.TextBox textBoxRow_MAD;
        private System.Windows.Forms.TextBox textBoxColumn_MAD;
        private System.Windows.Forms.TextBox textBoxFinish_MAD;
        private System.Windows.Forms.TextBox textBoxStart_MAD;
        private System.Windows.Forms.TextBox textBoxSelectL_MAD;
        private System.Windows.Forms.TextBox textBoxSelectK_MAD;
        private System.Windows.Forms.Button buttonDo_MAD;
        private System.Windows.Forms.TextBox textBoxResult_MAD;
        private System.Windows.Forms.TextBox textBoxRes_MAD;
        private System.Windows.Forms.TextBox textBoxRowIn_MAD;
        private System.Windows.Forms.TextBox textBoxL_MAD;
        private System.Windows.Forms.TextBox textBoxK_MAD;
        private System.Windows.Forms.TextBox textBoxSelectedRow_MAD;
        private System.Windows.Forms.TextBox textBoxFinishIn_MAD;
        private System.Windows.Forms.TextBox textBoxStartIn_MAD;
        private System.Windows.Forms.TextBox textBoxColumnIn_MAD;
    }
}

