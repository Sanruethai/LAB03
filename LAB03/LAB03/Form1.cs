namespace LAB03
{
    public partial class Student : Form
    {
        private int n = 0;
        public Student()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = txtID.Text;
            dataGridView1.Rows[n].Cells[1].Value = txtName.Text;
            dataGridView1.Rows[n].Cells[2].Value = txtBirth.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtStature.Text;
            dataGridView1.Rows[n].Cells[4].Value = txtGrade.Text;
            dataGridView1.Rows[n].Cells[5].Value = txtBranch.Text;

            txtID.Text = "";
            txtName.Text = "";
            txtBirth.Text = "";
            txtStature.Text = "";
            txtGrade.Text = "";
            txtBranch.Text = "";

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(n!= -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }
    }
}