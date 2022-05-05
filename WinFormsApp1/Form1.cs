using Book_Store_App.Models;
using System.Diagnostics;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
       readonly List<Book> Books = new();

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {          
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) | string.IsNullOrEmpty(textBox2.Text) | string.IsNullOrEmpty(textBox5.Text))
                {
                    MessageBox.Show("You must fill all of the required  information to proceed");
                    return;
                }                           
                else
                {
                    Book books2 = new(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox5.Text);
                    Books.Add(books2);
                }
                MessageBox.Show("You have successfully added a book!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a whole number in the Year field!");
            }          
        }
        private void BtnCheck_Click(object sender, EventArgs e)
        {
            textBox3.Text = String.Empty;

            foreach (var book in Books)
            {
                textBox3.Text = textBox3.Text + "Name of the book:" + book.Name + Environment.NewLine + "Year of the book:" + book.Year + Environment.NewLine + "Book Genre:" + book.Genre + Environment.NewLine + Environment.NewLine;
            }
        }
    }
}
    


