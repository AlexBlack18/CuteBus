namespace CuteBus.Administrator
{
    partial class conductorEdit
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
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label прохождение_медецинского_освидетельствованияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(conductorEdit));
            this.cuteBusDataSet = new CuteBus.CuteBusDataSet();
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conductorTableAdapter = new CuteBus.CuteBusDataSetTableAdapters.conductorTableAdapter();
            this.tableAdapterManager = new CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.прохождение_медецинского_освидетельствованияTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            имяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            прохождение_медецинского_освидетельствованияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.BackColor = System.Drawing.Color.Transparent;
            имяLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            имяLabel.Location = new System.Drawing.Point(431, 191);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 3;
            имяLabel.Text = "Имя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.BackColor = System.Drawing.Color.Transparent;
            фамилияLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            фамилияLabel.Location = new System.Drawing.Point(404, 217);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 5;
            фамилияLabel.Text = "Фамилия:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.BackColor = System.Drawing.Color.Transparent;
            отчествоLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            отчествоLabel.Location = new System.Drawing.Point(404, 243);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.BackColor = System.Drawing.Color.Transparent;
            дата_рожденияLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            дата_рожденияLabel.Location = new System.Drawing.Point(374, 272);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(89, 13);
            дата_рожденияLabel.TabIndex = 9;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // прохождение_медецинского_освидетельствованияLabel
            // 
            прохождение_медецинского_освидетельствованияLabel.AutoSize = true;
            прохождение_медецинского_освидетельствованияLabel.BackColor = System.Drawing.Color.Transparent;
            прохождение_медецинского_освидетельствованияLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            прохождение_медецинского_освидетельствованияLabel.Location = new System.Drawing.Point(314, 295);
            прохождение_медецинского_освидетельствованияLabel.Name = "прохождение_медецинского_освидетельствованияLabel";
            прохождение_медецинского_освидетельствованияLabel.Size = new System.Drawing.Size(149, 13);
            прохождение_медецинского_освидетельствованияLabel.TabIndex = 11;
            прохождение_медецинского_освидетельствованияLabel.Text = "Мед. освидетельствование:";
            // 
            // cuteBusDataSet
            // 
            this.cuteBusDataSet.DataSetName = "CuteBusDataSet";
            this.cuteBusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conductorBindingSource
            // 
            this.conductorBindingSource.DataMember = "conductor";
            this.conductorBindingSource.DataSource = this.cuteBusDataSet;
            // 
            // conductorTableAdapter
            // 
            this.conductorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conductorTableAdapter = this.conductorTableAdapter;
            this.tableAdapterManager.denegnuy_oborotTableAdapter = null;
            this.tableAdapterManager.passagiropotokiTableAdapter = null;
            this.tableAdapterManager.premiaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voditelTableAdapter = null;
            this.tableAdapterManager.zagr_naprTableAdapter = null;
            this.tableAdapterManager.zagr_reysovTableAdapter = null;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(469, 188);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 20);
            this.имяTextBox.TabIndex = 4;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(469, 214);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 20);
            this.фамилияTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(469, 240);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 20);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.conductorBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(469, 266);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_рожденияDateTimePicker.TabIndex = 10;
            // 
            // прохождение_медецинского_освидетельствованияTextBox
            // 
            this.прохождение_медецинского_освидетельствованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conductorBindingSource, "Прохождение медецинского освидетельствования", true));
            this.прохождение_медецинского_освидетельствованияTextBox.Location = new System.Drawing.Point(469, 292);
            this.прохождение_медецинского_освидетельствованияTextBox.Name = "прохождение_медецинского_освидетельствованияTextBox";
            this.прохождение_медецинского_освидетельствованияTextBox.Size = new System.Drawing.Size(200, 20);
            this.прохождение_медецинского_освидетельствованияTextBox.TabIndex = 12;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightPink;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(373, 448);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 34);
            this.button7.TabIndex = 34;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightPink;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(497, 448);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 34);
            this.button6.TabIndex = 33;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightPink;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(373, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 34);
            this.button5.TabIndex = 32;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightPink;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(880, 487);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 34);
            this.back.TabIndex = 31;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightPink;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(621, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightPink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(497, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(373, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(249, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CuteBus.Properties.Resources.main_автобус_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // conductorEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(прохождение_медецинского_освидетельствованияLabel);
            this.Controls.Add(this.прохождение_медецинского_освидетельствованияTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "conductorEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кондукторы";
            this.Load += new System.EventHandler(this.conductorEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuteBusDataSet cuteBusDataSet;
        private System.Windows.Forms.BindingSource conductorBindingSource;
        private CuteBusDataSetTableAdapters.conductorTableAdapter conductorTableAdapter;
        private CuteBusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox прохождение_медецинского_освидетельствованияTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}