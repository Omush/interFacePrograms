
namespace ProjektWindforms
{
    partial class Szafkomat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Szafkomat));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_info = new System.Windows.Forms.Label();
            this.lab_time = new System.Windows.Forms.Label();
            this.pnl_firstpanel = new System.Windows.Forms.Panel();
            this.pnl_have_locker1 = new System.Windows.Forms.Panel();
            this.pbr_loading = new System.Windows.Forms.ProgressBar();
            this.pnl_msg_open = new System.Windows.Forms.Panel();
            this.lab_searchcode = new System.Windows.Forms.Label();
            this.pln_have_back = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.but_send_date = new System.Windows.Forms.Button();
            this.txb_code = new System.Windows.Forms.TextBox();
            this.lab_Code_info = new System.Windows.Forms.Label();
            this.pnl_null_locker = new System.Windows.Forms.Panel();
            this.pnl_finish = new System.Windows.Forms.Panel();
            this.lab_finish = new System.Windows.Forms.Label();
            this.pnl_codeall = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lab_Code_Tekst = new System.Windows.Forms.Label();
            this.lab_Code = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnt_date = new System.Windows.Forms.TableLayoutPanel();
            this.txb_surname = new System.Windows.Forms.TextBox();
            this.lab_name = new System.Windows.Forms.Label();
            this.lab_Surname = new System.Windows.Forms.Label();
            this.lab_indeks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_indeks = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.btn_send_date = new System.Windows.Forms.Button();
            this.pnl_chose_but = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_have_locker = new System.Windows.Forms.Button();
            this.btn_null_locker = new System.Windows.Forms.Button();
            this.lab_start = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_finish_null = new System.Windows.Forms.Timer(this.components);
            this.tmr_locker_have = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_firstpanel.SuspendLayout();
            this.pnl_have_locker1.SuspendLayout();
            this.pnl_msg_open.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnl_null_locker.SuspendLayout();
            this.pnl_finish.SuspendLayout();
            this.pnl_codeall.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnt_date.SuspendLayout();
            this.pnl_chose_but.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.37931F));
            this.tableLayoutPanel1.Controls.Add(this.lab_info, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lab_time, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_firstpanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 561);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lab_info
            // 
            this.lab_info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_info.AutoSize = true;
            this.lab_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_info.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_info.Location = new System.Drawing.Point(390, 516);
            this.lab_info.Name = "lab_info";
            this.lab_info.Size = new System.Drawing.Size(62, 31);
            this.lab_info.TabIndex = 1;
            this.lab_info.Text = "Info";
            this.lab_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_time
            // 
            this.lab_time.AutoSize = true;
            this.lab_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_time.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_time.Location = new System.Drawing.Point(3, 0);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(837, 40);
            this.lab_time.TabIndex = 0;
            this.lab_time.Text = "Time";
            this.lab_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_firstpanel
            // 
            this.pnl_firstpanel.BackColor = System.Drawing.Color.Transparent;
            this.pnl_firstpanel.Controls.Add(this.pnl_have_locker1);
            this.pnl_firstpanel.Controls.Add(this.pnl_null_locker);
            this.pnl_firstpanel.Controls.Add(this.pnl_chose_but);
            this.pnl_firstpanel.Controls.Add(this.lab_start);
            this.pnl_firstpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_firstpanel.Location = new System.Drawing.Point(3, 43);
            this.pnl_firstpanel.Name = "pnl_firstpanel";
            this.pnl_firstpanel.Size = new System.Drawing.Size(837, 456);
            this.pnl_firstpanel.TabIndex = 2;
            this.pnl_firstpanel.Click += new System.EventHandler(this.pnl_firstpanel_Click);
            // 
            // pnl_have_locker1
            // 
            this.pnl_have_locker1.BackColor = System.Drawing.Color.Transparent;
            this.pnl_have_locker1.Controls.Add(this.pbr_loading);
            this.pnl_have_locker1.Controls.Add(this.pnl_msg_open);
            this.pnl_have_locker1.Controls.Add(this.pln_have_back);
            this.pnl_have_locker1.Controls.Add(this.tableLayoutPanel3);
            this.pnl_have_locker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_have_locker1.Location = new System.Drawing.Point(0, 0);
            this.pnl_have_locker1.Name = "pnl_have_locker1";
            this.pnl_have_locker1.Size = new System.Drawing.Size(837, 456);
            this.pnl_have_locker1.TabIndex = 6;
            this.pnl_have_locker1.Visible = false;
            // 
            // pbr_loading
            // 
            this.pbr_loading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbr_loading.Location = new System.Drawing.Point(267, 379);
            this.pbr_loading.Name = "pbr_loading";
            this.pbr_loading.Size = new System.Drawing.Size(313, 23);
            this.pbr_loading.TabIndex = 5;
            this.pbr_loading.Visible = false;
            // 
            // pnl_msg_open
            // 
            this.pnl_msg_open.Controls.Add(this.lab_searchcode);
            this.pnl_msg_open.Location = new System.Drawing.Point(140, 26);
            this.pnl_msg_open.Name = "pnl_msg_open";
            this.pnl_msg_open.Size = new System.Drawing.Size(572, 330);
            this.pnl_msg_open.TabIndex = 4;
            this.pnl_msg_open.Visible = false;
            // 
            // lab_searchcode
            // 
            this.lab_searchcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_searchcode.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_searchcode.Location = new System.Drawing.Point(0, 0);
            this.lab_searchcode.Name = "lab_searchcode";
            this.lab_searchcode.Size = new System.Drawing.Size(572, 330);
            this.lab_searchcode.TabIndex = 0;
            this.lab_searchcode.Text = "label1";
            this.lab_searchcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_searchcode.Visible = false;
            // 
            // pln_have_back
            // 
            this.pln_have_back.Location = new System.Drawing.Point(348, 408);
            this.pln_have_back.Name = "pln_have_back";
            this.pln_have_back.Size = new System.Drawing.Size(150, 23);
            this.pln_have_back.TabIndex = 3;
            this.pln_have_back.Text = "Wróć";
            this.pln_have_back.UseVisualStyleBackColor = true;
            this.pln_have_back.Click += new System.EventHandler(this.btn_have_back_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.72948F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.27052F));
            this.tableLayoutPanel3.Controls.Add(this.but_send_date, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txb_code, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lab_Code_info, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(264, 147);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.97987F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.02013F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(390, 191);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // but_send_date
            // 
            this.but_send_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.but_send_date.FlatAppearance.BorderSize = 0;
            this.but_send_date.Location = new System.Drawing.Point(197, 92);
            this.but_send_date.Name = "but_send_date";
            this.but_send_date.Size = new System.Drawing.Size(153, 24);
            this.but_send_date.TabIndex = 0;
            this.but_send_date.Text = "Wyślij";
            this.but_send_date.UseVisualStyleBackColor = true;
            this.but_send_date.Click += new System.EventHandler(this.but_send_date_Click_1);
            // 
            // txb_code
            // 
            this.txb_code.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_code.Location = new System.Drawing.Point(196, 33);
            this.txb_code.Name = "txb_code";
            this.txb_code.Size = new System.Drawing.Size(156, 23);
            this.txb_code.TabIndex = 1;
            // 
            // lab_Code_info
            // 
            this.lab_Code_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Code_info.AutoSize = true;
            this.lab_Code_info.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_Code_info.Location = new System.Drawing.Point(3, 0);
            this.lab_Code_info.Name = "lab_Code_info";
            this.lab_Code_info.Size = new System.Drawing.Size(152, 89);
            this.lab_Code_info.TabIndex = 2;
            this.lab_Code_info.Text = "Wpisz kod: ";
            this.lab_Code_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_null_locker
            // 
            this.pnl_null_locker.BackColor = System.Drawing.Color.Transparent;
            this.pnl_null_locker.Controls.Add(this.pnl_finish);
            this.pnl_null_locker.Controls.Add(this.pnl_codeall);
            this.pnl_null_locker.Controls.Add(this.btn_back);
            this.pnl_null_locker.Controls.Add(this.pnt_date);
            this.pnl_null_locker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_null_locker.Location = new System.Drawing.Point(0, 0);
            this.pnl_null_locker.Name = "pnl_null_locker";
            this.pnl_null_locker.Size = new System.Drawing.Size(837, 456);
            this.pnl_null_locker.TabIndex = 5;
            this.pnl_null_locker.Visible = false;
            // 
            // pnl_finish
            // 
            this.pnl_finish.Controls.Add(this.lab_finish);
            this.pnl_finish.Location = new System.Drawing.Point(226, 73);
            this.pnl_finish.Name = "pnl_finish";
            this.pnl_finish.Size = new System.Drawing.Size(428, 329);
            this.pnl_finish.TabIndex = 8;
            this.pnl_finish.Visible = false;
            // 
            // lab_finish
            // 
            this.lab_finish.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_finish.Location = new System.Drawing.Point(51, 41);
            this.lab_finish.Name = "lab_finish";
            this.lab_finish.Size = new System.Drawing.Size(351, 267);
            this.lab_finish.TabIndex = 0;
            this.lab_finish.Text = "Dziekujemy za skorzystanie z szafek :D\r\n";
            this.lab_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_codeall
            // 
            this.pnl_codeall.Controls.Add(this.tableLayoutPanel4);
            this.pnl_codeall.Location = new System.Drawing.Point(254, 91);
            this.pnl_codeall.Name = "pnl_codeall";
            this.pnl_codeall.Size = new System.Drawing.Size(388, 311);
            this.pnl_codeall.TabIndex = 1;
            this.pnl_codeall.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lab_Code_Tekst, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lab_Code, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(24, 32);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(316, 287);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lab_Code_Tekst
            // 
            this.lab_Code_Tekst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Code_Tekst.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_Code_Tekst.Location = new System.Drawing.Point(3, 143);
            this.lab_Code_Tekst.Name = "lab_Code_Tekst";
            this.lab_Code_Tekst.Size = new System.Drawing.Size(310, 144);
            this.lab_Code_Tekst.TabIndex = 1;
            this.lab_Code_Tekst.Text = "label2";
            this.lab_Code_Tekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Code
            // 
            this.lab_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_Code.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_Code.Location = new System.Drawing.Point(3, 0);
            this.lab_Code.Name = "lab_Code";
            this.lab_Code.Size = new System.Drawing.Size(310, 143);
            this.lab_Code.TabIndex = 0;
            this.lab_Code.Text = "label1";
            this.lab_Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.Location = new System.Drawing.Point(344, 408);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(154, 23);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Wróć";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnt_date
            // 
            this.pnt_date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnt_date.ColumnCount = 2;
            this.pnt_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnt_date.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.pnt_date.Controls.Add(this.txb_surname, 1, 1);
            this.pnt_date.Controls.Add(this.lab_name, 0, 0);
            this.pnt_date.Controls.Add(this.lab_Surname, 0, 1);
            this.pnt_date.Controls.Add(this.lab_indeks, 0, 2);
            this.pnt_date.Controls.Add(this.label4, 0, 3);
            this.pnt_date.Controls.Add(this.txb_name, 1, 0);
            this.pnt_date.Controls.Add(this.txb_indeks, 1, 2);
            this.pnt_date.Controls.Add(this.txb_email, 1, 3);
            this.pnt_date.Controls.Add(this.btn_send_date, 1, 4);
            this.pnt_date.Location = new System.Drawing.Point(271, 94);
            this.pnt_date.Name = "pnt_date";
            this.pnt_date.RowCount = 5;
            this.pnt_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.pnt_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.pnt_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.pnt_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.pnt_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.pnt_date.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnt_date.Size = new System.Drawing.Size(305, 262);
            this.pnt_date.TabIndex = 0;
            // 
            // txb_surname
            // 
            this.txb_surname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_surname.Location = new System.Drawing.Point(156, 67);
            this.txb_surname.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txb_surname.Name = "txb_surname";
            this.txb_surname.Size = new System.Drawing.Size(144, 23);
            this.txb_surname.TabIndex = 11;
            // 
            // lab_name
            // 
            this.lab_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_name.AutoSize = true;
            this.lab_name.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_name.Location = new System.Drawing.Point(32, 10);
            this.lab_name.Name = "lab_name";
            this.lab_name.Size = new System.Drawing.Size(81, 31);
            this.lab_name.TabIndex = 0;
            this.lab_name.Text = "Imie: ";
            // 
            // lab_Surname
            // 
            this.lab_Surname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_Surname.AutoSize = true;
            this.lab_Surname.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_Surname.Location = new System.Drawing.Point(3, 62);
            this.lab_Surname.Name = "lab_Surname";
            this.lab_Surname.Size = new System.Drawing.Size(140, 31);
            this.lab_Surname.TabIndex = 1;
            this.lab_Surname.Text = "Nazwisko: ";
            // 
            // lab_indeks
            // 
            this.lab_indeks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_indeks.AutoSize = true;
            this.lab_indeks.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_indeks.Location = new System.Drawing.Point(20, 114);
            this.lab_indeks.Name = "lab_indeks";
            this.lab_indeks.Size = new System.Drawing.Size(106, 31);
            this.lab_indeks.TabIndex = 2;
            this.lab_indeks.Text = "Indeks: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // txb_name
            // 
            this.txb_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_name.Location = new System.Drawing.Point(156, 15);
            this.txb_name.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(144, 23);
            this.txb_name.TabIndex = 12;
            // 
            // txb_indeks
            // 
            this.txb_indeks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_indeks.Location = new System.Drawing.Point(156, 119);
            this.txb_indeks.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txb_indeks.Name = "txb_indeks";
            this.txb_indeks.Size = new System.Drawing.Size(144, 23);
            this.txb_indeks.TabIndex = 13;
            // 
            // txb_email
            // 
            this.txb_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txb_email.Location = new System.Drawing.Point(156, 171);
            this.txb_email.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(144, 23);
            this.txb_email.TabIndex = 14;
            // 
            // btn_send_date
            // 
            this.btn_send_date.Location = new System.Drawing.Point(149, 211);
            this.btn_send_date.Name = "btn_send_date";
            this.btn_send_date.Size = new System.Drawing.Size(151, 48);
            this.btn_send_date.TabIndex = 15;
            this.btn_send_date.Text = "Wyślij";
            this.btn_send_date.UseVisualStyleBackColor = true;
            this.btn_send_date.Click += new System.EventHandler(this.btn_send_date_Click_1);
            // 
            // pnl_chose_but
            // 
            this.pnl_chose_but.BackColor = System.Drawing.Color.Transparent;
            this.pnl_chose_but.Controls.Add(this.tableLayoutPanel2);
            this.pnl_chose_but.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_chose_but.Location = new System.Drawing.Point(0, 0);
            this.pnl_chose_but.Name = "pnl_chose_but";
            this.pnl_chose_but.Size = new System.Drawing.Size(837, 456);
            this.pnl_chose_but.TabIndex = 4;
            this.pnl_chose_but.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btn_have_locker, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_null_locker, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 456);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btn_have_locker
            // 
            this.btn_have_locker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_have_locker.AutoSize = true;
            this.btn_have_locker.BackColor = System.Drawing.Color.Transparent;
            this.btn_have_locker.FlatAppearance.BorderSize = 0;
            this.btn_have_locker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_have_locker.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_have_locker.Location = new System.Drawing.Point(3, 3);
            this.btn_have_locker.Name = "btn_have_locker";
            this.btn_have_locker.Size = new System.Drawing.Size(831, 205);
            this.btn_have_locker.TabIndex = 0;
            this.btn_have_locker.Text = "Mam szfkę";
            this.btn_have_locker.UseVisualStyleBackColor = false;
            this.btn_have_locker.Click += new System.EventHandler(this.btn_have_locker_Click);
            // 
            // btn_null_locker
            // 
            this.btn_null_locker.AutoSize = true;
            this.btn_null_locker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_null_locker.FlatAppearance.BorderSize = 0;
            this.btn_null_locker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_null_locker.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_null_locker.Location = new System.Drawing.Point(3, 214);
            this.btn_null_locker.Name = "btn_null_locker";
            this.btn_null_locker.Size = new System.Drawing.Size(831, 239);
            this.btn_null_locker.TabIndex = 1;
            this.btn_null_locker.Text = "Wypożycz szafkę";
            this.btn_null_locker.UseVisualStyleBackColor = true;
            this.btn_null_locker.Click += new System.EventHandler(this.btn_null_locker_Click);
            // 
            // lab_start
            // 
            this.lab_start.BackColor = System.Drawing.Color.Transparent;
            this.lab_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_start.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lab_start.Location = new System.Drawing.Point(0, 0);
            this.lab_start.Name = "lab_start";
            this.lab_start.Size = new System.Drawing.Size(837, 456);
            this.lab_start.TabIndex = 3;
            this.lab_start.Text = "Jeżeli chcesz wypozyczyć szafkę\r\nKliknij w ekran!\r\n";
            this.lab_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_start.Click += new System.EventHandler(this.lab_start_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tmr_finish_null
            // 
            this.tmr_finish_null.Interval = 1000;
            this.tmr_finish_null.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // tmr_locker_have
            // 
            this.tmr_locker_have.Interval = 1000;
            this.tmr_locker_have.Tick += new System.EventHandler(this.tmr_locker_have_Tick_1);
            // 
            // Szafkomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(843, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Szafkomat";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnl_firstpanel.ResumeLayout(false);
            this.pnl_have_locker1.ResumeLayout(false);
            this.pnl_msg_open.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnl_null_locker.ResumeLayout(false);
            this.pnl_finish.ResumeLayout(false);
            this.pnl_codeall.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.pnt_date.ResumeLayout(false);
            this.pnt_date.PerformLayout();
            this.pnl_chose_but.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label lab_info;
        private System.Windows.Forms.Panel pnl_firstpanel;
        private System.Windows.Forms.Label lab_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_chose_but;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_have_locker;
        private System.Windows.Forms.Button btn_null_locker;
        private System.Windows.Forms.Panel pnl_null_locker;
        private System.Windows.Forms.Panel pnl_have_locker1;
        private System.Windows.Forms.TableLayoutPanel pnt_date;
        private System.Windows.Forms.TextBox txb_surname;
        private System.Windows.Forms.Label lab_name;
        private System.Windows.Forms.Label lab_Surname;
        private System.Windows.Forms.Label lab_indeks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_indeks;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Button btn_send_date;
        private System.Windows.Forms.Panel pnl_codeall;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lab_Code;
        private System.Windows.Forms.Label lab_Code_Tekst;
        
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_finish;
        private System.Windows.Forms.Label lab_finish;
        private System.Windows.Forms.Timer tmr_finish_null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button but_send_date;
        private System.Windows.Forms.TextBox txb_code;
        private System.Windows.Forms.Label lab_Code_info;
        
        private System.Windows.Forms.Label lab_searchcode;
        private System.Windows.Forms.Button pln_have_back;
        private System.Windows.Forms.Timer tmr_locker_have;
        private System.Windows.Forms.ProgressBar pbr_loading;
        private System.Windows.Forms.Panel pnl_msg_open;
    }
}

