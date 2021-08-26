using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;

namespace NO._4
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm     
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
            //Material skin
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey600, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.gPATableAdapter.Fill(this.data_0814_5PM.GPA);
            
            //Bring window to the front
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        //Binding gridView selected row's data with textBoxes
        int indexRow;
        private void gPADataGridView_CellClick(object sender, DataGridViewCellEventArgs e)   
        {
            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                idLabel1.Text = this.gPADataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Course.Text = this.gPADataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                grade.Text = this.gPADataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                creditNumericUpDown.Text = this.gPADataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                semester.Text = this.gPADataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                professorTextBox.Text = this.gPADataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                noteTextBox.Text = this.gPADataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        //Cancel onload first grid binding 
        private void gPADataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)  
        {
            gPADataGridView.Rows[0].Selected = false;
        }

        private void end_edit_button_Click(object sender, EventArgs e)   //Update button
        {
            try
            {
                DataGridViewRow newRow = gPADataGridView.Rows[indexRow];   //Create a new row
                newRow.Cells[1].Value = Course.Text;
                newRow.Cells[2].Value = grade.Text;
                newRow.Cells[3].Value = Convert.ToInt32(creditNumericUpDown.Text);
                newRow.Cells[4].Value = Convert.ToInt32(semester.Text);
                newRow.Cells[5].Value = professorTextBox.Text;
                newRow.Cells[6].Value = noteTextBox.Text;

                gPADataGridView.Rows[indexRow].Selected = true;

                foreach (DataGridViewRow row in gPADataGridView.SelectedRows)   //Assign gridview value
                {
                    row.Cells[1].Value = newRow.Cells[1].Value;
                    row.Cells[2].Value = newRow.Cells[2].Value;
                    row.Cells[3].Value = newRow.Cells[3].Value;
                    row.Cells[4].Value = newRow.Cells[4].Value;
                    row.Cells[5].Value = newRow.Cells[5].Value;
                    row.Cells[6].Value = newRow.Cells[6].Value;
                }
                this.BindingContext[data_0814_5PM.GPA].EndCurrentEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_row_button_Click(object sender, EventArgs e)   //Add row
        {
            try
            {
                data_0814_5PM.GPA.AddGPARow(data_0814_5PM.GPA.NewGPARow());
                gPADataGridView.Rows[0].Selected = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                data_0814_5PM.GPA.RejectChanges();
            }
        }

        private void delete_row_button_Click(object sender, EventArgs e)    //Delete row
        {
            try
            {
                foreach (DataGridViewCell oneCell in gPADataGridView.SelectedCells)
                {
                    if (oneCell.Selected)
                    gPADataGridView.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message, "Message",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
               data_0814_5PM.GPA.RejectChanges();
            }
        }

        private void save_button_Click(object sender, EventArgs e)   //Save data
        {
            try
            {
                this.Validate();
                this.gPABindingSource3.EndEdit();
                this.gPATableAdapter.Update(this.data_0814_5PM.GPA);
                MessageBox.Show("Save successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                data_0814_5PM.GPA.RejectChanges();
            }
        }
        private void calculate_Click(object sender, EventArgs e)   //GPA calculator
        {
            List<object> gradeListS = new List<object>();
            gradeListS = (from DataGridViewRow row in gPADataGridView.Rows
                          where row.Cells[2].FormattedValue.ToString() != string.Empty
                          select row.Cells[2].FormattedValue).ToList();

            List<int> gradeList = new List<int>();
            for (int counter = 0; counter < gradeListS.Count; counter++)
            {
                switch (gradeListS[counter])
                {
                    case "A+":
                        gradeList.Add(9);
                        break;
                    case "A":
                        gradeList.Add(8);
                        break;
                    case "B+":
                        gradeList.Add(7);
                        break;
                    case "B":
                        gradeList.Add(6);
                        break;
                    case "C+":
                        gradeList.Add(5);
                        break;
                    case "C":
                        gradeList.Add(4);
                        break;
                    case "C-":
                        gradeList.Add(3);
                        break;
                    case "D":
                        gradeList.Add(2);
                        break;
                    case "F":
                        gradeList.Add(1);
                        break;
                    default:
                        gradeList.Add(0);
                        break;
                }
            }

            List<int> creditList = new List<int>();
            creditList = (from DataGridViewRow row in gPADataGridView.Rows
                          where row.Cells[3].FormattedValue.ToString() != string.Empty
                          select Convert.ToInt32(row.Cells[3].FormattedValue)).ToList();

            List<double> gpaList = new List<double>();
            for (int counter = 0; counter < gradeList.Count; counter++)
            {
                double d = gradeList[counter] * creditList[counter];
                gpaList.Add(d);
            }

            double gpaSum = gpaList.Sum();
            double creditCount = creditList.Sum();
            double result = Math.Round(gpaSum / creditCount, 2);

            result_lable.Text = result.ToString();

            xuTungJin_programming2();
        }
        private void xuTungJin_programming2()     //Use Queue to create GPA record
        {
            int[] idArray = (from DataGridViewRow row in gPADataGridView.Rows
                             where row.Cells[0].FormattedValue.ToString() != string.Empty
                             select Convert.ToInt32(row.Cells[0].FormattedValue)).ToArray();

            Queue<int> idQue = new Queue<int>();
            for (int counter = 0; counter < idArray.Length; counter++)
            idQue.Enqueue(idArray[counter]);

            string s = "Rows ID ";

            while (idQue.Count > 0)
            s += idQue.Dequeue().ToString() + " . ";
            
            rowQue.Text = s;
        }
    }
}
