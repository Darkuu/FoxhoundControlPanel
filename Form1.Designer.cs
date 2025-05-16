namespace Foxhound_Control_Panel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BP_GenerateChallange = new System.Windows.Forms.Button();
            this.txtBPChallanges = new System.Windows.Forms.TextBox();
            this.label_BP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_InputCig = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cigs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_InputCrayon = new System.Windows.Forms.TextBox();
            this.btn_BountyGenerateLog = new System.Windows.Forms.Button();
            this.txtUnitInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLvetResult = new System.Windows.Forms.TextBox();
            this.txtHecuResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.check_Gravy = new System.Windows.Forms.CheckBox();
            this.check_Greedy = new System.Windows.Forms.CheckBox();
            this.txt_CalculatorInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CalculatorOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BP_GenerateChallange
            // 
            this.BP_GenerateChallange.Location = new System.Drawing.Point(27, 39);
            this.BP_GenerateChallange.Name = "BP_GenerateChallange";
            this.BP_GenerateChallange.Size = new System.Drawing.Size(139, 23);
            this.BP_GenerateChallange.TabIndex = 0;
            this.BP_GenerateChallange.Text = "Generate Challanges";
            this.BP_GenerateChallange.UseVisualStyleBackColor = true;
            this.BP_GenerateChallange.Click += new System.EventHandler(this.BP_GenerateChallange_Click);
            // 
            // txtBPChallanges
            // 
            this.txtBPChallanges.BackColor = System.Drawing.SystemColors.Control;
            this.txtBPChallanges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBPChallanges.Location = new System.Drawing.Point(12, 68);
            this.txtBPChallanges.Multiline = true;
            this.txtBPChallanges.Name = "txtBPChallanges";
            this.txtBPChallanges.ReadOnly = true;
            this.txtBPChallanges.Size = new System.Drawing.Size(178, 82);
            this.txtBPChallanges.TabIndex = 5;
            this.txtBPChallanges.TextChanged += new System.EventHandler(this.txtBPChallanges_TextChanged);
            // 
            // label_BP
            // 
            this.label_BP.AutoSize = true;
            this.label_BP.Font = new System.Drawing.Font("Times New Roman", 10.25F);
            this.label_BP.Location = new System.Drawing.Point(63, 9);
            this.label_BP.Name = "label_BP";
            this.label_BP.Size = new System.Drawing.Size(67, 16);
            this.label_BP.TabIndex = 6;
            this.label_BP.Text = "Battlepass ";
            this.label_BP.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.25F);
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bounty Logging";
            // 
            // txt_InputCig
            // 
            this.txt_InputCig.BackColor = System.Drawing.SystemColors.Control;
            this.txt_InputCig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InputCig.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_InputCig.Location = new System.Drawing.Point(393, 66);
            this.txt_InputCig.Multiline = true;
            this.txt_InputCig.Name = "txt_InputCig";
            this.txt_InputCig.Size = new System.Drawing.Size(37, 18);
            this.txt_InputCig.TabIndex = 8;
            this.txt_InputCig.Text = "###";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label2.Location = new System.Drawing.Point(390, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bounty Rewards";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Cigs
            // 
            this.txt_Cigs.AutoSize = true;
            this.txt_Cigs.Location = new System.Drawing.Point(361, 68);
            this.txt_Cigs.Name = "txt_Cigs";
            this.txt_Cigs.Size = new System.Drawing.Size(26, 14);
            this.txt_Cigs.TabIndex = 11;
            this.txt_Cigs.Text = "Cigs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Crayons";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_InputCrayon
            // 
            this.txt_InputCrayon.BackColor = System.Drawing.SystemColors.Control;
            this.txt_InputCrayon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InputCrayon.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_InputCrayon.Location = new System.Drawing.Point(486, 68);
            this.txt_InputCrayon.Multiline = true;
            this.txt_InputCrayon.Name = "txt_InputCrayon";
            this.txt_InputCrayon.Size = new System.Drawing.Size(37, 18);
            this.txt_InputCrayon.TabIndex = 12;
            this.txt_InputCrayon.Text = "###";
            this.txt_InputCrayon.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_BountyGenerateLog
            // 
            this.btn_BountyGenerateLog.Location = new System.Drawing.Point(364, 202);
            this.btn_BountyGenerateLog.Name = "btn_BountyGenerateLog";
            this.btn_BountyGenerateLog.Size = new System.Drawing.Size(139, 23);
            this.btn_BountyGenerateLog.TabIndex = 14;
            this.btn_BountyGenerateLog.Text = "Generate Log";
            this.btn_BountyGenerateLog.UseVisualStyleBackColor = true;
            this.btn_BountyGenerateLog.Click += new System.EventHandler(this.btn_BountyGenerateLog_Click);
            // 
            // txtUnitInput
            // 
            this.txtUnitInput.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnitInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUnitInput.Location = new System.Drawing.Point(347, 114);
            this.txtUnitInput.Multiline = true;
            this.txtUnitInput.Name = "txtUnitInput";
            this.txtUnitInput.Size = new System.Drawing.Size(176, 82);
            this.txtUnitInput.TabIndex = 16;
            this.txtUnitInput.Text = "Units";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label5.Location = new System.Drawing.Point(418, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Units";
            // 
            // txtLvetResult
            // 
            this.txtLvetResult.BackColor = System.Drawing.SystemColors.Control;
            this.txtLvetResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLvetResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtLvetResult.Location = new System.Drawing.Point(272, 231);
            this.txtLvetResult.Multiline = true;
            this.txtLvetResult.Name = "txtLvetResult";
            this.txtLvetResult.Size = new System.Drawing.Size(161, 177);
            this.txtLvetResult.TabIndex = 18;
            this.txtLvetResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHecuResult
            // 
            this.txtHecuResult.BackColor = System.Drawing.SystemColors.Control;
            this.txtHecuResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHecuResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtHecuResult.Location = new System.Drawing.Point(439, 231);
            this.txtHecuResult.Multiline = true;
            this.txtHecuResult.Name = "txtHecuResult";
            this.txtHecuResult.Size = new System.Drawing.Size(161, 177);
            this.txtHecuResult.TabIndex = 19;
            this.txtHecuResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.25F);
            this.label6.Location = new System.Drawing.Point(269, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Remeber to Multiply the rewards if needed!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Amount";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // check_Gravy
            // 
            this.check_Gravy.AutoSize = true;
            this.check_Gravy.Location = new System.Drawing.Point(272, 438);
            this.check_Gravy.Name = "check_Gravy";
            this.check_Gravy.Size = new System.Drawing.Size(123, 18);
            this.check_Gravy.TabIndex = 22;
            this.check_Gravy.Text = "Gravyboats Menorah";
            this.check_Gravy.UseVisualStyleBackColor = true;
            this.check_Gravy.CheckedChanged += new System.EventHandler(this.check_Gravy_CheckedChanged);
            // 
            // check_Greedy
            // 
            this.check_Greedy.AutoSize = true;
            this.check_Greedy.Location = new System.Drawing.Point(272, 462);
            this.check_Greedy.Name = "check_Greedy";
            this.check_Greedy.Size = new System.Drawing.Size(158, 18);
            this.check_Greedy.TabIndex = 23;
            this.check_Greedy.Text = "Charm of the Greedy Looter";
            this.check_Greedy.UseVisualStyleBackColor = true;
            this.check_Greedy.CheckedChanged += new System.EventHandler(this.Check_Greedy_CheckedChanged);
            // 
            // txt_CalculatorInput
            // 
            this.txt_CalculatorInput.BackColor = System.Drawing.SystemColors.Control;
            this.txt_CalculatorInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CalculatorInput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_CalculatorInput.Location = new System.Drawing.Point(269, 500);
            this.txt_CalculatorInput.Multiline = true;
            this.txt_CalculatorInput.Name = "txt_CalculatorInput";
            this.txt_CalculatorInput.Size = new System.Drawing.Size(64, 31);
            this.txt_CalculatorInput.TabIndex = 24;
            this.txt_CalculatorInput.TextChanged += new System.EventHandler(this.txt_CalculatorInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Result";
            // 
            // txt_CalculatorOutput
            // 
            this.txt_CalculatorOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txt_CalculatorOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CalculatorOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_CalculatorOutput.Location = new System.Drawing.Point(347, 500);
            this.txt_CalculatorOutput.Multiline = true;
            this.txt_CalculatorOutput.Name = "txt_CalculatorOutput";
            this.txt_CalculatorOutput.Size = new System.Drawing.Size(64, 31);
            this.txt_CalculatorOutput.TabIndex = 26;
            this.txt_CalculatorOutput.Text = "####";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(221, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 646);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(615, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 646);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_CalculatorOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_CalculatorInput);
            this.Controls.Add(this.check_Greedy);
            this.Controls.Add(this.check_Gravy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHecuResult);
            this.Controls.Add(this.txtLvetResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnitInput);
            this.Controls.Add(this.btn_BountyGenerateLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_InputCrayon);
            this.Controls.Add(this.txt_Cigs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_InputCig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_BP);
            this.Controls.Add(this.txtBPChallanges);
            this.Controls.Add(this.BP_GenerateChallange);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Foxhound Control Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BP_GenerateChallange;
        private System.Windows.Forms.TextBox txtBPChallanges;
        private System.Windows.Forms.Label label_BP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_InputCig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_Cigs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_InputCrayon;
        private System.Windows.Forms.Button btn_BountyGenerateLog;
        private System.Windows.Forms.TextBox txtUnitInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLvetResult;
        private System.Windows.Forms.TextBox txtHecuResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox check_Gravy;
        private System.Windows.Forms.CheckBox check_Greedy;
        private System.Windows.Forms.TextBox txt_CalculatorInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CalculatorOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

