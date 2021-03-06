﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCode
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int Count = 1;
            string Row_Open = "[\r\n\t// Column", Row_Close = "],";
            string Col = "\t{ url: 'img/FriendsPlus/";//\t{ url: 'img/FriendsPlus/Page108/E10/1.jpg' },

            string Page_E = tbxUrl.Text;
            List<int> arrCol = tbxCol.Text.Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Col += Page_E + "/";

            string Text = "";
            int count_row = 1;
            foreach (var item in arrCol)
            {
                Text += Row_Open + count_row + "\r\n";
                for (int i = 0; i < item; i++)
                {
                    //Text += Col + Count + ".jpg'},\r\n";
                    if (cbxInput.Checked && i%2!=0)
                    {
                        Text += Col + Count + ".jpg', input: true, answer: \"\"},\r\n";
                    }
                    else
                    {
                        Text += Col + Count + ".jpg'},\r\n";
                    }
                    Count++;
                }
                Text += Row_Close + "\r\n";
                count_row++;
            }

            tbxText.Text = Text;

        }
    }
}
