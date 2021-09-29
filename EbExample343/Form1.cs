using EbExample343.Classes;
using EbExample343.Classes.Entityes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbExample343
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            foreach (User user in User.Select()) {
                //Выводим колонку UserName
                Console.WriteLine(user.UserName);
            }
        }
    }
}
