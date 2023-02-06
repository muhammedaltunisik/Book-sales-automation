
namespace KitapYurdu
{
    partial class SiparisDetaylari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisDetaylari));
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableAdapterManager1 = new KitapYurdu.KitapYurduDataSetTableAdapters.TableAdapterManager();
            this.button_Sipariş_Detayi = new System.Windows.Forms.Button();
            this.button_Geri_Gel = new System.Windows.Forms.Button();
            this.label_Kullanıcı_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 451);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tbl_AdressTableAdapter = null;
            this.tableAdapterManager1.tbl_KitaplarTableAdapter = null;
            this.tableAdapterManager1.tbl_KullanicilarTableAdapter = null;
            this.tableAdapterManager1.tbl_SaticilarTableAdapter = null;
            this.tableAdapterManager1.tbl_YazarlarTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = KitapYurdu.KitapYurduDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button_Sipariş_Detayi
            // 
            this.button_Sipariş_Detayi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Sipariş_Detayi.Location = new System.Drawing.Point(13, 459);
            this.button_Sipariş_Detayi.Margin = new System.Windows.Forms.Padding(4);
            this.button_Sipariş_Detayi.Name = "button_Sipariş_Detayi";
            this.button_Sipariş_Detayi.Size = new System.Drawing.Size(251, 45);
            this.button_Sipariş_Detayi.TabIndex = 1;
            this.button_Sipariş_Detayi.Text = "Sipariş Detaylarini Göster";
            this.button_Sipariş_Detayi.UseVisualStyleBackColor = true;
            this.button_Sipariş_Detayi.Click += new System.EventHandler(this.button_Sipariş_Detayi_Click);
            // 
            // button_Geri_Gel
            // 
            this.button_Geri_Gel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Geri_Gel.Location = new System.Drawing.Point(272, 459);
            this.button_Geri_Gel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Geri_Gel.Name = "button_Geri_Gel";
            this.button_Geri_Gel.Size = new System.Drawing.Size(251, 45);
            this.button_Geri_Gel.TabIndex = 2;
            this.button_Geri_Gel.Text = "Geri Dön";
            this.button_Geri_Gel.UseVisualStyleBackColor = true;
            this.button_Geri_Gel.Click += new System.EventHandler(this.button_Geri_Gel_Click);
            // 
            // label_Kullanıcı_ID
            // 
            this.label_Kullanıcı_ID.AutoSize = true;
            this.label_Kullanıcı_ID.Location = new System.Drawing.Point(668, 491);
            this.label_Kullanıcı_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Kullanıcı_ID.Name = "label_Kullanıcı_ID";
            this.label_Kullanıcı_ID.Size = new System.Drawing.Size(46, 17);
            this.label_Kullanıcı_ID.TabIndex = 3;
            this.label_Kullanıcı_ID.Text = "label1";
            this.label_Kullanıcı_ID.Visible = false;
            // 
            // SiparisDetaylari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(115)))), ((int)(((byte)(121)))));
            this.ClientSize = new System.Drawing.Size(727, 517);
            this.Controls.Add(this.label_Kullanıcı_ID);
            this.Controls.Add(this.button_Geri_Gel);
            this.Controls.Add(this.button_Sipariş_Detayi);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SiparisDetaylari";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private KitapYurduDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button_Sipariş_Detayi;
        private System.Windows.Forms.Button button_Geri_Gel;
        public System.Windows.Forms.Label label_Kullanıcı_ID;
    }
}