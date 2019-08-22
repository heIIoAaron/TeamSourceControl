﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootBoxProject
{
    public partial class LootBox : Form
    {
        public LootBox()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddBox_Click(object sender, EventArgs e)
        {
            FrmAddLootbox addLootboxForm = new FrmAddLootbox();
            addLootboxForm.ShowDialog();
        }

        private void BtnEditBox_Click(object sender, EventArgs e)
        {

        }

        private void BtnDeleteBox_Click(object sender, EventArgs e)
        {
            List<LootboxClass> boxs = LootboxDB.GetAllLootboxes();
            LootboxClass box = lstLootBox.SelectedItem as LootboxClass;
            boxs.Remove(box);
        }

        private void LstLootBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateLootboxListbox()
        {
            List<LootboxClass> lootboxes = LootboxDB.GetAllLootboxes();
            lootboxes = lootboxes.OrderBy(lb => lb.Name).ToList();

            foreach(LootboxClass ltbx in lootboxes)
            {
                lstLootBox.Items.Add(ltbx).ToString();
            }
        }
    }
}
