using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class frmMovie : Form
    {
        public frmMovie()
        {
            InitializeComponent();
        }
        MovieContext context = new MovieContext();

        void categoryList()
        {
            var value = context.Categories.ToList();
            cmbCategory.DataSource = value;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var value = context.Movies.ToList();
            dataGridView1.DataSource = value;
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            
            categoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle = txtName.Text;
            movie.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            movie.CreatedDate = mskDate.Text == "" ? DateTime.Now : Convert.ToDateTime(mskDate.Text);
            movie.Description = txtDetails.Text;
            movie.Duration = Convert.ToInt32(txtDuration.Text);
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("Film Ekleme İşlemi Tamamlandı.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = context.Movies.Find(Convert.ToInt32(txtId.Text));
            context.Movies.Remove(value);
            context.SaveChanges();
            MessageBox.Show("Film Silme İşlemi Tamamlandı.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var value = context.Movies.Where(x => x.MovieTitle.Contains(txtName.Text)).ToList();
            dataGridView1.DataSource = value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var values = context.Movies.Find(Convert.ToInt32(txtId.Text));
            values.MovieTitle = txtName.Text;
            values.CategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            values.CreatedDate = mskDate.Text == "" ? DateTime.Now : Convert.ToDateTime(mskDate.Text);
            values.Description = txtDetails.Text;
            values.Duration = Convert.ToInt32(txtDuration.Text);
            context.SaveChanges();
            MessageBox.Show("Film Güncelleme İşlemi Tamamlandı.");

        }

        private void btnCategoryWithMovieList_Click(object sender, EventArgs e)
        {
            var values = context.Movies
                .Join(context.Categories,
                 m => m.CategoryId,
                    c => c.CategoryId,
                    (m, c) => new
                    {
                        MovieId = m.MovieId,
                        MovieTitle = m.MovieTitle,
                        CategoryName = c.CategoryName,
                        Description = m.Description,
                        Duration = m.Duration
                    }).ToList();
            dataGridView1.DataSource = values;
        }        
                
    }
}
