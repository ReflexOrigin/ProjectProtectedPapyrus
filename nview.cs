using System.Windows.Forms;
using System.Data;
using System;
using System.Data.SqlClient;

namespace ProjectProtectedPapyrus
{
    public partial class nview : Form
    {
        public nview()
        {
            InitializeComponent();


        }



        private void NoteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // GetNoteData();
        }

        private void nview_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Notes", "Data Source=DESKTOP-HSN8CBB;Initial Catalog=ProjectProtectedPapyrus;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds, "Notes");
            NoteDataGridView.DataSource = ds.Tables["Notes"].DefaultView;
        }


    }
}