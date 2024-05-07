using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab5
{
    public partial class Form1 : Form
    {
        WolfCollection wolfCollection;
        private Wolf wolf;
        private Wolf wolf1;
        private Wolf wolf3;
        private Wolf wolf4;
        public Form1()
        {
            InitializeComponent();
            wolfCollection = new WolfCollection();
            wolf = new Wolf(40, 2, 43, "Grey Wolf", "Forest");
            wolf1 = new Wolf(20, 2, 36, "Grey Wolf", "Forest");
            wolf3 = new Wolf(14, 4, 12, "Grey Wolf", "Forest");
            wolf4 = new Wolf(21, 6, 21, "Grey Wolf", "Forest");
            wolfCollection.AddToHashtable(0,wolf);
            wolfCollection.AddToHashtable(1, wolf1);
            wolfCollection.AddToList(wolf3);
            wolfCollection.AddToList(wolf4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Wolf Information:\n\n" +
                          $"Weight: {wolf.Weight} kg\n" +
                          $"Age: {wolf.Age} years\n" +
                          $"Daily Maintenance Cost: {wolf.DailyMaintenanceCost}$\n" +
                          $"Breed: {wolf.Breed}\n" +
                          $"Natural Habitat: {wolf.NaturalHabitat}",
                          "Wolf Info",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string wolfInfo = wolfCollection.DisplayHashtable();
            MessageBox.Show(wolfInfo, "Wolf Collection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string wolfInfo = wolfCollection.DisplayList();
            MessageBox.Show(wolfInfo, "Wolf Collection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
