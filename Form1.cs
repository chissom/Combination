using System;
using System.Windows.Forms;

namespace Group_7_Project
    {
        public partial class Form1 : Form
        {
            private int n; // Variable to store 'n' from the combination formula C(n,r)
            private int r; // Variable to store 'r' from the combination formula C(n,r)
            private long combinationResult; // Variable to store the result of the combination calculation

            public Form1()
            {
                InitializeComponent();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                // Any initialization if needed
            }

            private void TextBox1(object sender, EventArgs e)
            {
                // Handle text changed event if needed
            }

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
                        if (n >= r && r >= 0)
                        {
                            try
                            {
                                // Valid input, n and r are parsed successfully
                                combinationResult = CalculateCombination(n, r); // Calculate combination result
                                Result(sender, e); // Call the Result method to display the result
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error in calculation: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter n >= r >= 0");
                        }
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

            private long CalculateCombination(int n, int r)
            {
                if (r > n) return 0;
                if (r == 0 || r == n) return 1;

                if (r > n - r) r = n - r; // Because C(n, r) == C(n, n-r)

                long result = 1;
                for (int i = 1; i <= r; i++)
                {
                    result = result * (n - r + i) / i;
                }
                return result;
            }

            private void Result(object sender, EventArgs e)
            {
                label3.Text = $"C({n},{r}) = {combinationResult}";
            }
        }
    }
