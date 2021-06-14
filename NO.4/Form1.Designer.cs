namespace NO._4
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label creditLabel;
            System.Windows.Forms.Label professorLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label gradeLabel;
            System.Windows.Forms.Label semesterLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.data_0814_5PM = new NO._4.data_0814_5PM();
            this.gPABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPATableAdapter = new NO._4.data_0814_5PMTableAdapters.GPATableAdapter();
            this.tableAdapterManager = new NO._4.data_0814_5PMTableAdapters.TableAdapterManager();
            this.gPADataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPABindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gPABindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.add_row_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.delete_row_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.end_edit_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.save_button = new MaterialSkin.Controls.MaterialFlatButton();
            this.calculate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.result_lable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gPABindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.creditNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.grade = new System.Windows.Forms.ComboBox();
            this.noteTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Course = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.professorTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.semester = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.recordQue = new System.Windows.Forms.Label();
            this.rowQue = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            gradeLabel = new System.Windows.Forms.Label();
            semesterLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_0814_5PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.ForeColor = System.Drawing.Color.Maroon;
            idLabel.Location = new System.Drawing.Point(3, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(28, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "* ID:";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.ForeColor = System.Drawing.Color.Maroon;
            courseLabel.Location = new System.Drawing.Point(3, 27);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(50, 13);
            courseLabel.TabIndex = 4;
            courseLabel.Text = "* Course:";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.ForeColor = System.Drawing.Color.Maroon;
            creditLabel.Location = new System.Drawing.Point(176, 55);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(44, 13);
            creditLabel.TabIndex = 6;
            creditLabel.Text = "* Credit:";
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.ForeColor = System.Drawing.Color.Maroon;
            professorLabel.Location = new System.Drawing.Point(3, 55);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(61, 13);
            professorLabel.TabIndex = 10;
            professorLabel.Text = "* Professor:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            noteLabel.Location = new System.Drawing.Point(176, 83);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(33, 13);
            noteLabel.TabIndex = 12;
            noteLabel.Text = "Note:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.ForeColor = System.Drawing.Color.Maroon;
            gradeLabel.Location = new System.Drawing.Point(176, 27);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new System.Drawing.Size(46, 13);
            gradeLabel.TabIndex = 20;
            gradeLabel.Text = "* Grade:";
            // 
            // semesterLabel1
            // 
            semesterLabel1.AutoSize = true;
            semesterLabel1.ForeColor = System.Drawing.Color.Maroon;
            semesterLabel1.Location = new System.Drawing.Point(3, 83);
            semesterLabel1.Name = "semesterLabel1";
            semesterLabel1.Size = new System.Drawing.Size(61, 13);
            semesterLabel1.TabIndex = 21;
            semesterLabel1.Text = "* Semester:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            label1.Location = new System.Drawing.Point(180, 620);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(141, 22);
            label1.TabIndex = 26;
            label1.Text = "Your GPA is :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label2.Location = new System.Drawing.Point(80, 183);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(254, 17);
            label2.TabIndex = 30;
            label2.Text = "SELECT A CELL AND START EDITING";
            // 
            // data_0814_5PM
            // 
            this.data_0814_5PM.DataSetName = "data_0814_5PM";
            this.data_0814_5PM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gPABindingSource
            // 
            this.gPABindingSource.DataMember = "GPA";
            this.gPABindingSource.DataSource = this.data_0814_5PM;
            // 
            // gPATableAdapter
            // 
            this.gPATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GPATableAdapter = this.gPATableAdapter;
            this.tableAdapterManager.UpdateOrder = NO._4.data_0814_5PMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gPADataGridView
            // 
            this.gPADataGridView.AutoGenerateColumns = false;
            this.gPADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gPADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.creditDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.professorDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.gPADataGridView.DataSource = this.gPABindingSource3;
            this.gPADataGridView.Location = new System.Drawing.Point(37, 418);
            this.gPADataGridView.Name = "gPADataGridView";
            this.gPADataGridView.Size = new System.Drawing.Size(447, 170);
            this.gPADataGridView.TabIndex = 1;
            this.gPADataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gPADataGridView_CellClick);
            this.gPADataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gPADataGridView_DataBindingComplete);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // creditDataGridViewTextBoxColumn
            // 
            this.creditDataGridViewTextBoxColumn.DataPropertyName = "Credit";
            this.creditDataGridViewTextBoxColumn.HeaderText = "Credit";
            this.creditDataGridViewTextBoxColumn.Name = "creditDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // professorDataGridViewTextBoxColumn
            // 
            this.professorDataGridViewTextBoxColumn.DataPropertyName = "Professor";
            this.professorDataGridViewTextBoxColumn.HeaderText = "Professor";
            this.professorDataGridViewTextBoxColumn.Name = "professorDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // gPABindingSource3
            // 
            this.gPABindingSource3.DataMember = "GPA";
            this.gPABindingSource3.DataSource = this.data_0814_5PM;
            // 
            // gPABindingSource2
            // 
            this.gPABindingSource2.DataMember = "GPA";
            this.gPABindingSource2.DataSource = this.data_0814_5PM;
            // 
            // add_row_button
            // 
            this.add_row_button.Depth = 0;
            this.add_row_button.Location = new System.Drawing.Point(213, 365);
            this.add_row_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_row_button.Name = "add_row_button";
            this.add_row_button.Primary = true;
            this.add_row_button.Size = new System.Drawing.Size(93, 34);
            this.add_row_button.TabIndex = 16;
            this.add_row_button.Text = "Add row";
            this.add_row_button.UseVisualStyleBackColor = true;
            this.add_row_button.Click += new System.EventHandler(this.add_row_button_Click);
            // 
            // delete_row_button
            // 
            this.delete_row_button.Depth = 0;
            this.delete_row_button.Location = new System.Drawing.Point(328, 365);
            this.delete_row_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_row_button.Name = "delete_row_button";
            this.delete_row_button.Primary = true;
            this.delete_row_button.Size = new System.Drawing.Size(115, 34);
            this.delete_row_button.TabIndex = 17;
            this.delete_row_button.Text = "Delete row";
            this.delete_row_button.UseVisualStyleBackColor = true;
            this.delete_row_button.Click += new System.EventHandler(this.delete_row_button_Click);
            // 
            // end_edit_button
            // 
            this.end_edit_button.Depth = 0;
            this.end_edit_button.Location = new System.Drawing.Point(83, 364);
            this.end_edit_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.end_edit_button.Name = "end_edit_button";
            this.end_edit_button.Primary = true;
            this.end_edit_button.Size = new System.Drawing.Size(106, 35);
            this.end_edit_button.TabIndex = 19;
            this.end_edit_button.Text = "update";
            this.end_edit_button.UseVisualStyleBackColor = true;
            this.end_edit_button.Click += new System.EventHandler(this.end_edit_button_Click);
            // 
            // save_button
            // 
            this.save_button.AutoSize = true;
            this.save_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_button.Depth = 0;
            this.save_button.Location = new System.Drawing.Point(37, 670);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_button.Name = "save_button";
            this.save_button.Primary = false;
            this.save_button.Size = new System.Drawing.Size(46, 36);
            this.save_button.TabIndex = 20;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // calculate
            // 
            this.calculate.Depth = 0;
            this.calculate.Location = new System.Drawing.Point(37, 609);
            this.calculate.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculate.Name = "calculate";
            this.calculate.Primary = true;
            this.calculate.Size = new System.Drawing.Size(122, 48);
            this.calculate.TabIndex = 23;
            this.calculate.Text = "calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // result_lable
            // 
            this.result_lable.AutoSize = true;
            this.result_lable.BackColor = System.Drawing.Color.Transparent;
            this.result_lable.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lable.ForeColor = System.Drawing.Color.Teal;
            this.result_lable.Location = new System.Drawing.Point(315, 605);
            this.result_lable.Name = "result_lable";
            this.result_lable.Size = new System.Drawing.Size(79, 78);
            this.result_lable.TabIndex = 24;
            this.result_lable.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NO._4.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 150);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // gPABindingSource1
            // 
            this.gPABindingSource1.DataMember = "GPA";
            this.gPABindingSource1.DataSource = this.data_0814_5PM;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(521, 13);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox3.Location = new System.Drawing.Point(0, 728);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(521, 13);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.Controls.Add(this.creditNumericUpDown, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.idLabel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grade, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.noteTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(courseLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(professorLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(semesterLabel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(gradeLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(creditLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(noteLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(idLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Course, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.professorTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.semester, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 109);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // creditNumericUpDown
            // 
            this.creditNumericUpDown.Location = new System.Drawing.Point(236, 58);
            this.creditNumericUpDown.Name = "creditNumericUpDown";
            this.creditNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.creditNumericUpDown.TabIndex = 49;
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Depth = 0;
            this.idLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.idLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.idLabel1.Location = new System.Drawing.Point(82, 0);
            this.idLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(13, 19);
            this.idLabel1.TabIndex = 47;
            this.idLabel1.Text = " ";
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "A+",
            "A",
            "B+",
            "B",
            "C+",
            "C",
            "C+",
            "D",
            "F"});
            this.grade.Location = new System.Drawing.Point(236, 30);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(44, 21);
            this.grade.TabIndex = 47;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Depth = 0;
            this.noteTextBox.Hint = "";
            this.noteTextBox.Location = new System.Drawing.Point(236, 86);
            this.noteTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.PasswordChar = '\0';
            this.noteTextBox.SelectedText = "";
            this.noteTextBox.SelectionLength = 0;
            this.noteTextBox.SelectionStart = 0;
            this.noteTextBox.Size = new System.Drawing.Size(197, 23);
            this.noteTextBox.TabIndex = 47;
            this.noteTextBox.UseSystemPasswordChar = false;
            // 
            // Course
            // 
            this.Course.Depth = 0;
            this.Course.Hint = "";
            this.Course.Location = new System.Drawing.Point(82, 30);
            this.Course.MouseState = MaterialSkin.MouseState.HOVER;
            this.Course.Name = "Course";
            this.Course.PasswordChar = '\0';
            this.Course.SelectedText = "";
            this.Course.SelectionLength = 0;
            this.Course.SelectionStart = 0;
            this.Course.Size = new System.Drawing.Size(88, 23);
            this.Course.TabIndex = 23;
            this.Course.UseSystemPasswordChar = false;
            // 
            // professorTextBox
            // 
            this.professorTextBox.Depth = 0;
            this.professorTextBox.Hint = "";
            this.professorTextBox.Location = new System.Drawing.Point(82, 58);
            this.professorTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.professorTextBox.Name = "professorTextBox";
            this.professorTextBox.PasswordChar = '\0';
            this.professorTextBox.SelectedText = "";
            this.professorTextBox.SelectionLength = 0;
            this.professorTextBox.SelectionStart = 0;
            this.professorTextBox.Size = new System.Drawing.Size(88, 23);
            this.professorTextBox.TabIndex = 24;
            this.professorTextBox.UseSystemPasswordChar = false;
            // 
            // semester
            // 
            this.semester.Depth = 0;
            this.semester.Hint = "";
            this.semester.Location = new System.Drawing.Point(82, 86);
            this.semester.MouseState = MaterialSkin.MouseState.HOVER;
            this.semester.Name = "semester";
            this.semester.PasswordChar = '\0';
            this.semester.SelectedText = "";
            this.semester.SelectionLength = 0;
            this.semester.SelectionStart = 0;
            this.semester.Size = new System.Drawing.Size(27, 23);
            this.semester.TabIndex = 25;
            this.semester.UseSystemPasswordChar = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox5.Location = new System.Drawing.Point(506, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 531);
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // recordQue
            // 
            this.recordQue.AutoSize = true;
            this.recordQue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recordQue.Location = new System.Drawing.Point(184, 687);
            this.recordQue.Name = "recordQue";
            this.recordQue.Size = new System.Drawing.Size(87, 13);
            this.recordQue.TabIndex = 44;
            this.recordQue.Text = "Calculate recrod:";
            // 
            // rowQue
            // 
            this.rowQue.AutoSize = true;
            this.rowQue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rowQue.Location = new System.Drawing.Point(184, 706);
            this.rowQue.Name = "rowQue";
            this.rowQue.Size = new System.Drawing.Size(13, 13);
            this.rowQue.TabIndex = 45;
            this.rowQue.Text = "  ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.GrayText;
            this.pictureBox6.Location = new System.Drawing.Point(-2, 210);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 531);
            this.pictureBox6.TabIndex = 46;
            this.pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(520, 740);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.rowQue);
            this.Controls.Add(this.recordQue);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.result_lable);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.end_edit_button);
            this.Controls.Add(this.delete_row_button);
            this.Controls.Add(this.add_row_button);
            this.Controls.Add(this.gPADataGridView);
            this.MaximumSize = new System.Drawing.Size(520, 740);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Test - XuTung Jin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_0814_5PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPABindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private data_0814_5PM data_0814_5PM;
        private System.Windows.Forms.BindingSource gPABindingSource;
        private data_0814_5PMTableAdapters.GPATableAdapter gPATableAdapter;
        private data_0814_5PMTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gPADataGridView;
        private MaterialSkin.Controls.MaterialRaisedButton add_row_button;
        private MaterialSkin.Controls.MaterialRaisedButton delete_row_button;
        private MaterialSkin.Controls.MaterialRaisedButton end_edit_button;
        private MaterialSkin.Controls.MaterialFlatButton save_button;
        private MaterialSkin.Controls.MaterialRaisedButton calculate;
        private System.Windows.Forms.Label result_lable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource gPABindingSource2;
        private System.Windows.Forms.BindingSource gPABindingSource1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label recordQue;
        private System.Windows.Forms.Label rowQue;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialSingleLineTextField Course;
        private MaterialSkin.Controls.MaterialSingleLineTextField professorTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField semester;
        private MaterialSkin.Controls.MaterialSingleLineTextField noteTextBox;
        private MaterialSkin.Controls.MaterialLabel idLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gPABindingSource3;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.NumericUpDown creditNumericUpDown;
    }
}

