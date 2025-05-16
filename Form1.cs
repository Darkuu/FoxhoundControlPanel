using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Foxhound_Control_Panel
{
    public partial class Form1 : Form
    {
      
        private Random rand = new Random();

        private List<string> challenges = new List<string>();

        public Form1()
        {
            InitializeComponent();
            LoadChallenges();
        }

        private void LoadChallenges()
        {
            // Filepath, you need to place it in the same folder as the .exe file
            string filePath = "BP_Challenges.txt"; 
            if (File.Exists(filePath))
            {
                challenges = new List<string>(File.ReadAllLines(filePath));
            }
            else
            {
                MessageBox.Show("Challanges not found!");
            }
        }


        private void BP_GenerateChallange_Click(object sender, EventArgs e)
        {
            var selected = new List<string>();
            var temp = new List<string>(challenges);

            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(temp.Count);
                selected.Add(temp[index]);
                temp.RemoveAt(index);
            }

            txtBPChallanges.Text =
                $"Challenge 1: {selected[0]}\r\n" +
                $"Challenge 2: {selected[1]}\r\n" +
                $"Challenge 3: {selected[2]}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBPChallanges_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // Bounty Generator

        private void btn_BountyGenerateLog_Click(object sender, EventArgs e)
        {
            // Parse inputs
            bool crayonParsed = int.TryParse(txt_InputCrayon.Text.Trim(), out int crayons);
            bool cigParsed = int.TryParse(txt_InputCig.Text.Trim(), out int cigs);

            if (!crayonParsed || !cigParsed)
            {
                MessageBox.Show("Please enter valid numbers for Crayons and Cigs.");
                return;
            }


            List<string> lvetRows = new List<string>();
            List<string> hecuRows = new List<string>();

            foreach (string line in txtUnitInput.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string trimmed = line.Trim();
                if (trimmed.StartsWith("LVET ", StringComparison.OrdinalIgnoreCase))
                {
                    string name = trimmed.Substring(5);
                    lvetRows.Add($"=add cigs {name} {cigs}");
                }
                else if (trimmed.StartsWith("HECU ", StringComparison.OrdinalIgnoreCase))
                {
                    string name = trimmed.Substring(5);
                    hecuRows.Add($"+add crayons {name} {crayons}");
                }
            }

            txtLvetResult.Text = string.Join("\r\n", lvetRows);
            txtHecuResult.Text = string.Join("\r\n", hecuRows);
        }

        // Calculator

        private void check_Gravy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatedReward();
        }

        private void Check_Greedy_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalculatedReward();
        }
        private void txt_CalculatorInput_TextChanged(object sender, EventArgs e)
        {
            UpdateCalculatedReward();
        }


        private void UpdateCalculatedReward()
        {
            if (int.TryParse(txt_CalculatorInput.Text.Trim(), out int baseAmount))
            {
                int multiplier = 1;
                if (check_Gravy.Checked) multiplier *= 2;
                if (check_Greedy.Checked) multiplier *= 2;

                int result = baseAmount * multiplier;
                txt_CalculatorOutput.Text = result.ToString();
            }
            else
            {
                txt_CalculatorOutput.Text = "";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
