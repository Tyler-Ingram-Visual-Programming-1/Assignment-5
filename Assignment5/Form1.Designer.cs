namespace Assignment5
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
            this.oilAndLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeJobGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeJobCheckBox = new System.Windows.Forms.CheckBox();
            this.fullSyntheticRadioButton = new System.Windows.Forms.RadioButton();
            this.mixedRadioButton = new System.Windows.Forms.RadioButton();
            this.oilTypeLabel = new System.Windows.Forms.Label();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.carwashGroupBox = new System.Windows.Forms.GroupBox();
            this.premiumRadioButton = new System.Windows.Forms.RadioButton();
            this.fullServiceRadioButton = new System.Windows.Forms.RadioButton();
            this.complimentaryRadioButton = new System.Windows.Forms.RadioButton();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.partsAndLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborHoursUserInputTextBox = new System.Windows.Forms.TextBox();
            this.partsUserInputTextBox = new System.Windows.Forms.TextBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceMufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.partsOutputLabel = new System.Windows.Forms.Label();
            this.serviceAndLaborOutputLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.oilAndLubeGroupBox.SuspendLayout();
            this.lubeJobGroupBox.SuspendLayout();
            this.carwashGroupBox.SuspendLayout();
            this.partsAndLaborGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLubeGroupBox
            // 
            this.oilAndLubeGroupBox.Controls.Add(this.lubeJobGroupBox);
            this.oilAndLubeGroupBox.Controls.Add(this.fullSyntheticRadioButton);
            this.oilAndLubeGroupBox.Controls.Add(this.mixedRadioButton);
            this.oilAndLubeGroupBox.Controls.Add(this.oilTypeLabel);
            this.oilAndLubeGroupBox.Controls.Add(this.regularRadioButton);
            this.oilAndLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilAndLubeGroupBox.Location = new System.Drawing.Point(12, 23);
            this.oilAndLubeGroupBox.Name = "oilAndLubeGroupBox";
            this.oilAndLubeGroupBox.Size = new System.Drawing.Size(221, 180);
            this.oilAndLubeGroupBox.TabIndex = 0;
            this.oilAndLubeGroupBox.TabStop = false;
            this.oilAndLubeGroupBox.Text = "Oil and Lube";
            // 
            // lubeJobGroupBox
            // 
            this.lubeJobGroupBox.Controls.Add(this.lubeJobCheckBox);
            this.lubeJobGroupBox.Location = new System.Drawing.Point(11, 133);
            this.lubeJobGroupBox.Name = "lubeJobGroupBox";
            this.lubeJobGroupBox.Size = new System.Drawing.Size(200, 38);
            this.lubeJobGroupBox.TabIndex = 11;
            this.lubeJobGroupBox.TabStop = false;
            // 
            // lubeJobCheckBox
            // 
            this.lubeJobCheckBox.AutoSize = true;
            this.lubeJobCheckBox.Location = new System.Drawing.Point(8, 15);
            this.lubeJobCheckBox.Name = "lubeJobCheckBox";
            this.lubeJobCheckBox.Size = new System.Drawing.Size(112, 17);
            this.lubeJobCheckBox.TabIndex = 0;
            this.lubeJobCheckBox.Text = "Lube Job ($18.00)";
            this.lubeJobCheckBox.UseVisualStyleBackColor = true;
            // 
            // fullSyntheticRadioButton
            // 
            this.fullSyntheticRadioButton.AutoSize = true;
            this.fullSyntheticRadioButton.Location = new System.Drawing.Point(46, 110);
            this.fullSyntheticRadioButton.Name = "fullSyntheticRadioButton";
            this.fullSyntheticRadioButton.Size = new System.Drawing.Size(130, 17);
            this.fullSyntheticRadioButton.TabIndex = 10;
            this.fullSyntheticRadioButton.Text = "Full Synthetic ($20.00)";
            this.fullSyntheticRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fullSyntheticRadioButton.UseVisualStyleBackColor = true;
            // 
            // mixedRadioButton
            // 
            this.mixedRadioButton.AutoSize = true;
            this.mixedRadioButton.Location = new System.Drawing.Point(46, 87);
            this.mixedRadioButton.Name = "mixedRadioButton";
            this.mixedRadioButton.Size = new System.Drawing.Size(95, 17);
            this.mixedRadioButton.TabIndex = 9;
            this.mixedRadioButton.Text = "Mixed ($10.00)";
            this.mixedRadioButton.UseVisualStyleBackColor = true;
            // 
            // oilTypeLabel
            // 
            this.oilTypeLabel.AutoSize = true;
            this.oilTypeLabel.Location = new System.Drawing.Point(43, 48);
            this.oilTypeLabel.Name = "oilTypeLabel";
            this.oilTypeLabel.Size = new System.Drawing.Size(46, 13);
            this.oilTypeLabel.TabIndex = 8;
            this.oilTypeLabel.Text = "Oil Type";
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Location = new System.Drawing.Point(46, 64);
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size(98, 17);
            this.regularRadioButton.TabIndex = 7;
            this.regularRadioButton.Text = "Regular ($0.00)";
            this.regularRadioButton.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(11, 19);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(120, 17);
            this.oilChangeCheckBox.TabIndex = 6;
            this.oilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // carwashGroupBox
            // 
            this.carwashGroupBox.Controls.Add(this.premiumRadioButton);
            this.carwashGroupBox.Controls.Add(this.fullServiceRadioButton);
            this.carwashGroupBox.Controls.Add(this.complimentaryRadioButton);
            this.carwashGroupBox.Controls.Add(this.noneRadioButton);
            this.carwashGroupBox.Location = new System.Drawing.Point(239, 23);
            this.carwashGroupBox.Name = "carwashGroupBox";
            this.carwashGroupBox.Size = new System.Drawing.Size(163, 113);
            this.carwashGroupBox.TabIndex = 1;
            this.carwashGroupBox.TabStop = false;
            this.carwashGroupBox.Text = "Carwash";
            // 
            // premiumRadioButton
            // 
            this.premiumRadioButton.AutoSize = true;
            this.premiumRadioButton.Location = new System.Drawing.Point(6, 87);
            this.premiumRadioButton.Name = "premiumRadioButton";
            this.premiumRadioButton.Size = new System.Drawing.Size(98, 17);
            this.premiumRadioButton.TabIndex = 3;
            this.premiumRadioButton.TabStop = true;
            this.premiumRadioButton.Text = "Premium($9.00)";
            this.premiumRadioButton.UseVisualStyleBackColor = true;
            // 
            // fullServiceRadioButton
            // 
            this.fullServiceRadioButton.AutoSize = true;
            this.fullServiceRadioButton.Location = new System.Drawing.Point(6, 64);
            this.fullServiceRadioButton.Name = "fullServiceRadioButton";
            this.fullServiceRadioButton.Size = new System.Drawing.Size(116, 17);
            this.fullServiceRadioButton.TabIndex = 2;
            this.fullServiceRadioButton.TabStop = true;
            this.fullServiceRadioButton.Text = "Full Service ($6.00)";
            this.fullServiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // complimentaryRadioButton
            // 
            this.complimentaryRadioButton.AutoSize = true;
            this.complimentaryRadioButton.Location = new System.Drawing.Point(6, 42);
            this.complimentaryRadioButton.Name = "complimentaryRadioButton";
            this.complimentaryRadioButton.Size = new System.Drawing.Size(129, 17);
            this.complimentaryRadioButton.TabIndex = 1;
            this.complimentaryRadioButton.TabStop = true;
            this.complimentaryRadioButton.Text = "Complimentary ($0.00)";
            this.complimentaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(6, 19);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // partsAndLaborGroupBox
            // 
            this.partsAndLaborGroupBox.Controls.Add(this.laborHoursUserInputTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.partsUserInputTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.laborLabel);
            this.partsAndLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsAndLaborGroupBox.Location = new System.Drawing.Point(239, 205);
            this.partsAndLaborGroupBox.Name = "partsAndLaborGroupBox";
            this.partsAndLaborGroupBox.Size = new System.Drawing.Size(163, 85);
            this.partsAndLaborGroupBox.TabIndex = 1;
            this.partsAndLaborGroupBox.TabStop = false;
            this.partsAndLaborGroupBox.Text = "Parts and Labor";
            // 
            // laborHoursUserInputTextBox
            // 
            this.laborHoursUserInputTextBox.Location = new System.Drawing.Point(68, 52);
            this.laborHoursUserInputTextBox.Name = "laborHoursUserInputTextBox";
            this.laborHoursUserInputTextBox.Size = new System.Drawing.Size(67, 20);
            this.laborHoursUserInputTextBox.TabIndex = 9;
            // 
            // partsUserInputTextBox
            // 
            this.partsUserInputTextBox.Location = new System.Drawing.Point(68, 24);
            this.partsUserInputTextBox.Name = "partsUserInputTextBox";
            this.partsUserInputTextBox.Size = new System.Drawing.Size(67, 20);
            this.partsUserInputTextBox.TabIndex = 8;
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(9, 55);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(59, 13);
            this.laborLabel.TabIndex = 1;
            this.laborLabel.Text = "Labor (Hrs)";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(22, 27);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 13);
            this.partsLabel.TabIndex = 0;
            this.partsLabel.Text = "Parts $$";
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.replaceMufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(12, 205);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(221, 85);
            this.miscGroupBox.TabIndex = 1;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(19, 65);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(129, 17);
            this.tireRotationCheckBox.TabIndex = 8;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20.00)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceMufflerCheckBox
            // 
            this.replaceMufflerCheckBox.AutoSize = true;
            this.replaceMufflerCheckBox.Location = new System.Drawing.Point(19, 42);
            this.replaceMufflerCheckBox.Name = "replaceMufflerCheckBox";
            this.replaceMufflerCheckBox.Size = new System.Drawing.Size(149, 17);
            this.replaceMufflerCheckBox.TabIndex = 7;
            this.replaceMufflerCheckBox.Text = "Replace Muffler ($100.00)";
            this.replaceMufflerCheckBox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(19, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(117, 17);
            this.inspectionCheckBox.TabIndex = 6;
            this.inspectionCheckBox.Text = "Inspection ($15.00)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalChargesOutputLabel);
            this.summaryGroupBox.Controls.Add(this.taxOutputLabel);
            this.summaryGroupBox.Controls.Add(this.partsOutputLabel);
            this.summaryGroupBox.Controls.Add(this.serviceAndLaborOutputLabel);
            this.summaryGroupBox.Controls.Add(this.label4);
            this.summaryGroupBox.Controls.Add(this.label3);
            this.summaryGroupBox.Controls.Add(this.label2);
            this.summaryGroupBox.Controls.Add(this.label1);
            this.summaryGroupBox.Location = new System.Drawing.Point(12, 296);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(390, 144);
            this.summaryGroupBox.TabIndex = 2;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalChargesOutputLabel
            // 
            this.totalChargesOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalChargesOutputLabel.Location = new System.Drawing.Point(162, 113);
            this.totalChargesOutputLabel.Name = "totalChargesOutputLabel";
            this.totalChargesOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalChargesOutputLabel.TabIndex = 7;
            this.totalChargesOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutputLabel.Location = new System.Drawing.Point(162, 82);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.taxOutputLabel.TabIndex = 6;
            this.taxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partsOutputLabel
            // 
            this.partsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsOutputLabel.Location = new System.Drawing.Point(162, 54);
            this.partsOutputLabel.Name = "partsOutputLabel";
            this.partsOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.partsOutputLabel.TabIndex = 5;
            this.partsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceAndLaborOutputLabel
            // 
            this.serviceAndLaborOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceAndLaborOutputLabel.Location = new System.Drawing.Point(162, 25);
            this.serviceAndLaborOutputLabel.Name = "serviceAndLaborOutputLabel";
            this.serviceAndLaborOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.serviceAndLaborOutputLabel.TabIndex = 4;
            this.serviceAndLaborOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Charges";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tax (on parts)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service and Labor";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 446);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 40);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(139, 446);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(134, 40);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(279, 446);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(239, 137);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(163, 66);
            this.flushesGroupBox.TabIndex = 2;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(6, 40);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(157, 17);
            this.transmissionFlushCheckBox.TabIndex = 5;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(6, 19);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(136, 17);
            this.radiatorFlushCheckBox.TabIndex = 4;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 498);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.partsAndLaborGroupBox);
            this.Controls.Add(this.carwashGroupBox);
            this.Controls.Add(this.oilAndLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Joe\'s Automotive";
            this.oilAndLubeGroupBox.ResumeLayout(false);
            this.oilAndLubeGroupBox.PerformLayout();
            this.lubeJobGroupBox.ResumeLayout(false);
            this.lubeJobGroupBox.PerformLayout();
            this.carwashGroupBox.ResumeLayout(false);
            this.carwashGroupBox.PerformLayout();
            this.partsAndLaborGroupBox.ResumeLayout(false);
            this.partsAndLaborGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLubeGroupBox;
        private System.Windows.Forms.GroupBox carwashGroupBox;
        private System.Windows.Forms.GroupBox partsAndLaborGroupBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox lubeJobGroupBox;
        private System.Windows.Forms.CheckBox lubeJobCheckBox;
        private System.Windows.Forms.RadioButton fullSyntheticRadioButton;
        private System.Windows.Forms.RadioButton mixedRadioButton;
        private System.Windows.Forms.Label oilTypeLabel;
        private System.Windows.Forms.RadioButton regularRadioButton;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.RadioButton premiumRadioButton;
        private System.Windows.Forms.RadioButton fullServiceRadioButton;
        private System.Windows.Forms.RadioButton complimentaryRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label serviceAndLaborOutputLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.Label totalChargesOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label partsOutputLabel;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox replaceMufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox laborHoursUserInputTextBox;
        private System.Windows.Forms.TextBox partsUserInputTextBox;
    }
}