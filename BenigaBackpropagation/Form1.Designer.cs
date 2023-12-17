namespace BenigaBackpropagation
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
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.numUDNeuron = new System.Windows.Forms.NumericUpDown();
            this.lblHN = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbInputOR4 = new System.Windows.Forms.RadioButton();
            this.rbInputOR2 = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbTraining = new System.Windows.Forms.GroupBox();
            this.numUDEpoch = new System.Windows.Forms.NumericUpDown();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvInputOutput = new System.Windows.Forms.DataGridView();
            this.Input3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Output = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.gbLogicSetup = new System.Windows.Forms.GroupBox();
            this.rbInputAND2 = new System.Windows.Forms.RadioButton();
            this.rbInputAND4 = new System.Windows.Forms.RadioButton();
            this.chkKeepInputs = new System.Windows.Forms.CheckBox();
            this.gbSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNeuron)).BeginInit();
            this.gbTraining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEpoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputOutput)).BeginInit();
            this.gbLogicSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.numUDNeuron);
            this.gbSetup.Controls.Add(this.lblHN);
            this.gbSetup.Controls.Add(this.btnReset);
            this.gbSetup.Controls.Add(this.btnCreate);
            this.gbSetup.Location = new System.Drawing.Point(47, 73);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Size = new System.Drawing.Size(280, 100);
            this.gbSetup.TabIndex = 0;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Model Setup";
            // 
            // numUDNeuron
            // 
            this.numUDNeuron.Location = new System.Drawing.Point(173, 30);
            this.numUDNeuron.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDNeuron.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDNeuron.Name = "numUDNeuron";
            this.numUDNeuron.Size = new System.Drawing.Size(75, 20);
            this.numUDNeuron.TabIndex = 8;
            this.numUDNeuron.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUDNeuron.ValueChanged += new System.EventHandler(this.numUDNeuron_ValueChanged);
            // 
            // lblHN
            // 
            this.lblHN.AutoSize = true;
            this.lblHN.Location = new System.Drawing.Point(32, 32);
            this.lblHN.Name = "lblHN";
            this.lblHN.Size = new System.Drawing.Size(135, 13);
            this.lblHN.TabIndex = 7;
            this.lblHN.Text = "Number of hidden neurons:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(140, 61);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(59, 61);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbInputOR4
            // 
            this.rbInputOR4.AutoSize = true;
            this.rbInputOR4.Location = new System.Drawing.Point(173, 23);
            this.rbInputOR4.Name = "rbInputOR4";
            this.rbInputOR4.Size = new System.Drawing.Size(108, 17);
            this.rbInputOR4.TabIndex = 1;
            this.rbInputOR4.Text = "4-input OR GATE";
            this.rbInputOR4.UseVisualStyleBackColor = true;
            this.rbInputOR4.CheckedChanged += new System.EventHandler(this.rbInputOR4_CheckedChanged);
            // 
            // rbInputOR2
            // 
            this.rbInputOR2.AutoSize = true;
            this.rbInputOR2.Location = new System.Drawing.Point(59, 23);
            this.rbInputOR2.Name = "rbInputOR2";
            this.rbInputOR2.Size = new System.Drawing.Size(108, 17);
            this.rbInputOR2.TabIndex = 0;
            this.rbInputOR2.Text = "2-input OR GATE";
            this.rbInputOR2.UseVisualStyleBackColor = true;
            this.rbInputOR2.CheckedChanged += new System.EventHandler(this.rbInputOR2_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbTraining
            // 
            this.gbTraining.Controls.Add(this.numUDEpoch);
            this.gbTraining.Controls.Add(this.btnTrain);
            this.gbTraining.Controls.Add(this.btnLoad);
            this.gbTraining.Controls.Add(this.label1);
            this.gbTraining.Controls.Add(this.btnSave);
            this.gbTraining.Location = new System.Drawing.Point(365, 73);
            this.gbTraining.Name = "gbTraining";
            this.gbTraining.Size = new System.Drawing.Size(280, 100);
            this.gbTraining.TabIndex = 2;
            this.gbTraining.TabStop = false;
            this.gbTraining.Text = "Model Training";
            // 
            // numUDEpoch
            // 
            this.numUDEpoch.Location = new System.Drawing.Point(170, 30);
            this.numUDEpoch.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDEpoch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDEpoch.Name = "numUDEpoch";
            this.numUDEpoch.Size = new System.Drawing.Size(75, 20);
            this.numUDEpoch.TabIndex = 6;
            this.numUDEpoch.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDEpoch.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(182, 61);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(101, 61);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of times to train:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(547, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvInputOutput
            // 
            this.dgvInputOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInputOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Input3,
            this.Input2,
            this.Input1,
            this.I0,
            this.Output});
            this.dgvInputOutput.Location = new System.Drawing.Point(47, 218);
            this.dgvInputOutput.Name = "dgvInputOutput";
            this.dgvInputOutput.Size = new System.Drawing.Size(598, 220);
            this.dgvInputOutput.TabIndex = 34;
            this.dgvInputOutput.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvInputOutput_CellValidating);
            // 
            // Input3
            // 
            this.Input3.HeaderText = "Input 3";
            this.Input3.Name = "Input3";
            // 
            // Input2
            // 
            this.Input2.HeaderText = "Input 2";
            this.Input2.Name = "Input2";
            // 
            // Input1
            // 
            this.Input1.HeaderText = "Input 1";
            this.Input1.Name = "Input1";
            // 
            // I0
            // 
            this.I0.HeaderText = "Input 0";
            this.I0.Name = "I0";
            // 
            // Output
            // 
            this.Output.HeaderText = "Output";
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(443, 455);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(98, 23);
            this.btnTest.TabIndex = 35;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(44, 460);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(284, 13);
            this.lblWarning.TabIndex = 36;
            this.lblWarning.Text = "Create model first before being allowed to do anything else.";
            // 
            // gbLogicSetup
            // 
            this.gbLogicSetup.Controls.Add(this.rbInputAND2);
            this.gbLogicSetup.Controls.Add(this.rbInputAND4);
            this.gbLogicSetup.Controls.Add(this.rbInputOR2);
            this.gbLogicSetup.Controls.Add(this.rbInputOR4);
            this.gbLogicSetup.Location = new System.Drawing.Point(47, 12);
            this.gbLogicSetup.Name = "gbLogicSetup";
            this.gbLogicSetup.Size = new System.Drawing.Size(598, 55);
            this.gbLogicSetup.TabIndex = 37;
            this.gbLogicSetup.TabStop = false;
            this.gbLogicSetup.Text = "Logic Gate Setup";
            // 
            // rbInputAND2
            // 
            this.rbInputAND2.AutoSize = true;
            this.rbInputAND2.Location = new System.Drawing.Point(318, 23);
            this.rbInputAND2.Name = "rbInputAND2";
            this.rbInputAND2.Size = new System.Drawing.Size(115, 17);
            this.rbInputAND2.TabIndex = 2;
            this.rbInputAND2.Text = "2-input AND GATE";
            this.rbInputAND2.UseVisualStyleBackColor = true;
            this.rbInputAND2.CheckedChanged += new System.EventHandler(this.rbInputAND2_CheckedChanged);
            // 
            // rbInputAND4
            // 
            this.rbInputAND4.AutoSize = true;
            this.rbInputAND4.Checked = true;
            this.rbInputAND4.Location = new System.Drawing.Point(439, 23);
            this.rbInputAND4.Name = "rbInputAND4";
            this.rbInputAND4.Size = new System.Drawing.Size(115, 17);
            this.rbInputAND4.TabIndex = 3;
            this.rbInputAND4.TabStop = true;
            this.rbInputAND4.Text = "4-input AND GATE";
            this.rbInputAND4.UseVisualStyleBackColor = true;
            this.rbInputAND4.CheckedChanged += new System.EventHandler(this.rbInputAND4_CheckedChanged);
            // 
            // chkKeepInputs
            // 
            this.chkKeepInputs.AutoSize = true;
            this.chkKeepInputs.Location = new System.Drawing.Point(348, 459);
            this.chkKeepInputs.Name = "chkKeepInputs";
            this.chkKeepInputs.Size = new System.Drawing.Size(89, 17);
            this.chkKeepInputs.TabIndex = 38;
            this.chkKeepInputs.Text = "Keep Inputs?";
            this.chkKeepInputs.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.chkKeepInputs);
            this.Controls.Add(this.gbLogicSetup);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dgvInputOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbTraining);
            this.Controls.Add(this.gbSetup);
            this.Name = "Form1";
            this.Text = "Beniga Backpropagation";
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDNeuron)).EndInit();
            this.gbTraining.ResumeLayout(false);
            this.gbTraining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEpoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputOutput)).EndInit();
            this.gbLogicSetup.ResumeLayout(false);
            this.gbLogicSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.RadioButton rbInputOR4;
        private System.Windows.Forms.RadioButton rbInputOR2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbTraining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvInputOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input1;
        private System.Windows.Forms.DataGridViewTextBoxColumn I0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Output;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.NumericUpDown numUDEpoch;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.GroupBox gbLogicSetup;
        private System.Windows.Forms.RadioButton rbInputAND2;
        private System.Windows.Forms.RadioButton rbInputAND4;
        private System.Windows.Forms.NumericUpDown numUDNeuron;
        private System.Windows.Forms.Label lblHN;
        private System.Windows.Forms.CheckBox chkKeepInputs;
    }
}

