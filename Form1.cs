using System.Security.AccessControl;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Group7_Project_Combination_
{
    // Partial class Form1 inherits from Form class
    public partial class Form1 : Form
    {
        private int n; // Variable to store 'n' from the combination formula C(n,r)
        private int r; // Variable to store 'r' from the combination formula C(n,r)
        private int combinationResult; // Variable to store the result of the combination calculation

        // Constructor for Form1, initializes components
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for when Form1 loads
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Event handler for text change in textBoxt1
        private void TextBox1(object sender, EventArgs e)
        {
            
        }

        // Event handler for button1 click event to solve the combination
        private void Solve(object sender, EventArgs e)
        {
            // let's say textBox1 contains the input like "C(8,3)" which is the formula C(n,r) for combination
            string input = textBox1.Text;

            // Extracting n and r from the input
            if (input.StartsWith("C(") && input.EndsWith(")"))
            {
                string innerPart = input.Substring(2, input.Length - 3);
                string[] parts = innerPart.Split(',');

                // Validate and parse n and r from the input
                if (parts.Length == 2 && int.TryParse(parts[0], out n) && int.TryParse(parts[1], out r))
                {
                    // Valid input, n and r are parsed successfully
                    combinationResult = CalculateCombination(n, r); // Calculate combination result
                    Result(sender, e); // Call the Result method to display the result
                }
                else
                {
                    MessageBox.Show("Invalid input format. Please enter in the format 'C(n,r)' e.g., 'C(8,3)'");
                }
            }
            else
            {
                MessageBox.Show("Invalid input format. Please enter in the format 'C(n,r)' e.g., 'C(8,3)'");
            }
        }

        // Method to calculate combination C(n,r)
        private int CalculateCombination(int n, int r)
        {
            return Factorial(n) / (Factorial(r) * Factorial(n - r));
        }


        // Method to calculate factorial of a number
        private int Factorial(int number)
        {
            if (number <= 1)
                return 1;
            return number * Factorial(number - 1);
        }

        // Method to update label3 with the result of the combination calculation
        private void Result(object sender, EventArgs e)
        {
            label3.Text = $"C({n},{r}) = {combinationResult}";
        }
    }
}
