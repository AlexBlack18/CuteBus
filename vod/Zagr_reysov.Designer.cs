namespace CuteBus.Voditel
{
    partial class Zagr_reysov
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
            System.Windows.Forms.Label рейсLabel;
            System.Windows.Forms.Label загруженность__чел_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zagr_reysov));
            this.cuteBusDataSet = new CuteBus.CuteBusDataSet();
            this.zagr_reysovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zagr_reysovTableAdapter = new CuteBus.CuteBusDataSetTableAdapters.zagr_reysovTableAdapter();
            this.tableAdapterManager = new CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager();
            this.рейсTextBox = new System.Windows.Forms.TextBox();
            this.загруженность__чел_TextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            рейсLabel = new System.Windows.Forms.Label();
            загруженность__чел_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zagr_reysovBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // рейсLabel
            // 
            рейсLabel.AutoSize = true;
            рейсLabel.BackColor = System.Drawing.Color.Transparent;
            рейсLabel.Location = new System.Drawing.Point(383, 209);
            рейсLabel.Name = "рейсLabel";
            рейсLabel.Size = new System.Drawing.Size(34, 13);
            рейсLabel.TabIndex = 1;
            рейсLabel.Text = "рейс:";
            // 
            // загруженность__чел_Label
            // 
            загруженность__чел_Label.AutoSize = true;
            загруженность__чел_Label.BackColor = System.Drawing.Color.Transparent;
            загруженность__чел_Label.Location = new System.Drawing.Point(307, 235);
            загруженность__чел_Label.Name = "загруженность__чел_Label";
            загруженность__чел_Label.Size = new System.Drawing.Size(110, 13);
            загруженность__чел_Label.TabIndex = 3;
            загруженность__чел_Label.Text = "загруженность, чел:";
            // 
            // cuteBusDataSet
            // 
            this.cuteBusDataSet.DataSetName = "CuteBusDataSet";
            this.cuteBusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zagr_reysovBindingSource
            // 
            this.zagr_reysovBindingSource.DataMember = "zagr_reysov";
            this.zagr_reysovBindingSource.DataSource = this.cuteBusDataSet;
            // 
            // zagr_reysovTableAdapter
            // 
            this.zagr_reysovTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conductorTableAdapter = null;
            this.tableAdapterManager.denegnuy_oborotTableAdapter = null;
            this.tableAdapterManager.passagiropotokiTableAdapter = null;
            this.tableAdapterManager.premiaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voditelTableAdapter = null;
            this.tableAdapterManager.zagr_naprTableAdapter = null;
            this.tableAdapterManager.zagr_reysovTableAdapter = this.zagr_reysovTableAdapter;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // рейсTextBox
            // 
            this.рейсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zagr_reysovBindingSource, "рейс", true));
            this.рейсTextBox.Location = new System.Drawing.Point(423, 206);
            this.рейсTextBox.Name = "рейсTextBox";
            this.рейсTextBox.Size = new System.Drawing.Size(236, 20);
            this.рейсTextBox.TabIndex = 2;
            // 
            // загруженность__чел_TextBox
            // 
            this.загруженность__чел_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zagr_reysovBindingSource, "загруженность, чел#", true));
            this.загруженность__чел_TextBox.Location = new System.Drawing.Point(423, 232);
            this.загруженность__чел_TextBox.Name = "загруженность__чел_TextBox";
            this.загруженность__чел_TextBox.Size = new System.Drawing.Size(236, 20);
            this.загруженность__чел_TextBox.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightPink;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(358, 437);
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
            this.button6.Location = new System.Drawing.Point(482, 437);
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
            this.button5.Location = new System.Drawing.Point(358, 477);
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
            this.back.Location = new System.Drawing.Point(865, 476);
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
            this.button4.Location = new System.Drawing.Point(606, 397);
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
            this.button3.Location = new System.Drawing.Point(482, 397);
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
            this.button2.Location = new System.Drawing.Point(358, 397);
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
            this.button1.Location = new System.Drawing.Point(234, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CuteBus.Properties.Resources.main_автобус_preview_rev_1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // Zagr_reysov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(984, 533);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(загруженность__чел_Label);
            this.Controls.Add(this.загруженность__чел_TextBox);
            this.Controls.Add(рейсLabel);
            this.Controls.Add(this.рейсTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zagr_reysov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загруженность рейсов";
            this.Load += new System.EventHandler(this.Zagr_reysov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zagr_reysovBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuteBusDataSet cuteBusDataSet;
        private System.Windows.Forms.BindingSource zagr_reysovBindingSource;
        private CuteBusDataSetTableAdapters.zagr_reysovTableAdapter zagr_reysovTableAdapter;
        private CuteBusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox рейсTextBox;
        private System.Windows.Forms.TextBox загруженность__чел_TextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}