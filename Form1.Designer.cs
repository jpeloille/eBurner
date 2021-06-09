namespace eBurner
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Burn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.pbProcess = new System.Windows.Forms.ProgressBar();
            this.btnWriteDatas = new System.Windows.Forms.Button();
            this.btnTestSignal = new System.Windows.Forms.Button();
            this.tbStartAdress = new System.Windows.Forms.TextBox();
            this.tbEndAdress = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cbComSelector = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Burn
            // 
            this.btn_Burn.Location = new System.Drawing.Point(576, 535);
            this.btn_Burn.Name = "btn_Burn";
            this.btn_Burn.Size = new System.Drawing.Size(75, 23);
            this.btn_Burn.TabIndex = 0;
            this.btn_Burn.Text = "Brûler";
            this.btn_Burn.UseVisualStyleBackColor = true;
            this.btn_Burn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 35);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(555, 514);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Source";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbProcess
            // 
            this.pbProcess.Location = new System.Drawing.Point(575, 141);
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(317, 23);
            this.pbProcess.TabIndex = 3;
            // 
            // btnWriteDatas
            // 
            this.btnWriteDatas.Location = new System.Drawing.Point(72, 59);
            this.btnWriteDatas.Name = "btnWriteDatas";
            this.btnWriteDatas.Size = new System.Drawing.Size(75, 23);
            this.btnWriteDatas.TabIndex = 4;
            this.btnWriteDatas.Text = "Write Block";
            this.btnWriteDatas.UseVisualStyleBackColor = true;
            this.btnWriteDatas.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnTestSignal
            // 
            this.btnTestSignal.Location = new System.Drawing.Point(660, 10);
            this.btnTestSignal.Name = "btnTestSignal";
            this.btnTestSignal.Size = new System.Drawing.Size(75, 23);
            this.btnTestSignal.TabIndex = 5;
            this.btnTestSignal.Text = "Test";
            this.btnTestSignal.UseVisualStyleBackColor = true;
            this.btnTestSignal.Click += new System.EventHandler(this.btnTestSignal_Click);
            // 
            // tbStartAdress
            // 
            this.tbStartAdress.Location = new System.Drawing.Point(72, 7);
            this.tbStartAdress.Name = "tbStartAdress";
            this.tbStartAdress.Size = new System.Drawing.Size(75, 20);
            this.tbStartAdress.TabIndex = 6;
            // 
            // tbEndAdress
            // 
            this.tbEndAdress.Location = new System.Drawing.Point(72, 33);
            this.tbEndAdress.Name = "tbEndAdress";
            this.tbEndAdress.Size = new System.Drawing.Size(75, 20);
            this.tbEndAdress.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(576, 170);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(316, 359);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // cbComSelector
            // 
            this.cbComSelector.FormattingEnabled = true;
            this.cbComSelector.Location = new System.Drawing.Point(741, 11);
            this.cbComSelector.Name = "cbComSelector";
            this.cbComSelector.Size = new System.Drawing.Size(75, 21);
            this.cbComSelector.TabIndex = 9;
            this.cbComSelector.SelectedIndexChanged += new System.EventHandler(this.CbComSelector_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(824, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(234, 59);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(234, 7);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(75, 23);
            this.btnWriteData.TabIndex = 12;
            this.btnWriteData.Text = "Write Data";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.BtnWriteData_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(579, 9);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(75, 23);
            this.btnFormat.TabIndex = 13;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(153, 8);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(75, 20);
            this.tbData.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "End adress";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.btnWriteData);
            this.panel1.Controls.Add(this.tbEndAdress);
            this.panel1.Controls.Add(this.tbStartAdress);
            this.panel1.Controls.Add(this.btnWriteDatas);
            this.panel1.Controls.Add(this.tbData);
            this.panel1.Location = new System.Drawing.Point(576, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 91);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 549);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(15, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 34);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 570);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbProcess);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbComSelector);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnTestSignal);
            this.Controls.Add(this.btn_Burn);
            this.Name = "Form1";
            this.Text = "AT28C64 EEPROM Burner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Burn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar pbProcess;
        private System.Windows.Forms.Button btnWriteDatas;
        private System.Windows.Forms.Button btnTestSignal;
        private System.Windows.Forms.TextBox tbStartAdress;
        private System.Windows.Forms.TextBox tbEndAdress;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cbComSelector;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

