﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Attributes;

namespace IvanAgencyViewAdmin
{
    public partial class FormLoginAdmin : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public FormLoginAdmin()
        {
            InitializeComponent();
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (textBoxLogin.Text == "admin")
                {
                    if (textBoxPassword.Text == "123")
                    {
                        
                        var form = Container.Resolve<FormMain>();
                        form.ShowDialog();
                       
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
