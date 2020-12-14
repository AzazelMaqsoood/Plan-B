namespace Plan_B
{
    partial class Sotr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnComplete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnMakeOtchet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.LblResourseName = new System.Windows.Forms.Label();
            this.LblTaskName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblAppointmentDate = new System.Windows.Forms.Label();
            this.LblCompletionDate = new System.Windows.Forms.Label();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Depth = 0;
            this.BtnBack.Location = new System.Drawing.Point(956, 530);
            this.BtnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Primary = true;
            this.BtnBack.Size = new System.Drawing.Size(315, 51);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnComplete
            // 
            this.BtnComplete.Depth = 0;
            this.BtnComplete.Location = new System.Drawing.Point(83, 530);
            this.BtnComplete.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Primary = true;
            this.BtnComplete.Size = new System.Drawing.Size(315, 51);
            this.BtnComplete.TabIndex = 3;
            this.BtnComplete.Text = "Завершить";
            this.BtnComplete.UseVisualStyleBackColor = true;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // BtnMakeOtchet
            // 
            this.BtnMakeOtchet.Depth = 0;
            this.BtnMakeOtchet.Location = new System.Drawing.Point(527, 530);
            this.BtnMakeOtchet.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnMakeOtchet.Name = "BtnMakeOtchet";
            this.BtnMakeOtchet.Primary = true;
            this.BtnMakeOtchet.Size = new System.Drawing.Size(315, 51);
            this.BtnMakeOtchet.TabIndex = 4;
            this.BtnMakeOtchet.Text = "Сформировать отчет";
            this.BtnMakeOtchet.UseVisualStyleBackColor = true;
            this.BtnMakeOtchet.Click += new System.EventHandler(this.BtnMakeOtchet_Click);
            // 
            // LblResourseName
            // 
            this.LblResourseName.AutoSize = true;
            this.LblResourseName.Location = new System.Drawing.Point(184, 628);
            this.LblResourseName.Name = "LblResourseName";
            this.LblResourseName.Size = new System.Drawing.Size(20, 17);
            this.LblResourseName.TabIndex = 21;
            this.LblResourseName.Text = "   ";
            this.LblResourseName.Visible = false;
            // 
            // LblTaskName
            // 
            this.LblTaskName.AutoSize = true;
            this.LblTaskName.Location = new System.Drawing.Point(236, 628);
            this.LblTaskName.Name = "LblTaskName";
            this.LblTaskName.Size = new System.Drawing.Size(24, 17);
            this.LblTaskName.TabIndex = 22;
            this.LblTaskName.Text = "    ";
            this.LblTaskName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 628);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "    ";
            this.label2.Visible = false;
            // 
            // LblAppointmentDate
            // 
            this.LblAppointmentDate.AutoSize = true;
            this.LblAppointmentDate.Location = new System.Drawing.Point(334, 628);
            this.LblAppointmentDate.Name = "LblAppointmentDate";
            this.LblAppointmentDate.Size = new System.Drawing.Size(24, 17);
            this.LblAppointmentDate.TabIndex = 24;
            this.LblAppointmentDate.Text = "    ";
            this.LblAppointmentDate.Visible = false;
            // 
            // LblCompletionDate
            // 
            this.LblCompletionDate.AutoSize = true;
            this.LblCompletionDate.Location = new System.Drawing.Point(374, 628);
            this.LblCompletionDate.Name = "LblCompletionDate";
            this.LblCompletionDate.Size = new System.Drawing.Size(24, 17);
            this.LblCompletionDate.TabIndex = 25;
            this.LblCompletionDate.Text = "    ";
            this.LblCompletionDate.Visible = false;
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.AllowUserToResizeColumns = false;
            this.DGV2.AllowUserToResizeRows = false;
            this.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV2.BackgroundColor = System.Drawing.Color.White;
            this.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("PT Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.DGV2.Location = new System.Drawing.Point(83, 124);
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV2.RowHeadersVisible = false;
            this.DGV2.RowTemplate.Height = 24;
            this.DGV2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV2.Size = new System.Drawing.Size(1188, 354);
            this.DGV2.TabIndex = 26;
            this.DGV2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV2_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Id_postavl_zadachi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Name_zadacha";
            this.dataGridViewTextBoxColumn7.HeaderText = "Задача";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Opis_zadacha";
            this.dataGridViewTextBoxColumn8.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 275;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Name_resourse";
            this.dataGridViewTextBoxColumn9.HeaderText = "Ресурс";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Data_naznach";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата назначения";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Data_vipoln";
            this.dataGridViewTextBoxColumn11.HeaderText = "Дата завершения";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Status_vipoln";
            this.dataGridViewTextBoxColumn12.HeaderText = "Статус выполнения";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 120;
            // 
            // Sotr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1366, 654);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.LblCompletionDate);
            this.Controls.Add(this.LblAppointmentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTaskName);
            this.Controls.Add(this.LblResourseName);
            this.Controls.Add(this.BtnMakeOtchet);
            this.Controls.Add(this.BtnComplete);
            this.Controls.Add(this.BtnBack);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 654);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 654);
            this.Name = "Sotr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страница сотрудника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sotr_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton BtnBack;
        private MaterialSkin.Controls.MaterialRaisedButton BtnComplete;
        private MaterialSkin.Controls.MaterialRaisedButton BtnMakeOtchet;
        private System.Windows.Forms.Label LblResourseName;
        private System.Windows.Forms.Label LblTaskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblAppointmentDate;
        private System.Windows.Forms.Label LblCompletionDate;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}