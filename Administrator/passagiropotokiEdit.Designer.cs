namespace CuteBus.Administrator
{
    partial class passagiropotokiEdit
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
            System.Windows.Forms.Label время_прибытия_автобусаLabel;
            System.Windows.Forms.Label ___автобусаLabel;
            System.Windows.Forms.Label ___маршрутаLabel;
            System.Windows.Forms.Label колличество_пассажировLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passagiropotokiEdit));
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
            this.passagiropotokiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.passagiropotokiTableAdapter = new CuteBus.CuteBusDataSetTableAdapters.passagiropotokiTableAdapter();
            this.tableAdapterManager = new CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager();
            this.время_прибытия_автобусаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.___автобусаTextBox = new System.Windows.Forms.TextBox();
            this.___маршрутаTextBox = new System.Windows.Forms.TextBox();
            this.колличество_пассажировTextBox = new System.Windows.Forms.TextBox();
            время_прибытия_автобусаLabel = new System.Windows.Forms.Label();
            ___автобусаLabel = new System.Windows.Forms.Label();
            ___маршрутаLabel = new System.Windows.Forms.Label();
            колличество_пассажировLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passagiropotokiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // время_прибытия_автобусаLabel
            // 
            время_прибытия_автобусаLabel.AutoSize = true;
            время_прибытия_автобусаLabel.BackColor = System.Drawing.Color.Transparent;
            время_прибытия_автобусаLabel.Location = new System.Drawing.Point(310, 182);
            время_прибытия_автобусаLabel.Name = "время_прибытия_автобусаLabel";
            время_прибытия_автобусаLabel.Size = new System.Drawing.Size(143, 13);
            время_прибытия_автобусаLabel.TabIndex = 46;
            время_прибытия_автобусаLabel.Text = "время прибытия автобуса:";
            // 
            // ___автобусаLabel
            // 
            ___автобусаLabel.AutoSize = true;
            ___автобусаLabel.BackColor = System.Drawing.Color.Transparent;
            ___автобусаLabel.Location = new System.Drawing.Point(383, 207);
            ___автобусаLabel.Name = "___автобусаLabel";
            ___автобусаLabel.Size = new System.Drawing.Size(70, 13);
            ___автобусаLabel.TabIndex = 48;
            ___автобусаLabel.Text = "№ автобуса:";
            // 
            // ___маршрутаLabel
            // 
            ___маршрутаLabel.AutoSize = true;
            ___маршрутаLabel.BackColor = System.Drawing.Color.Transparent;
            ___маршрутаLabel.Location = new System.Drawing.Point(379, 233);
            ___маршрутаLabel.Name = "___маршрутаLabel";
            ___маршрутаLabel.Size = new System.Drawing.Size(74, 13);
            ___маршрутаLabel.TabIndex = 50;
            ___маршрутаLabel.Text = "№ маршрута:";
            // 
            // колличество_пассажировLabel
            // 
            колличество_пассажировLabel.AutoSize = true;
            колличество_пассажировLabel.BackColor = System.Drawing.Color.Transparent;
            колличество_пассажировLabel.Location = new System.Drawing.Point(314, 259);
            колличество_пассажировLabel.Name = "колличество_пассажировLabel";
            колличество_пассажировLabel.Size = new System.Drawing.Size(139, 13);
            колличество_пассажировLabel.TabIndex = 52;
            колличество_пассажировLabel.Text = "колличество пассажиров:";
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
            // passagiropotokiBindingSource
            // 
            this.passagiropotokiBindingSource.DataMember = "passagiropotoki";
            this.passagiropotokiBindingSource.DataSource = this.cuteBusDataSet;
            // 
            // passagiropotokiTableAdapter
            // 
            this.passagiropotokiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.conductorTableAdapter = null;
            this.tableAdapterManager.denegnuy_oborotTableAdapter = null;
            this.tableAdapterManager.passagiropotokiTableAdapter = this.passagiropotokiTableAdapter;
            this.tableAdapterManager.premiaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CuteBus.CuteBusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voditelTableAdapter = null;
            this.tableAdapterManager.zagr_naprTableAdapter = null;
            this.tableAdapterManager.zagr_reysovTableAdapter = null;
            this.tableAdapterManager.zarplataTableAdapter = null;
            // 
            // время_прибытия_автобусаDateTimePicker
            // 
            this.время_прибытия_автобусаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.passagiropotokiBindingSource, "время прибытия автобуса", true));
            this.время_прибытия_автобусаDateTimePicker.Location = new System.Drawing.Point(459, 178);
            this.время_прибытия_автобусаDateTimePicker.Name = "время_прибытия_автобусаDateTimePicker";
            this.время_прибытия_автобусаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.время_прибытия_автобусаDateTimePicker.TabIndex = 47;
            // 
            // ___автобусаTextBox
            // 
            this.___автобусаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passagiropotokiBindingSource, "№ автобуса", true));
            this.___автобусаTextBox.Location = new System.Drawing.Point(459, 204);
            this.___автобусаTextBox.Name = "___автобусаTextBox";
            this.___автобусаTextBox.Size = new System.Drawing.Size(200, 20);
            this.___автобусаTextBox.TabIndex = 49;
            // 
            // ___маршрутаTextBox
            // 
            this.___маршрутаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passagiropotokiBindingSource, "№ маршрута", true));
            this.___маршрутаTextBox.Location = new System.Drawing.Point(459, 230);
            this.___маршрутаTextBox.Name = "___маршрутаTextBox";
            this.___маршрутаTextBox.Size = new System.Drawing.Size(200, 20);
            this.___маршрутаTextBox.TabIndex = 51;
            // 
            // колличество_пассажировTextBox
            // 
            this.колличество_пассажировTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.passagiropotokiBindingSource, "колличество пассажиров", true));
            this.колличество_пассажировTextBox.Location = new System.Drawing.Point(459, 256);
            this.колличество_пассажировTextBox.Name = "колличество_пассажировTextBox";
            this.колличество_пассажировTextBox.Size = new System.Drawing.Size(200, 20);
            this.колличество_пассажировTextBox.TabIndex = 53;
            // 
            // passagiropotokiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(992, 542);
            this.Controls.Add(время_прибытия_автобусаLabel);
            this.Controls.Add(this.время_прибытия_автобусаDateTimePicker);
            this.Controls.Add(___автобусаLabel);
            this.Controls.Add(this.___автобусаTextBox);
            this.Controls.Add(___маршрутаLabel);
            this.Controls.Add(this.___маршрутаTextBox);
            this.Controls.Add(колличество_пассажировLabel);
            this.Controls.Add(this.колличество_пассажировTextBox);
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
            this.Name = "passagiropotokiEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассажиропотоки";
            this.Load += new System.EventHandler(this.passagiropotokiEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuteBusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passagiropotokiBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource passagiropotokiBindingSource;
        private CuteBusDataSetTableAdapters.passagiropotokiTableAdapter passagiropotokiTableAdapter;
        private CuteBusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker время_прибытия_автобусаDateTimePicker;
        private System.Windows.Forms.TextBox ___автобусаTextBox;
        private System.Windows.Forms.TextBox ___маршрутаTextBox;
        private System.Windows.Forms.TextBox колличество_пассажировTextBox;
    }
}