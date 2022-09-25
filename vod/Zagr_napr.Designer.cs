namespace CuteBus.Voditel
{
    partial class Zagr_napr
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
            System.Windows.Forms.Label кмLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zagr_napr));
            this.cuteBusDataSet = new CuteBus.CuteBusDataSet();
            this.zagr_naprBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zagr_naprTableAdapter = new CuteBus.CuteBusDataSetTableAdapters.zagr_naprTableAdapter();
            this.tableAdapterManager = new CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager();
            this.рейсTextBox = new System.Windows.Forms.TextBox();
            this.кмTextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            рейсLabel = new System.Windows.Forms.Label();
            кмLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zagr_naprBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // рейсLabel
            // 
            рейсLabel.AutoSize = true;
            рейсLabel.BackColor = System.Drawing.Color.Transparent;
            рейсLabel.Location = new System.Drawing.Point(368, 208);
            рейсLabel.Name = "рейсLabel";
            рейсLabel.Size = new System.Drawing.Size(34, 13);
            рейсLabel.TabIndex = 1;
            рейсLabel.Text = "рейс:";
            // 
            // кмLabel
            // 
            кмLabel.AutoSize = true;
            кмLabel.BackColor = System.Drawing.Color.Transparent;
            кмLabel.Location = new System.Drawing.Point(378, 234);
            кмLabel.Name = "кмLabel";
            кмLabel.Size = new System.Drawing.Size(24, 13);
            кмLabel.TabIndex = 3;
            кмLabel.Text = "км:";
            // 
            // cuteBusDataSet
            // 
            this.cuteBusDataSet.DataSetName = "CuteBusDataSet";
            this.cuteBusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zagr_naprBindingSource
            // 
            this.zagr_naprBindingSource.DataMember = "zagr_napr";
            this.zagr_naprBindingSource.DataSource = this.cuteBusDataSet;
            // 
            // zagr_naprTableAdapter
            // 
            this.zagr_naprTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.zagr_naprTableAdapter = this.zagr_naprTableAdapter;
            this.tableAdapterManager.zagr_reysovTableAdapter = null;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // рейсTextBox
            // 
            this.рейсTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zagr_naprBindingSource, "рейс", true));
            this.рейсTextBox.Location = new System.Drawing.Point(408, 205);
            this.рейсTextBox.Name = "рейсTextBox";
            this.рейсTextBox.Size = new System.Drawing.Size(201, 20);
            this.рейсTextBox.TabIndex = 2;
            // 
            // кмTextBox
            // 
            this.кмTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zagr_naprBindingSource, "км", true));
            this.кмTextBox.Location = new System.Drawing.Point(408, 231);
            this.кмTextBox.Name = "кмTextBox";
            this.кмTextBox.Size = new System.Drawing.Size(201, 20);
            this.кмTextBox.TabIndex = 4;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightPink;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(865, 475);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(92, 33);
            this.back.TabIndex = 23;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightPink;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(606, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 33);
            this.button4.TabIndex = 22;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightPink;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(482, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 33);
            this.button3.TabIndex = 21;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(358, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(234, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 33);
            this.button1.TabIndex = 19;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightPink;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(358, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(242, 33);
            this.button5.TabIndex = 24;
            this.button5.Text = "Сохранить";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightPink;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(482, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 33);
            this.button6.TabIndex = 25;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightPink;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(358, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 33);
            this.button7.TabIndex = 26;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CuteBus.Properties.Resources.main_автобус_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Zagr_napr
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
            this.Controls.Add(кмLabel);
            this.Controls.Add(this.кмTextBox);
            this.Controls.Add(рейсLabel);
            this.Controls.Add(this.рейсTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zagr_napr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загруженность направлений";
            this.Load += new System.EventHandler(this.Zagr_napr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zagr_naprBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuteBusDataSet cuteBusDataSet;
        private System.Windows.Forms.BindingSource zagr_naprBindingSource;
        private CuteBusDataSetTableAdapters.zagr_naprTableAdapter zagr_naprTableAdapter;
        private CuteBusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox рейсTextBox;
        private System.Windows.Forms.TextBox кмTextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}