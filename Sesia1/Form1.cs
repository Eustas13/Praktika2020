﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesia1
{
    public partial class Form1 : Form
    {
        public static Form1 FORMA { get; set; }
        public static Пользователи USER { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль");
                return;
            }
            Пользователи usr = db.Пользователи.Find(textBox1.Text);
            if ((usr != null) && (usr.Пароль == textBox2.Text))
            {
                USER = usr;
                FORMA = this;
                if ((usr.Роль == "Дирекция") || (usr.Роль == "дирекция"))
                {
                    Дирекция frm = new Дирекция();
                    frm.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    this.Hide();
                }
                else if ((usr.Роль == "Заказчик") || (usr.Роль == "заказчик"))
                {
                    Заказчик frm = new Заказчик();
                    frm.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    this.Hide();
                }
                else if ((usr.Роль == "Менеджер") || (usr.Роль == "менеджер"))
                {
                    Менеджер frm = new Менеджер();
                    frm.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    this.Hide();
                }
                else if ((usr.Роль == "Кладовщик") || (usr.Роль == "кладовщик"))
                {
                    Кладовщик frm = new Кладовщик();
                    frm.Show();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет");
                textBox2.Text = "";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация f = new Регистрация();
            textBox1.Text = "";
            textBox2.Text = "";
            FORMA = this;
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
