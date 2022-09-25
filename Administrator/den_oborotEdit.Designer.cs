namespace CuteBus.Administrator
{
    partial class den_oborotEdit
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
            System.Windows.Forms.Label номер_рейсаLabel;
            System.Windows.Forms.Label сумма__рубLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(den_oborotEdit));
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cuteBusDataSet = new CuteBus.CuteBusDataSet();
            this.denegnuy_oborotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denegnuy_oborotTableAdapter = new CuteBus.CuteBusDataSetTableAdapters.denegnuy_oborotTableAdapter();
            this.tableAdapterManager = new CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager();
            this.номер_рейсаTextBox = new System.Windows.Forms.TextBox();
            this.сумма__рубTextBox = new System.Windows.Forms.TextBox();
            номер_рейсаLabel = new System.Windows.Forms.Label();
            сумма__рубLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denegnuy_oborotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_рейсаLabel
            // 
            номер_рейсаLabel.AutoSize = true;
            номер_рейсаLabel.BackColor = System.Drawing.Color.Transparent;
            номер_рейсаLabel.Location = new System.Drawing.Point(360, 203);
            номер_рейсаLabel.Name = "номер_рейсаLabel";
            номер_рейсаLabel.Size = new System.Drawing.Size(75, 13);
            номер_рейсаLabel.TabIndex = 46;
            номер_рейсаLabel.Text = "номер рейса:";
            // 
            // сумма__рубLabel
            // 
            сумма__рубLabel.AutoSize = true;
            сумма__рубLabel.BackColor = System.Drawing.Color.Transparent;
            сумма__рубLabel.Location = new System.Drawing.Point(369, 229);
            сумма__рубLabel.Name = "сумма__рубLabel";
            сумма__рубLabel.Size = new System.Drawing.Size(66, 13);
            сумма__рубLabel.TabIndex = 48;
            сумма__рубLabel.Text = "сумма, руб:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightPink;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(373, 448);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 34);
            this.button7.TabIndex = 42;
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
            this.button6.TabIndex = 41;
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
            this.button5.TabIndex = 40;
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
            this.back.TabIndex = 39;
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
            this.button4.TabIndex = 38;
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
            this.button3.TabIndex = 37;
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
            this.button2.TabIndex = 36;
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
            this.button1.TabIndex = 35;
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
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // cuteBusDataSet
            // 
            this.cuteBusDataSet.DataSetName = "CuteBusDataSet";
            this.cuteBusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // denegnuy_oborotBindingSource
            // 
            this.denegnuy_oborotBindingSource.DataMember = "denegnuy_oborot";
            this.denegnuy_oborotBindingSource.DataSource = this.cuteBusDataSet;
            // 
            // denegnuy_oborotTableAdapter
            // 
            this.denegnuy_oborotTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conductorTableAdapter = null;
            this.tableAdapterManager.denegnuy_oborotTableAdapter = this.denegnuy_oborotTableAdapter;
            this.tableAdapterManager.passagiropotokiTableAdapter = null;
            this.tableAdapterManager.premiaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voditelTableAdapter = null;
            this.tableAdapterManager.zagr_naprTableAdapter = null;
            this.tableAdapterManager.zagr_reysovTableAdapter = null;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // номер_рейсаTextBox
            // 
            this.номер_рейсаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.denegnuy_oborotBindingSource, "номер рейса", true));
            this.номер_рейсаTextBox.Location = new System.Drawing.Point(441, 200);
            this.номер_рейсаTextBox.Name = "номер_рейсаTextBox";
            this.номер_рейсаTextBox.Size = new System.Drawing.Size(174, 20);
            this.номер_рейсаTextBox.TabIndex = 47;
            // 
            // сумма__рубTextBox
            // 
            this.сумма__рубTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.denegnuy_oborotBindingSource, "сумма, руб", true));
            this.сумма__рубTextBox.Location = new System.Drawing.Point(441, 226);
            this.сумма__рубTextBox.Name = "сумма__рубTextBox";
            this.сумма__рубTextBox.Size = new System.Drawing.Size(174, 20);
            this.сумма__рубTextBox.TabIndex = 49;
            // 
            // den_oborotEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(992, 542);
            this.Controls.Add(номер_рейсаLabel);
            this.Controls.Add(this.номер_рейсаTextBox);
            this.Controls.Add(сумма__рубLabel);
            this.Controls.Add(this.сумма__рубTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "den_oborotEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Денежный оборот";
            this.Load += new System.EventHandler(this.den_oborotEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denegnuy_oborotBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CuteBusDataSet cuteBusDataSet;
        private System.Windows.Forms.BindingSource denegnuy_oborotBindingSource;
        private CuteBusDataSetTableAdapters.denegnuy_oborotTableAdapter denegnuy_oborotTableAdapter;
        private CuteBusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox номер_рейсаTextBox;
        private System.Windows.Forms.TextBox сумма__рубTextBox;
    }
}