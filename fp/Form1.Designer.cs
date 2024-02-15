namespace fp
{
    partial class Form1
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
            btnConnect = new Button();
            rbnSql = new RadioButton();
            tbxMain = new TextBox();
            btnDisconnect = new Button();
            rbnMysql = new RadioButton();
            gbxAnalisys = new GroupBox();
            btnAnalyze = new Button();
            cbxViews = new CheckBox();
            cbxFunctions = new CheckBox();
            cbxProcedures = new CheckBox();
            cbxTables = new CheckBox();
            gbxSaving = new GroupBox();
            rbnDB = new RadioButton();
            rbnXml = new RadioButton();
            rbnJson = new RadioButton();
            rbnTxt = new RadioButton();
            btnSave = new Button();
            cmbxDB = new ComboBox();
            lblDB = new Label();
            lbxMain = new ListBox();
            lblConn = new Label();
            gbxAnalisys.SuspendLayout();
            gbxSaving.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(857, 47);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(105, 33);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // rbnSql
            // 
            rbnSql.AutoSize = true;
            rbnSql.Location = new Point(12, 16);
            rbnSql.Name = "rbnSql";
            rbnSql.Size = new Size(106, 25);
            rbnSql.TabIndex = 1;
            rbnSql.TabStop = true;
            rbnSql.Text = "SQL Server";
            rbnSql.UseVisualStyleBackColor = true;
            // 
            // tbxMain
            // 
            tbxMain.Location = new Point(137, 12);
            tbxMain.Name = "tbxMain";
            tbxMain.Size = new Size(825, 29);
            tbxMain.TabIndex = 2;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(857, 86);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(105, 33);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // rbnMysql
            // 
            rbnMysql.AutoSize = true;
            rbnMysql.Location = new Point(12, 47);
            rbnMysql.Name = "rbnMysql";
            rbnMysql.Size = new Size(128, 25);
            rbnMysql.TabIndex = 4;
            rbnMysql.TabStop = true;
            rbnMysql.Text = "MySQL Server";
            rbnMysql.UseVisualStyleBackColor = true;
            // 
            // gbxAnalisys
            // 
            gbxAnalisys.Controls.Add(btnAnalyze);
            gbxAnalisys.Controls.Add(cbxViews);
            gbxAnalisys.Controls.Add(cbxFunctions);
            gbxAnalisys.Controls.Add(cbxProcedures);
            gbxAnalisys.Controls.Add(cbxTables);
            gbxAnalisys.Location = new Point(12, 155);
            gbxAnalisys.Name = "gbxAnalisys";
            gbxAnalisys.Size = new Size(200, 250);
            gbxAnalisys.TabIndex = 5;
            gbxAnalisys.TabStop = false;
            gbxAnalisys.Text = "Analisys";
            gbxAnalisys.Enter += groupBox1_Enter;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(15, 203);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(170, 30);
            btnAnalyze.TabIndex = 4;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            // 
            // cbxViews
            // 
            cbxViews.AutoSize = true;
            cbxViews.Location = new Point(15, 160);
            cbxViews.Name = "cbxViews";
            cbxViews.Size = new Size(70, 25);
            cbxViews.TabIndex = 3;
            cbxViews.Text = "Views";
            cbxViews.UseVisualStyleBackColor = true;
            // 
            // cbxFunctions
            // 
            cbxFunctions.AutoSize = true;
            cbxFunctions.Location = new Point(15, 120);
            cbxFunctions.Name = "cbxFunctions";
            cbxFunctions.Size = new Size(96, 25);
            cbxFunctions.TabIndex = 2;
            cbxFunctions.Text = "Functions";
            cbxFunctions.UseVisualStyleBackColor = true;
            // 
            // cbxProcedures
            // 
            cbxProcedures.AutoSize = true;
            cbxProcedures.Location = new Point(15, 80);
            cbxProcedures.Name = "cbxProcedures";
            cbxProcedures.Size = new Size(107, 25);
            cbxProcedures.TabIndex = 1;
            cbxProcedures.Text = "Procedures";
            cbxProcedures.UseVisualStyleBackColor = true;
            // 
            // cbxTables
            // 
            cbxTables.AutoSize = true;
            cbxTables.Location = new Point(15, 40);
            cbxTables.Name = "cbxTables";
            cbxTables.Size = new Size(71, 25);
            cbxTables.TabIndex = 0;
            cbxTables.Text = "Tables";
            cbxTables.UseVisualStyleBackColor = true;
            // 
            // gbxSaving
            // 
            gbxSaving.Controls.Add(rbnDB);
            gbxSaving.Controls.Add(rbnXml);
            gbxSaving.Controls.Add(rbnJson);
            gbxSaving.Controls.Add(rbnTxt);
            gbxSaving.Controls.Add(btnSave);
            gbxSaving.Location = new Point(762, 155);
            gbxSaving.Name = "gbxSaving";
            gbxSaving.Size = new Size(200, 250);
            gbxSaving.TabIndex = 6;
            gbxSaving.TabStop = false;
            gbxSaving.Text = "Saving";
            // 
            // rbnDB
            // 
            rbnDB.AutoSize = true;
            rbnDB.Location = new Point(15, 160);
            rbnDB.Name = "rbnDB";
            rbnDB.Size = new Size(48, 25);
            rbnDB.TabIndex = 8;
            rbnDB.TabStop = true;
            rbnDB.Text = "DB";
            rbnDB.UseVisualStyleBackColor = true;
            // 
            // rbnXml
            // 
            rbnXml.AutoSize = true;
            rbnXml.Location = new Point(15, 80);
            rbnXml.Name = "rbnXml";
            rbnXml.Size = new Size(55, 25);
            rbnXml.TabIndex = 7;
            rbnXml.TabStop = true;
            rbnXml.Text = "Xml";
            rbnXml.UseVisualStyleBackColor = true;
            // 
            // rbnJson
            // 
            rbnJson.AutoSize = true;
            rbnJson.Location = new Point(15, 120);
            rbnJson.Name = "rbnJson";
            rbnJson.Size = new Size(59, 25);
            rbnJson.TabIndex = 6;
            rbnJson.TabStop = true;
            rbnJson.Text = "Json";
            rbnJson.UseVisualStyleBackColor = true;
            // 
            // rbnTxt
            // 
            rbnTxt.AutoSize = true;
            rbnTxt.Location = new Point(15, 40);
            rbnTxt.Name = "rbnTxt";
            rbnTxt.Size = new Size(47, 25);
            rbnTxt.TabIndex = 5;
            rbnTxt.TabStop = true;
            rbnTxt.Text = "Txt";
            rbnTxt.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(15, 203);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 30);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbxDB
            // 
            cmbxDB.FormattingEnabled = true;
            cmbxDB.Location = new Point(91, 104);
            cmbxDB.Name = "cmbxDB";
            cmbxDB.Size = new Size(121, 29);
            cmbxDB.TabIndex = 7;
            // 
            // lblDB
            // 
            lblDB.AutoSize = true;
            lblDB.Location = new Point(12, 107);
            lblDB.Name = "lblDB";
            lblDB.Size = new Size(77, 21);
            lblDB.TabIndex = 8;
            lblDB.Text = "Database:";
            // 
            // lbxMain
            // 
            lbxMain.FormattingEnabled = true;
            lbxMain.ItemHeight = 21;
            lbxMain.Location = new Point(229, 107);
            lbxMain.Name = "lbxMain";
            lbxMain.Size = new Size(516, 298);
            lbxMain.TabIndex = 9;
            // 
            // lblConn
            // 
            lblConn.AutoSize = true;
            lblConn.Location = new Point(450, 47);
            lblConn.Name = "lblConn";
            lblConn.Size = new Size(147, 21);
            lblConn.TabIndex = 10;
            lblConn.Text = "(connections string)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 431);
            Controls.Add(lblConn);
            Controls.Add(lbxMain);
            Controls.Add(lblDB);
            Controls.Add(cmbxDB);
            Controls.Add(gbxSaving);
            Controls.Add(gbxAnalisys);
            Controls.Add(rbnMysql);
            Controls.Add(btnDisconnect);
            Controls.Add(tbxMain);
            Controls.Add(rbnSql);
            Controls.Add(btnConnect);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "DatabaseAnalyzer";
            gbxAnalisys.ResumeLayout(false);
            gbxAnalisys.PerformLayout();
            gbxSaving.ResumeLayout(false);
            gbxSaving.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private RadioButton rbnSql;
        private TextBox tbxMain;
        private Button btnDisconnect;
        private RadioButton rbnMysql;
        private GroupBox gbxAnalisys;
        private CheckBox cbxViews;
        private CheckBox cbxFunctions;
        private CheckBox cbxProcedures;
        private CheckBox cbxTables;
        private Button btnAnalyze;
        private GroupBox gbxSaving;
        private RadioButton rbnDB;
        private RadioButton rbnXml;
        private RadioButton rbnJson;
        private RadioButton rbnTxt;
        private Button btnSave;
        private ComboBox cmbxDB;
        private Label lblDB;
        private ListBox lbxMain;
        private Label lblConn;
    }
}