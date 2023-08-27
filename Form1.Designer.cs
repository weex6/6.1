namespace _6._1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClose = new System.Windows.Forms.Button();
            this.gbChoose = new System.Windows.Forms.GroupBox();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.domSize = new System.Windows.Forms.DomainUpDown();
            this.domType = new System.Windows.Forms.DomainUpDown();
            this.lbName = new System.Windows.Forms.Label();
            this.gbChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(172, 290);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 34);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbChoose
            // 
            this.gbChoose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbChoose.Controls.Add(this.btnMakeOrder);
            this.gbChoose.Controls.Add(this.domSize);
            this.gbChoose.Controls.Add(this.domType);
            this.gbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbChoose.ForeColor = System.Drawing.Color.Black;
            this.gbChoose.Location = new System.Drawing.Point(52, 84);
            this.gbChoose.Name = "gbChoose";
            this.gbChoose.Size = new System.Drawing.Size(370, 188);
            this.gbChoose.TabIndex = 11;
            this.gbChoose.TabStop = false;
            this.gbChoose.Text = "Выберите что вы хотите";
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMakeOrder.Location = new System.Drawing.Point(120, 113);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(120, 51);
            this.btnMakeOrder.TabIndex = 6;
            this.btnMakeOrder.Text = "Заказать";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // domSize
            // 
            this.domSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domSize.Items.Add("XS");
            this.domSize.Items.Add("S");
            this.domSize.Items.Add("M");
            this.domSize.Items.Add("L");
            this.domSize.Items.Add("XL");
            this.domSize.Location = new System.Drawing.Point(203, 62);
            this.domSize.Name = "domSize";
            this.domSize.ReadOnly = true;
            this.domSize.Size = new System.Drawing.Size(120, 28);
            this.domSize.TabIndex = 7;
            this.domSize.Text = "Размер";
            // 
            // domType
            // 
            this.domType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domType.Items.Add("Футболка");
            this.domType.Items.Add("Штаны");
            this.domType.Items.Add("Юбка");
            this.domType.Items.Add("Платье");
            this.domType.Location = new System.Drawing.Point(45, 62);
            this.domType.Name = "domType";
            this.domType.ReadOnly = true;
            this.domType.Size = new System.Drawing.Size(120, 28);
            this.domType.TabIndex = 5;
            this.domType.Text = "Вид";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(27, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(385, 38);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Ателье «Голый король»";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(471, 348);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbChoose);
            this.Controls.Add(this.lbName);
            this.MaximumSize = new System.Drawing.Size(489, 395);
            this.MinimumSize = new System.Drawing.Size(489, 395);
            this.Name = "Form1";
            this.Text = "Приложение";
            this.gbChoose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbChoose;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.DomainUpDown domSize;
        private System.Windows.Forms.DomainUpDown domType;
        private System.Windows.Forms.Label lbName;
    }
}

