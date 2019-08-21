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
            this.buttonLPMathNET = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxCoeffs = new System.Windows.Forms.RichTextBox();
            this.labelCoeffs = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFrequencyLog = new System.Windows.Forms.TabPage();
            this.zgcFrequencyResponseLog = new ZedGraph.ZedGraphControl();
            this.tabPageFrequencyLinear = new System.Windows.Forms.TabPage();
            this.zgcFrequencyResponseLinear = new ZedGraph.ZedGraphControl();
            this.tabPageImpulse = new System.Windows.Forms.TabPage();
            this.zgcImpulseResponse = new ZedGraph.ZedGraphControl();
            this.tabPageStepResponse = new System.Windows.Forms.TabPage();
            this.zgcStepResponse = new ZedGraph.ZedGraphControl();
            this.comboBoxWindow = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGaussSigma = new System.Windows.Forms.TextBox();
            this.textBoxFilterLength = new System.Windows.Forms.TextBox();
            this.textBoxCutoffFrequency1 = new System.Windows.Forms.TextBox();
            this.textBoxSampleRate = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCopyCSV = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonLPNWaves = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCutoffFrequency2 = new System.Windows.Forms.TextBox();
            this.buttonBPMathNET = new System.Windows.Forms.Button();
            this.buttonBPNWaves = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageFrequencyLog.SuspendLayout();
            this.tabPageFrequencyLinear.SuspendLayout();
            this.tabPageImpulse.SuspendLayout();
            this.tabPageStepResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLPMathNET
            // 
            this.buttonLPMathNET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLPMathNET.Location = new System.Drawing.Point(691, 12);
            this.buttonLPMathNET.Name = "buttonLPMathNET";
            this.buttonLPMathNET.Size = new System.Drawing.Size(139, 23);
            this.buttonLPMathNET.TabIndex = 0;
            this.buttonLPMathNET.Text = "Calc Lowpass Math.NET";
            this.buttonLPMathNET.UseVisualStyleBackColor = true;
            this.buttonLPMathNET.Click += new System.EventHandler(this.ButtonLPMathNET_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sample Rate [Hz]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cutoff Frequency 1 [Hz]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 15);
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
            this.tabControl1.Controls.Add(this.tabPageFrequencyLog);
            this.tabControl1.Controls.Add(this.tabPageFrequencyLinear);
            this.tabControl1.Controls.Add(this.tabPageImpulse);
            this.tabControl1.Controls.Add(this.tabPageStepResponse);
            this.tabControl1.Location = new System.Drawing.Point(167, 114);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 562);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageFrequencyLog
            // 
            this.tabPageFrequencyLog.Controls.Add(this.zgcFrequencyResponseLog);
            this.tabPageFrequencyLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrequencyLog.Name = "tabPageFrequencyLog";
            this.tabPageFrequencyLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFrequencyLog.Size = new System.Drawing.Size(655, 536);
            this.tabPageFrequencyLog.TabIndex = 1;
            this.tabPageFrequencyLog.Text = "Frequency Response (Log)";
            this.tabPageFrequencyLog.UseVisualStyleBackColor = true;
            // 
            // zgcFrequencyResponseLog
            // 
            this.zgcFrequencyResponseLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgcFrequencyResponseLog.Location = new System.Drawing.Point(3, 3);
            this.zgcFrequencyResponseLog.Name = "zgcFrequencyResponseLog";
            this.zgcFrequencyResponseLog.ScrollGrace = 0D;
            this.zgcFrequencyResponseLog.ScrollMaxX = 0D;
            this.zgcFrequencyResponseLog.ScrollMaxY = 0D;
            this.zgcFrequencyResponseLog.ScrollMaxY2 = 0D;
            this.zgcFrequencyResponseLog.ScrollMinX = 0D;
            this.zgcFrequencyResponseLog.ScrollMinY = 0D;
            this.zgcFrequencyResponseLog.ScrollMinY2 = 0D;
            this.zgcFrequencyResponseLog.Size = new System.Drawing.Size(649, 530);
            this.zgcFrequencyResponseLog.TabIndex = 1;
            this.zgcFrequencyResponseLog.UseExtendedPrintDialog = true;
            // 
            // tabPageFrequencyLinear
            // 
            this.tabPageFrequencyLinear.Controls.Add(this.zgcFrequencyResponseLinear);
            this.tabPageFrequencyLinear.Location = new System.Drawing.Point(4, 22);
            this.tabPageFrequencyLinear.Name = "tabPageFrequencyLinear";
            this.tabPageFrequencyLinear.Size = new System.Drawing.Size(655, 536);
            this.tabPageFrequencyLinear.TabIndex = 2;
            this.tabPageFrequencyLinear.Text = "Frequency Response (Linear)";
            this.tabPageFrequencyLinear.UseVisualStyleBackColor = true;
            // 
            // zgcFrequencyResponseLinear
            // 
            this.zgcFrequencyResponseLinear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgcFrequencyResponseLinear.Location = new System.Drawing.Point(0, 0);
            this.zgcFrequencyResponseLinear.Name = "zgcFrequencyResponseLinear";
            this.zgcFrequencyResponseLinear.ScrollGrace = 0D;
            this.zgcFrequencyResponseLinear.ScrollMaxX = 0D;
            this.zgcFrequencyResponseLinear.ScrollMaxY = 0D;
            this.zgcFrequencyResponseLinear.ScrollMaxY2 = 0D;
            this.zgcFrequencyResponseLinear.ScrollMinX = 0D;
            this.zgcFrequencyResponseLinear.ScrollMinY = 0D;
            this.zgcFrequencyResponseLinear.ScrollMinY2 = 0D;
            this.zgcFrequencyResponseLinear.Size = new System.Drawing.Size(655, 536);
            this.zgcFrequencyResponseLinear.TabIndex = 2;
            this.zgcFrequencyResponseLinear.UseExtendedPrintDialog = true;
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
            // tabPageStepResponse
            // 
            this.tabPageStepResponse.Controls.Add(this.zgcStepResponse);
            this.tabPageStepResponse.Location = new System.Drawing.Point(4, 22);
            this.tabPageStepResponse.Name = "tabPageStepResponse";
            this.tabPageStepResponse.Size = new System.Drawing.Size(655, 536);
            this.tabPageStepResponse.TabIndex = 3;
            this.tabPageStepResponse.Text = "Step Response";
            this.tabPageStepResponse.UseVisualStyleBackColor = true;
            // 
            // zgcStepResponse
            // 
            this.zgcStepResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgcStepResponse.Location = new System.Drawing.Point(0, 0);
            this.zgcStepResponse.Name = "zgcStepResponse";
            this.zgcStepResponse.ScrollGrace = 0D;
            this.zgcStepResponse.ScrollMaxX = 0D;
            this.zgcStepResponse.ScrollMaxY = 0D;
            this.zgcStepResponse.ScrollMaxY2 = 0D;
            this.zgcStepResponse.ScrollMinX = 0D;
            this.zgcStepResponse.ScrollMinY = 0D;
            this.zgcStepResponse.ScrollMinY2 = 0D;
            this.zgcStepResponse.Size = new System.Drawing.Size(655, 536);
            this.zgcStepResponse.TabIndex = 1;
            this.zgcStepResponse.UseExtendedPrintDialog = true;
            // 
            // comboBoxWindow
            // 
            this.comboBoxWindow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWindow.FormattingEnabled = true;
            this.comboBoxWindow.Location = new System.Drawing.Point(519, 12);
            this.comboBoxWindow.Name = "comboBoxWindow";
            this.comboBoxWindow.Size = new System.Drawing.Size(100, 21);
            this.comboBoxWindow.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Window:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gauss Sigma:";
            // 
            // textBoxGaussSigma
            // 
            this.textBoxGaussSigma.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "gaussSigma", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxGaussSigma.Location = new System.Drawing.Point(519, 41);
            this.textBoxGaussSigma.Name = "textBoxGaussSigma";
            this.textBoxGaussSigma.Size = new System.Drawing.Size(100, 20);
            this.textBoxGaussSigma.TabIndex = 12;
            this.textBoxGaussSigma.Text = global::filter_design_gui.Properties.Settings.Default.gaussSigma;
            // 
            // textBoxFilterLength
            // 
            this.textBoxFilterLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "filterLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFilterLength.Location = new System.Drawing.Point(330, 12);
            this.textBoxFilterLength.Name = "textBoxFilterLength";
            this.textBoxFilterLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilterLength.TabIndex = 3;
            this.textBoxFilterLength.Text = global::filter_design_gui.Properties.Settings.Default.filterLength;
            // 
            // textBoxCutoffFrequency1
            // 
            this.textBoxCutoffFrequency1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "cutoffFrequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCutoffFrequency1.Location = new System.Drawing.Point(140, 38);
            this.textBoxCutoffFrequency1.Name = "textBoxCutoffFrequency1";
            this.textBoxCutoffFrequency1.Size = new System.Drawing.Size(100, 20);
            this.textBoxCutoffFrequency1.TabIndex = 2;
            this.textBoxCutoffFrequency1.Text = global::filter_design_gui.Properties.Settings.Default.cutoffFrequency;
            // 
            // textBoxSampleRate
            // 
            this.textBoxSampleRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "sampleRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSampleRate.Location = new System.Drawing.Point(140, 12);
            this.textBoxSampleRate.Name = "textBoxSampleRate";
            this.textBoxSampleRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxSampleRate.TabIndex = 1;
            this.textBoxSampleRate.Text = global::filter_design_gui.Properties.Settings.Default.sampleRate;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.buttonCopyCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.clearButton.Location = new System.Drawing.Point(308, 88);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // buttonLPNWaves
            // 
            this.buttonLPNWaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLPNWaves.Location = new System.Drawing.Point(691, 39);
            this.buttonLPNWaves.Name = "buttonLPNWaves";
            this.buttonLPNWaves.Size = new System.Drawing.Size(139, 23);
            this.buttonLPNWaves.TabIndex = 1;
            this.buttonLPNWaves.Text = "Calc Lowpass NWaves";
            this.buttonLPNWaves.UseVisualStyleBackColor = true;
            this.buttonLPNWaves.Click += new System.EventHandler(this.ButtonLPNWaves_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cutoff Frequency 2 [Hz]:";
            // 
            // textBoxCutoffFrequency2
            // 
            this.textBoxCutoffFrequency2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::filter_design_gui.Properties.Settings.Default, "cutoffFrequency2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCutoffFrequency2.Location = new System.Drawing.Point(140, 64);
            this.textBoxCutoffFrequency2.Name = "textBoxCutoffFrequency2";
            this.textBoxCutoffFrequency2.Size = new System.Drawing.Size(100, 20);
            this.textBoxCutoffFrequency2.TabIndex = 18;
            this.textBoxCutoffFrequency2.Text = global::filter_design_gui.Properties.Settings.Default.cutoffFrequency2;
            // 
            // buttonBPMathNET
            // 
            this.buttonBPMathNET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBPMathNET.Location = new System.Drawing.Point(691, 67);
            this.buttonBPMathNET.Name = "buttonBPMathNET";
            this.buttonBPMathNET.Size = new System.Drawing.Size(139, 23);
            this.buttonBPMathNET.TabIndex = 20;
            this.buttonBPMathNET.Text = "Calc Bandpass Math.NET";
            this.buttonBPMathNET.UseVisualStyleBackColor = true;
            this.buttonBPMathNET.Click += new System.EventHandler(this.ButtonBPMathNET_Click);
            // 
            // buttonBPNWaves
            // 
            this.buttonBPNWaves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBPNWaves.Location = new System.Drawing.Point(691, 96);
            this.buttonBPNWaves.Name = "buttonBPNWaves";
            this.buttonBPNWaves.Size = new System.Drawing.Size(139, 23);
            this.buttonBPNWaves.TabIndex = 21;
            this.buttonBPNWaves.Text = "Calc Bandpass NWaves";
            this.buttonBPNWaves.UseVisualStyleBackColor = true;
            this.buttonBPNWaves.Click += new System.EventHandler(this.ButtonBPNWaves_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 688);
            this.Controls.Add(this.buttonBPNWaves);
            this.Controls.Add(this.buttonBPMathNET);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCutoffFrequency2);
            this.Controls.Add(this.buttonLPNWaves);
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
            this.Controls.Add(this.textBoxCutoffFrequency1);
            this.Controls.Add(this.textBoxSampleRate);
            this.Controls.Add(this.buttonLPMathNET);
            this.Name = "Form1";
            this.Text = "Filter Design";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFrequencyLog.ResumeLayout(false);
            this.tabPageFrequencyLinear.ResumeLayout(false);
            this.tabPageImpulse.ResumeLayout(false);
            this.tabPageStepResponse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLPMathNET;
        private System.Windows.Forms.TextBox textBoxSampleRate;
        private System.Windows.Forms.TextBox textBoxCutoffFrequency1;
        private System.Windows.Forms.TextBox textBoxFilterLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxCoeffs;
        private System.Windows.Forms.Label labelCoeffs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageImpulse;
        private System.Windows.Forms.TabPage tabPageFrequencyLog;
        private ZedGraph.ZedGraphControl zgcImpulseResponse;
        private ZedGraph.ZedGraphControl zgcFrequencyResponseLog;
        private System.Windows.Forms.ComboBox comboBoxWindow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGaussSigma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCopyCSV;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TabPage tabPageFrequencyLinear;
        private ZedGraph.ZedGraphControl zgcFrequencyResponseLinear;
        private System.Windows.Forms.TabPage tabPageStepResponse;
        private ZedGraph.ZedGraphControl zgcStepResponse;
        private System.Windows.Forms.Button buttonLPNWaves;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCutoffFrequency2;
        private System.Windows.Forms.Button buttonBPMathNET;
        private System.Windows.Forms.Button buttonBPNWaves;
    }
}

