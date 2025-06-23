/*
 * Zachary Scharton
 * CST-150
 * Milestone 2
 * 6/22/2025
 * Citation: Inventory Display Logic by Zachary Scharton – CST Inventory Milestone 2
 */

using System;
using System.Windows.Forms;

namespace InventoryMilestone_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire up the event for Display Inventory button
            button1.Click += button1_Click;

            // Disable unused buttons (Add, Edit, Delete)
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        // Event handler for displaying inventory
        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the list before repopulating
            listBox1.Items.Clear();

            // Hard-coded inventory items using primitive data types
            string item1 = "Laptop, Qty: 5, Cost: $799.99, Category: Electronics, Date: 06/10/2025";
            string item2 = "Office Chair, Qty: 8, Cost: $149.99, Category: Furniture, Date: 06/15/2025";

            // Add items to the ListBox
            listBox1.Items.Add(item1);
            listBox1.Items.Add(item2);
        }
    }
}
