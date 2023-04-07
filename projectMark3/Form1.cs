namespace projectMark3
{
    public partial class Form1 : Form
    {
        private List<(string, int, int)> itemList = new List<(string, int, int)>();

        public Form1()
        {
            InitializeComponent();
        }
        private void CalculatePrice(string itemName, int quantity, int pricePerUnit, TextBox textBox)
        {
            // Calculate the total price of the item
            int totalPrice = quantity * pricePerUnit;

            // Update the text of the text box with the total price
            textBox.Text = totalPrice.ToString();

            // Check if the item is already in the list
            bool itemExists = false;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[i].Item1 == itemName)
                {
                    // If the item already exists, update its quantity and total price
                    itemList[i] = (itemName, itemList[i].Item2 + quantity, itemList[i].Item3 + totalPrice);
                    itemExists = true;
                    break;
                }
            }

            // If the item does not exist, add it to the list
            if (!itemExists)
            {
                itemList.Add((itemName, quantity, totalPrice));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numericUpDown1.Value);
            int num2 = 5; // Or any other number you want to multiply by
            int result = num1 * num2;
            textBox2.Text = result.ToString();
            CalculatePrice(label5.Text, num1, result, textBox2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Disable the text box so the user cannot type anything in it
            textBox2.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Tomatos
            // Get the text of the clicked label and set it as the text of label6
            //label10.Text = ((Label)sender).Text;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            // Get the text of label5 and set it as the text of label10
            //label10.Text = label5.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get the text of textBox1 and set it as the text of label10
            label10.Text = textBox1.Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Lemons
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numericUpDown2.Value);
            int num2 = 5; // Or any other number you want to multiply by
            int result = num1 * num2;
            textBox3.Text = result.ToString();
            CalculatePrice(label6.Text, (int)numericUpDown1.Value, num1, textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numericUpDown3.Value);
            int num2 = 5; // Or any other number you want to multiply by
            int result = num1 * num2;
            textBox4.Text = result.ToString();
            CalculatePrice(label7.Text, (int)numericUpDown1.Value, num1, textBox2);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = false;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numericUpDown4.Value);
            int num2 = 5; // Or any other number you want to multiply by
            int result = num1 * num2;
            textBox5.Text = result.ToString();
            CalculatePrice(label8.Text, (int)numericUpDown1.Value, num1, textBox2);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Oranges
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //Bananas
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the label that displays the list of items
            label12.Text = "";
            label11.Text = "";
            // Loop through the list and display the items
            int total = 0;
            for (int i = 0; i < itemList.Count; i++)
            {
                string item = $"{itemList[i].Item1} {itemList[i].Item2} kg price {itemList[i].Item3}";
                label11.Text += item + "\n";
                total += itemList[i].Item3;
            }

            // Display the total price
            label12.Text = $"Total: {total}";

            // Print out the list of items and their corresponding prices
            string output = "";
            foreach (var item in itemList)
            {
                output += $"{item.Item1} {item.Item2} kg price {item.Item3}\n";
            }
            //MessageBox.Show(output, "Items List");
        }

        
    }
}