using Microsoft.EntityFrameworkCore;
namespace books
{
    public partial class Form1 : Form
    {

        string con = "Server=STHQ0116-07; Database=Loggining_test; Initial Catalog = Loginingtest;User Id=admin; Password=admin";
        
        public Form1()
        {
            InitializeComponent();
            List_of_cotegoris_combobox.Items.Add("Theams");
            List_of_cotegoris_combobox.Items.Add("Authors");
            List_of_cotegoris_combobox.Items.Add("Press");
            List_of_cotegoris_combobox.Items.Add("Category");
            Items_combobox.Enabled = false;
        }

        private void List_of_cotegoris_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Items_combobox.Items.Clear();

            Items_combobox.Enabled = true;

            if(List_of_cotegoris_combobox.Text == "Theams")
            {
                using (LibraryContext db = new())
                {
                    List<Theme> tms = db.Themes.ToList();

                    foreach (var item in tms)
                    {
                        Items_combobox.Items.Add(item.Name);
                    }
                }
            }
            else if (List_of_cotegoris_combobox.Text == "Authors")
            {
                using (LibraryContext db = new())
                {
                    List<Author> tms = db.Authors.ToList();

                    foreach (var item in tms)
                    {
                        Items_combobox.Items.Add(item.FirstName+' '+item.LastName);
                    }
                }
            }
            else if (List_of_cotegoris_combobox.Text == "Press")
            {
                using (LibraryContext db = new())
                {
                    List<Press> tms = db.Presses.ToList();

                    foreach (var item in tms)
                    {
                        Items_combobox.Items.Add(item.Name);
                    }
                }
            }
            else if (List_of_cotegoris_combobox.Text == "Category")
            {
                using (LibraryContext db = new())
                {
                    List<Category> tms = db.Categories.ToList();

                    foreach (var item in tms)
                    {
                        Items_combobox.Items.Add(item.Name);
                    }
                }
            }
        }

        private void Items_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(List_of_cotegoris_combobox.Text == "Theams")
            {
                using (LibraryContext db = new())
                {
                    List<Book> Books = db.Books.Where(x => x.IdThemes == Items_combobox.Text).ToList<Theme>();
                    dataGridView1.DataSource = themes;
                }
            }
        }
    }
}