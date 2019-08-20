namespace filter_design_gui
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
            this.components = new System.ComponentModel.Container();
            this.buttonLP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxCoeffs = new System.Windows.Forms.RichTextBox();
            this.labelCoeffs = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageImpulse = new System.Windows.Forms.TabPage();
            this.zgcImpulseResponse = new ZedGraph.ZedGraphControl();
            this.tabPageFrequency = new System.Windows.Forms.TabPage();
            this.zgcFrequencyResponse = new ZedGraph.ZedGraphControl();
            this.comboBoxWindow = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGaussSigma = new System.Windows.Forms.TextBox();
            this.textBoxFilterLength = new System.Windows.Forms.TextBox();
            this.textBoxCutoffFrequency = new System.Windows.Forms.TextBox();
            this.textBoxSampleRate = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCopyCSV = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageImpulse.SuspendLayout();
            this.tabPageFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLP
            // 
            this.buttonLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLP.Location = new System.Drawing.Point(704, 12);
            this.buttonLP.Name = "buttonLP";
            this.buttonLP.Size = new System.Drawing.Size(126, 23);
            this.buttonLP.TabIndex = 0;
            this.buttonLP.Text = "Calc Lowpass";
            this.buttonLP.UseVisualStyleBackColor = true;
            this.buttonLP.Click += new System.EventHandler(this.ButtonLP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sample Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cutoff Frequency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter Length:";
            // 
            // richTextBoxCoeffs
            // 
            this.richTextBoxCoeffs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxCoeffs.Location = new System.Drawing.Point(12, 114);
            this.richTextBoxCoeffs.Name = "richTextBoxCoeffs";
            this.richTextBoxCoeffs.Size = new System.Drawing.Size(149, 529);
            this.richTextBoxCoeffs.TabIndex = 7;
            this.richTextBoxCoeffs.Text = "";
            this.richTextBoxCoeffs.WordWrap = false;
            // 
            // labelCoeffs
            // 
            this.labelCoeffs.AutoSize = true;
            this.labelCoeffs.Location = new System.Drawing.Point(9, 98);
            this.labelCoeffs.Name = "labelCoeffs";
            this.labelCoeffs.Size = new System.Drawing.Size(79, 13);
            this.labelCoeffs.TabIndex = 8;
            this.labelCoeffs.Text = "Coeffs (Kernel):";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageFrequency);
            this.tabControl1.Controls.Add(this.tabPageImpulse);
            this.tabControl1.Location = new System.Drawing.Point(167, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 562);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageImpulse
            // 
            this.tabPageImpulse.Controls.Add(this.zgcImpulseResponse);
            this.tabPageImpulse.Location = new System.Drawing.Point(4, 22);
            this.tabPageImpulse.Name = "tabPageImpulse";
            this.tabPageImpulse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImpulse.Size = new System.Drawing.Size(655, 536);
            this.tabPageImpulse.TabIndex = 0;
            this.tabPageImpulse.Text = "Impulse Response";
            this.tabPageImpulse.UseVisualStyleBackColor = true;
            // 
            // zgcImpulseResponse
            // 
            this.zgcImpulseResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgcImpulseResponse.Location = new System.Drawing.Point(3, 3);
            this.zgcImpulseResponse.Name = "zgcImpulseResponse";
            this.zgcImpulseResponse.ScrollGrace = 0D;
            this.zgcImpulseResponse.ScrollMaxX = 0D;
            this.zgcImpulseResponse.ScrollMaxY = 0D;
            this.zgcImpulseResponse.ScrollMaxY2 = 0D;
            this.zgcImpulseResponse.ScrollMinX = 0D;
            this.zgcImpulseResponse.ScrollMinY = 0D;
            this.zgcImpulseResponse.ScrollMinY2 = 0D;
            this.zgcImpulseResponse.Size = new System.Drawing.Size(649, 530);
            this.zgcImpulseResponse.TabIndex = 0;
            this.zgcImpulseResponse.UseExtendedPrintDialog = true;
            // 
            // tabPageFrequency
            // 
            this.tabPageFrequency.Controls.Add(this.zgcFrequencyResponse);
            this.tabPageFrequency.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrequency.Name = "tabPageFrequency";
            this.tabPageFrequency.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrequency.Size = new System.Drawing.Size(655, 536);
            this.tabPageFrequency.TabIndex = 1;
            this.tabPageFrequency.Text = "Frequency Response";
            this.tabPageFrequency.UseVisualStyleBackColor = true;
            // 
            // zgcFrequencyResponse
            // 
            this.zgcFrequencyResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgcFrequencyResponse.Location = new System.Drawing.Point(3, 3);
            this.zgcFrequencyResponse.Name = "zgcFrequencyResponse";
            this.zgcFrequencyResponse.ScrollGrace = 0D;
            this.zgcFrequencyResponse.ScrollMaxX = 0D;
            this.zgcFrequencyResponse.ScrollMaxY = 0D;
            this.zgcFrequencyResponse.ScrollMaxY2 = 0D;
            this.zgcFrequencyResponse.ScrollMinX = 0D;
            this.zgcFrequencyResponse.ScrollMinY = 0D;
            this.zgcFrequencyResponse.ScrollMinY2 = 0D;
            this.zgcFrequencyResponse.Size = new System.Drawing.Size(649, 530);
            this.zgcFrequencyResponse.TabIndex = 1;
            this.zgcFrequencyResponse.UseExtendedPrintDialog = true;
            // 
            // comboBoxWindow
            // 
            this.comboBoxWindow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWindow.FormattingEnabled = true;
            this.comboBoxWindow.Location = new System.Drawing.Point(312, 12);
            this.comboBoxWindow.Name = "comboBoxWindow";
            this.comboBoxWindow.Size = new System.Drawing.Size(265, 21);
            this.comboBoxWindow.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Window:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gauss Sigma:";
            // 
            // textBoxGaussSigma
            // 
            this.textBoxGaussSigma.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "gaussSigma", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxGaussSigma.Location = new System.Drawing.Point(312, 41);
            this.textBoxGaussSigma.Name = "textBoxGaussSigma";
            this.textBoxGaussSigma.Size = new System.Drawing.Size(100, 20);
            this.textBoxGaussSigma.TabIndex = 12;
            this.textBoxGaussSigma.Text = global::filter_design_gui.Properties.Settings.Default.gaussSigma;
            // 
            // textBoxFilterLength
            // 
            this.textBoxFilterLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "filterLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFilterLength.Location = new System.Drawing.Point(117, 64);
            this.textBoxFilterLength.Name = "textBoxFilterLength";
            this.textBoxFilterLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterLength.TabIndex = 3;
            this.textBoxFilterLength.Text = global::filter_design_gui.Properties.Settings.Default.filterLength;
            // 
            // textBoxCutoffFrequency
            // 
            this.textBoxCutoffFrequency.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "cutoffFrequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCutoffFrequency.Location = new System.Drawing.Point(117, 38);
            this.textBoxCutoffFrequency.Name = "textBoxCutoffFrequency";
            this.textBoxCutoffFrequency.Size = new System.Drawing.Size(100, 20);
            this.textBoxCutoffFrequency.TabIndex = 2;
            this.textBoxCutoffFrequency.Text = global::filter_design_gui.Properties.Settings.Default.cutoffFrequency;
            // 
            // textBoxSampleRate
            // 
            this.textBoxSampleRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "sampleRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSampleRate.Location = new System.Drawing.Point(117, 12);
            this.textBoxSampleRate.Name = "textBoxSampleRate";
            this.textBoxSampleRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxSampleRate.TabIndex = 1;
            this.textBoxSampleRate.Text = global::filter_design_gui.Properties.Settings.Default.sampleRate;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(12, 649);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(54, 23);
            this.buttonCopy.TabIndex = 14;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // buttonCopyCSV
            // 
            this.buttonCopyCSV.Location = new System.Drawing.Point(72, 649);
            this.buttonCopyCSV.Name = "buttonCopyCSV";
            this.buttonCopyCSV.Size = new System.Drawing.Size(54, 23);
            this.buttonCopyCSV.TabIndex = 15;
            this.buttonCopyCSV.Text = "Copy ,";
            this.buttonCopyCSV.UseVisualStyleBackColor = true;
            this.buttonCopyCSV.Click += new System.EventHandler(this.ButtonCopyCSV_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(755, 93);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 688);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.buttonCopyCSV);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGaussSigma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxWindow);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelCoeffs);
            this.Controls.Add(this.richTextBoxCoeffs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilterLength);
            this.Controls.Add(this.textBoxCutoffFrequency);
            this.Controls.Add(this.textBoxSampleRate);
            this.Controls.Add(this.buttonLP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageImpulse.ResumeLayout(false);
            this.tabPageFrequency.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLP;
        private System.Windows.Forms.TextBox textBoxSampleRate;
        private System.Windows.Forms.TextBox textBoxCutoffFrequency;
        private System.Windows.Forms.TextBox textBoxFilterLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxCoeffs;
        private System.Windows.Forms.Label labelCoeffs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageImpulse;
        private System.Windows.Forms.TabPage tabPageFrequency;
        private ZedGraph.ZedGraphControl zgcImpulseResponse;
        private ZedGraph.ZedGraphControl zgcFrequencyResponse;
        private System.Windows.Forms.ComboBox comboBoxWindow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGaussSigma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCopyCSV;
        private System.Windows.Forms.Button clearButton;
    }
}

