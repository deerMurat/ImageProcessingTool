namespace ImageProcessingTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbArtificialImages = new System.Windows.Forms.ComboBox();
            this.btnRGBComponents = new System.Windows.Forms.Button();
            this.cbRGBComponents = new System.Windows.Forms.ComboBox();
            this.rbArtificialImages = new System.Windows.Forms.RadioButton();
            this.rbRGBComponents = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRGB = new System.Windows.Forms.RadioButton();
            this.tbImageBit = new System.Windows.Forms.TextBox();
            this.rbGray = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.rbImage = new System.Windows.Forms.RadioButton();
            this.rbMatrix = new System.Windows.Forms.RadioButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnResultImage = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnInputImage2 = new System.Windows.Forms.Button();
            this.btnInputImage1 = new System.Windows.Forms.Button();
            this.pbResultImage = new System.Windows.Forms.PictureBox();
            this.tbResultImage = new System.Windows.Forms.TextBox();
            this.tbInputImage2 = new System.Windows.Forms.TextBox();
            this.tbInputImage1 = new System.Windows.Forms.TextBox();
            this.pbInputImage2 = new System.Windows.Forms.PictureBox();
            this.pbInputImage1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnColorToGrayscale = new System.Windows.Forms.Button();
            this.cbSingleColorChannel = new System.Windows.Forms.ComboBox();
            this.cbDecomposition = new System.Windows.Forms.ComboBox();
            this.cbWeightedAverage = new System.Windows.Forms.ComboBox();
            this.rbSingleColorChannel = new System.Windows.Forms.RadioButton();
            this.rbDecomposition = new System.Windows.Forms.RadioButton();
            this.rbDesaturation = new System.Windows.Forms.RadioButton();
            this.rbWeightedAverage = new System.Windows.Forms.RadioButton();
            this.rbSimpleAverage = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBarBlendPer = new System.Windows.Forms.TrackBar();
            this.lblBlendPer = new System.Windows.Forms.Label();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.lblConstantB = new System.Windows.Forms.Label();
            this.lblConstantG = new System.Windows.Forms.Label();
            this.lblConstantR = new System.Windows.Forms.Label();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnArithmeticOp = new System.Windows.Forms.Button();
            this.cbWithImage = new System.Windows.Forms.ComboBox();
            this.cbWithConstant = new System.Windows.Forms.ComboBox();
            this.rbWithImage = new System.Windows.Forms.RadioButton();
            this.rbWithConstant = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbAdaptiveThresMatrix = new System.Windows.Forms.ComboBox();
            this.tbQuantization = new System.Windows.Forms.NumericUpDown();
            this.cbAdaptiveThres = new System.Windows.Forms.ComboBox();
            this.tbConvolution22 = new System.Windows.Forms.TextBox();
            this.tbConvolution12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbConvolution02 = new System.Windows.Forms.TextBox();
            this.tbConvolution21 = new System.Windows.Forms.TextBox();
            this.tbConvolution11 = new System.Windows.Forms.TextBox();
            this.tbConvolution01 = new System.Windows.Forms.TextBox();
            this.tbConvolution20 = new System.Windows.Forms.TextBox();
            this.tbConvolution10 = new System.Windows.Forms.TextBox();
            this.tbConvolution00 = new System.Windows.Forms.TextBox();
            this.btnPointOp = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.tbThresholding = new System.Windows.Forms.TextBox();
            this.rbConvolution = new System.Windows.Forms.RadioButton();
            this.rbQuantiation = new System.Windows.Forms.RadioButton();
            this.rbLogarithmOperator = new System.Windows.Forms.RadioButton();
            this.rbHistogramEq = new System.Windows.Forms.RadioButton();
            this.rbNormalization = new System.Windows.Forms.RadioButton();
            this.rbAdaptiveThresholding = new System.Windows.Forms.RadioButton();
            this.rbThresholding = new System.Windows.Forms.RadioButton();
            this.lblThresholdingValue = new System.Windows.Forms.Label();
            this.trackBarThresholding = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbScalingFactor = new System.Windows.Forms.NumericUpDown();
            this.tbTransY = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTransX = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReflectionAng = new System.Windows.Forms.Label();
            this.lblRotationAng = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbScalingMethod = new System.Windows.Forms.ComboBox();
            this.cbReflection = new System.Windows.Forms.ComboBox();
            this.trackBarReflection = new System.Windows.Forms.TrackBar();
            this.cbRotation = new System.Windows.Forms.ComboBox();
            this.rbTranslation = new System.Windows.Forms.RadioButton();
            this.trackBarRotation = new System.Windows.Forms.TrackBar();
            this.rbReflection = new System.Windows.Forms.RadioButton();
            this.cbScaling = new System.Windows.Forms.ComboBox();
            this.rbRotation = new System.Windows.Forms.RadioButton();
            this.rbScaling = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbNOT = new System.Windows.Forms.RadioButton();
            this.btnLogicOperator = new System.Windows.Forms.Button();
            this.rbXNOR = new System.Windows.Forms.RadioButton();
            this.rbNOR = new System.Windows.Forms.RadioButton();
            this.rbNAND = new System.Windows.Forms.RadioButton();
            this.rbXOR = new System.Windows.Forms.RadioButton();
            this.rbOR = new System.Windows.Forms.RadioButton();
            this.rbAND = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.gbGausMatrix = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.rbUnsharpFilter = new System.Windows.Forms.RadioButton();
            this.rbGaussianSmoothing = new System.Windows.Forms.RadioButton();
            this.rbCrimminsSpeckleRemoval = new System.Windows.Forms.RadioButton();
            this.tbUnsharpScaling = new System.Windows.Forms.NumericUpDown();
            this.tbCrimmins = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbConservativeSmoothing = new System.Windows.Forms.RadioButton();
            this.btnDigitalFilters = new System.Windows.Forms.Button();
            this.rbMedian = new System.Windows.Forms.RadioButton();
            this.rbMean = new System.Windows.Forms.RadioButton();
            this.cbUnsharpFilter = new System.Windows.Forms.ComboBox();
            this.cbConservativeSmoothing = new System.Windows.Forms.ComboBox();
            this.cbMedian = new System.Windows.Forms.ComboBox();
            this.cbMean = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.udEdgeDetectors2 = new System.Windows.Forms.DomainUpDown();
            this.udEdgeDetectors1 = new System.Windows.Forms.DomainUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.tbDifferenceOfGaussian = new System.Windows.Forms.TextBox();
            this.rbDifferenceOfGaussian = new System.Windows.Forms.RadioButton();
            this.tbLaplacianOfGaussaian = new System.Windows.Forms.TextBox();
            this.rbLaplacianOfGaussaian = new System.Windows.Forms.RadioButton();
            this.tbLaplacian = new System.Windows.Forms.TextBox();
            this.rbLaplacian = new System.Windows.Forms.RadioButton();
            this.tbScharr = new System.Windows.Forms.TextBox();
            this.btnEdgeDetectors = new System.Windows.Forms.Button();
            this.rbScharr = new System.Windows.Forms.RadioButton();
            this.tbRoberts = new System.Windows.Forms.TextBox();
            this.rbRoberts = new System.Windows.Forms.RadioButton();
            this.tbPrewitt = new System.Windows.Forms.TextBox();
            this.rbPrewitt = new System.Windows.Forms.RadioButton();
            this.tbSobel = new System.Windows.Forms.TextBox();
            this.rbSobel = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInputImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInputImage1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlendPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholding)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScalingFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReflection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.gbGausMatrix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnsharpScaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCrimmins)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbArtificialImages);
            this.groupBox1.Controls.Add(this.btnRGBComponents);
            this.groupBox1.Controls.Add(this.cbRGBComponents);
            this.groupBox1.Controls.Add(this.rbArtificialImages);
            this.groupBox1.Controls.Add(this.rbRGBComponents);
            this.groupBox1.Location = new System.Drawing.Point(775, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(288, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RGB Components";
            // 
            // cbArtificialImages
            // 
            this.cbArtificialImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArtificialImages.Enabled = false;
            this.cbArtificialImages.FormattingEnabled = true;
            this.cbArtificialImages.Items.AddRange(new object[] {
            "R G B",
            "R B G",
            "G R B",
            "G B R ",
            "B R G",
            "B G R"});
            this.cbArtificialImages.Location = new System.Drawing.Point(130, 39);
            this.cbArtificialImages.Margin = new System.Windows.Forms.Padding(2);
            this.cbArtificialImages.Name = "cbArtificialImages";
            this.cbArtificialImages.Size = new System.Drawing.Size(88, 21);
            this.cbArtificialImages.TabIndex = 1;
            // 
            // btnRGBComponents
            // 
            this.btnRGBComponents.Location = new System.Drawing.Point(222, 17);
            this.btnRGBComponents.Margin = new System.Windows.Forms.Padding(2);
            this.btnRGBComponents.Name = "btnRGBComponents";
            this.btnRGBComponents.Size = new System.Drawing.Size(63, 43);
            this.btnRGBComponents.TabIndex = 2;
            this.btnRGBComponents.Text = "Apply";
            this.btnRGBComponents.UseVisualStyleBackColor = true;
            this.btnRGBComponents.Click += new System.EventHandler(this.btnRGBComponents_Click);
            // 
            // cbRGBComponents
            // 
            this.cbRGBComponents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRGBComponents.Enabled = false;
            this.cbRGBComponents.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbRGBComponents.Items.AddRange(new object[] {
            "R",
            "G",
            "B"});
            this.cbRGBComponents.Location = new System.Drawing.Point(130, 17);
            this.cbRGBComponents.Margin = new System.Windows.Forms.Padding(2);
            this.cbRGBComponents.Name = "cbRGBComponents";
            this.cbRGBComponents.Size = new System.Drawing.Size(88, 21);
            this.cbRGBComponents.TabIndex = 1;
            // 
            // rbArtificialImages
            // 
            this.rbArtificialImages.AutoSize = true;
            this.rbArtificialImages.Location = new System.Drawing.Point(5, 40);
            this.rbArtificialImages.Margin = new System.Windows.Forms.Padding(2);
            this.rbArtificialImages.Name = "rbArtificialImages";
            this.rbArtificialImages.Size = new System.Drawing.Size(96, 17);
            this.rbArtificialImages.TabIndex = 0;
            this.rbArtificialImages.Text = "Artifical Images";
            this.rbArtificialImages.UseVisualStyleBackColor = true;
            this.rbArtificialImages.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbRGBComponents
            // 
            this.rbRGBComponents.AutoSize = true;
            this.rbRGBComponents.Location = new System.Drawing.Point(5, 18);
            this.rbRGBComponents.Margin = new System.Windows.Forms.Padding(2);
            this.rbRGBComponents.Name = "rbRGBComponents";
            this.rbRGBComponents.Size = new System.Drawing.Size(110, 17);
            this.rbRGBComponents.TabIndex = 0;
            this.rbRGBComponents.Text = "RGB Components";
            this.rbRGBComponents.UseVisualStyleBackColor = true;
            this.rbRGBComponents.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.rbImage);
            this.groupBox2.Controls.Add(this.rbMatrix);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.btnResultImage);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnInputImage2);
            this.groupBox2.Controls.Add(this.btnInputImage1);
            this.groupBox2.Controls.Add(this.pbResultImage);
            this.groupBox2.Controls.Add(this.tbResultImage);
            this.groupBox2.Controls.Add(this.tbInputImage2);
            this.groupBox2.Controls.Add(this.tbInputImage1);
            this.groupBox2.Controls.Add(this.pbInputImage2);
            this.groupBox2.Controls.Add(this.pbInputImage1);
            this.groupBox2.Location = new System.Drawing.Point(1, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(467, 781);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRGB);
            this.panel1.Controls.Add(this.tbImageBit);
            this.panel1.Controls.Add(this.rbGray);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(85, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 39);
            this.panel1.TabIndex = 21;
            // 
            // rbRGB
            // 
            this.rbRGB.AutoSize = true;
            this.rbRGB.Location = new System.Drawing.Point(6, 2);
            this.rbRGB.Name = "rbRGB";
            this.rbRGB.Size = new System.Drawing.Size(48, 17);
            this.rbRGB.TabIndex = 20;
            this.rbRGB.Text = "RGB";
            this.rbRGB.UseVisualStyleBackColor = true;
            this.rbRGB.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbImageBit
            // 
            this.tbImageBit.Location = new System.Drawing.Point(95, 2);
            this.tbImageBit.Margin = new System.Windows.Forms.Padding(2);
            this.tbImageBit.Name = "tbImageBit";
            this.tbImageBit.Size = new System.Drawing.Size(20, 20);
            this.tbImageBit.TabIndex = 12;
            this.tbImageBit.Text = "4";
            // 
            // rbGray
            // 
            this.rbGray.AutoSize = true;
            this.rbGray.Checked = true;
            this.rbGray.Location = new System.Drawing.Point(6, 21);
            this.rbGray.Name = "rbGray";
            this.rbGray.Size = new System.Drawing.Size(47, 17);
            this.rbGray.TabIndex = 20;
            this.rbGray.TabStop = true;
            this.rbGray.Text = "Gray";
            this.rbGray.UseVisualStyleBackColor = true;
            this.rbGray.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Bit:";
            // 
            // rbImage
            // 
            this.rbImage.AutoSize = true;
            this.rbImage.Location = new System.Drawing.Point(8, 35);
            this.rbImage.Name = "rbImage";
            this.rbImage.Size = new System.Drawing.Size(54, 17);
            this.rbImage.TabIndex = 20;
            this.rbImage.Text = "Image";
            this.rbImage.UseVisualStyleBackColor = true;
            this.rbImage.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbMatrix
            // 
            this.rbMatrix.AutoSize = true;
            this.rbMatrix.Checked = true;
            this.rbMatrix.Location = new System.Drawing.Point(8, 17);
            this.rbMatrix.Name = "rbMatrix";
            this.rbMatrix.Size = new System.Drawing.Size(53, 17);
            this.rbMatrix.TabIndex = 20;
            this.rbMatrix.TabStop = true;
            this.rbMatrix.Text = "Matrix";
            this.rbMatrix.UseVisualStyleBackColor = true;
            this.rbMatrix.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(5, 353);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(446, 289);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input Image 2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(221, 228);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // btnResultImage
            // 
            this.btnResultImage.Location = new System.Drawing.Point(183, 682);
            this.btnResultImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnResultImage.Name = "btnResultImage";
            this.btnResultImage.Size = new System.Drawing.Size(44, 21);
            this.btnResultImage.TabIndex = 7;
            this.btnResultImage.Text = "Save";
            this.btnResultImage.UseVisualStyleBackColor = true;
            this.btnResultImage.Click += new System.EventHandler(this.btnResultImage_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Input Image 1";
            // 
            // btnInputImage2
            // 
            this.btnInputImage2.Location = new System.Drawing.Point(406, 308);
            this.btnInputImage2.Margin = new System.Windows.Forms.Padding(2);
            this.btnInputImage2.Name = "btnInputImage2";
            this.btnInputImage2.Size = new System.Drawing.Size(44, 24);
            this.btnInputImage2.TabIndex = 8;
            this.btnInputImage2.Text = "Open";
            this.btnInputImage2.UseVisualStyleBackColor = true;
            this.btnInputImage2.Click += new System.EventHandler(this.btnInputImage2_Click);
            // 
            // btnInputImage1
            // 
            this.btnInputImage1.Location = new System.Drawing.Point(182, 308);
            this.btnInputImage1.Margin = new System.Windows.Forms.Padding(2);
            this.btnInputImage1.Name = "btnInputImage1";
            this.btnInputImage1.Size = new System.Drawing.Size(44, 24);
            this.btnInputImage1.TabIndex = 8;
            this.btnInputImage1.Text = "Open";
            this.btnInputImage1.UseVisualStyleBackColor = true;
            this.btnInputImage1.Click += new System.EventHandler(this.btnInputImage1_Click);
            // 
            // pbResultImage
            // 
            this.pbResultImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResultImage.Location = new System.Drawing.Point(4, 353);
            this.pbResultImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbResultImage.Name = "pbResultImage";
            this.pbResultImage.Size = new System.Drawing.Size(446, 310);
            this.pbResultImage.TabIndex = 3;
            this.pbResultImage.TabStop = false;
            // 
            // tbResultImage
            // 
            this.tbResultImage.Location = new System.Drawing.Point(3, 682);
            this.tbResultImage.Margin = new System.Windows.Forms.Padding(2);
            this.tbResultImage.Name = "tbResultImage";
            this.tbResultImage.Size = new System.Drawing.Size(174, 20);
            this.tbResultImage.TabIndex = 5;
            // 
            // tbInputImage2
            // 
            this.tbInputImage2.Location = new System.Drawing.Point(230, 310);
            this.tbInputImage2.Margin = new System.Windows.Forms.Padding(2);
            this.tbInputImage2.Name = "tbInputImage2";
            this.tbInputImage2.Size = new System.Drawing.Size(172, 20);
            this.tbInputImage2.TabIndex = 6;
            // 
            // tbInputImage1
            // 
            this.tbInputImage1.Location = new System.Drawing.Point(6, 310);
            this.tbInputImage1.Margin = new System.Windows.Forms.Padding(2);
            this.tbInputImage1.Name = "tbInputImage1";
            this.tbInputImage1.Size = new System.Drawing.Size(172, 20);
            this.tbInputImage1.TabIndex = 6;
            // 
            // pbInputImage2
            // 
            this.pbInputImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbInputImage2.Location = new System.Drawing.Point(230, 79);
            this.pbInputImage2.Margin = new System.Windows.Forms.Padding(2);
            this.pbInputImage2.Name = "pbInputImage2";
            this.pbInputImage2.Size = new System.Drawing.Size(220, 226);
            this.pbInputImage2.TabIndex = 4;
            this.pbInputImage2.TabStop = false;
            // 
            // pbInputImage1
            // 
            this.pbInputImage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbInputImage1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbInputImage1.InitialImage")));
            this.pbInputImage1.Location = new System.Drawing.Point(6, 79);
            this.pbInputImage1.Margin = new System.Windows.Forms.Padding(2);
            this.pbInputImage1.Name = "pbInputImage1";
            this.pbInputImage1.Size = new System.Drawing.Size(221, 227);
            this.pbInputImage1.TabIndex = 4;
            this.pbInputImage1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnColorToGrayscale);
            this.groupBox3.Controls.Add(this.cbSingleColorChannel);
            this.groupBox3.Controls.Add(this.cbDecomposition);
            this.groupBox3.Controls.Add(this.cbWeightedAverage);
            this.groupBox3.Controls.Add(this.rbSingleColorChannel);
            this.groupBox3.Controls.Add(this.rbDecomposition);
            this.groupBox3.Controls.Add(this.rbDesaturation);
            this.groupBox3.Controls.Add(this.rbWeightedAverage);
            this.groupBox3.Controls.Add(this.rbSimpleAverage);
            this.groupBox3.Location = new System.Drawing.Point(775, 90);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(288, 141);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color to Grayscale";
            // 
            // btnColorToGrayscale
            // 
            this.btnColorToGrayscale.Location = new System.Drawing.Point(222, 81);
            this.btnColorToGrayscale.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorToGrayscale.Name = "btnColorToGrayscale";
            this.btnColorToGrayscale.Size = new System.Drawing.Size(63, 45);
            this.btnColorToGrayscale.TabIndex = 3;
            this.btnColorToGrayscale.Text = "Apply";
            this.btnColorToGrayscale.UseVisualStyleBackColor = true;
            this.btnColorToGrayscale.Click += new System.EventHandler(this.btnColorToGrayscale_Click);
            // 
            // cbSingleColorChannel
            // 
            this.cbSingleColorChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSingleColorChannel.Enabled = false;
            this.cbSingleColorChannel.FormattingEnabled = true;
            this.cbSingleColorChannel.Items.AddRange(new object[] {
            "R",
            "G",
            "B"});
            this.cbSingleColorChannel.Location = new System.Drawing.Point(130, 105);
            this.cbSingleColorChannel.Margin = new System.Windows.Forms.Padding(2);
            this.cbSingleColorChannel.Name = "cbSingleColorChannel";
            this.cbSingleColorChannel.Size = new System.Drawing.Size(88, 21);
            this.cbSingleColorChannel.TabIndex = 1;
            // 
            // cbDecomposition
            // 
            this.cbDecomposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDecomposition.Enabled = false;
            this.cbDecomposition.FormattingEnabled = true;
            this.cbDecomposition.Items.AddRange(new object[] {
            "Max(R,G,B)",
            "Min(R,G,B)"});
            this.cbDecomposition.Location = new System.Drawing.Point(130, 81);
            this.cbDecomposition.Margin = new System.Windows.Forms.Padding(2);
            this.cbDecomposition.Name = "cbDecomposition";
            this.cbDecomposition.Size = new System.Drawing.Size(88, 21);
            this.cbDecomposition.TabIndex = 1;
            // 
            // cbWeightedAverage
            // 
            this.cbWeightedAverage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeightedAverage.Enabled = false;
            this.cbWeightedAverage.FormattingEnabled = true;
            this.cbWeightedAverage.Items.AddRange(new object[] {
            "0.299R+0.587G+0.114B",
            "0.2126R+0.7152G+0.0722B",
            "0.3R+0.59G+0.11B"});
            this.cbWeightedAverage.Location = new System.Drawing.Point(130, 40);
            this.cbWeightedAverage.Margin = new System.Windows.Forms.Padding(2);
            this.cbWeightedAverage.Name = "cbWeightedAverage";
            this.cbWeightedAverage.Size = new System.Drawing.Size(155, 21);
            this.cbWeightedAverage.TabIndex = 1;
            // 
            // rbSingleColorChannel
            // 
            this.rbSingleColorChannel.AutoSize = true;
            this.rbSingleColorChannel.Location = new System.Drawing.Point(4, 106);
            this.rbSingleColorChannel.Margin = new System.Windows.Forms.Padding(2);
            this.rbSingleColorChannel.Name = "rbSingleColorChannel";
            this.rbSingleColorChannel.Size = new System.Drawing.Size(123, 17);
            this.rbSingleColorChannel.TabIndex = 0;
            this.rbSingleColorChannel.Text = "Single Color Channel";
            this.rbSingleColorChannel.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbDecomposition
            // 
            this.rbDecomposition.AutoSize = true;
            this.rbDecomposition.Location = new System.Drawing.Point(5, 84);
            this.rbDecomposition.Margin = new System.Windows.Forms.Padding(2);
            this.rbDecomposition.Name = "rbDecomposition";
            this.rbDecomposition.Size = new System.Drawing.Size(95, 17);
            this.rbDecomposition.TabIndex = 0;
            this.rbDecomposition.Text = "Decomposition";
            this.rbDecomposition.UseVisualStyleBackColor = true;
            this.rbDecomposition.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbDesaturation
            // 
            this.rbDesaturation.AutoSize = true;
            this.rbDesaturation.Location = new System.Drawing.Point(5, 62);
            this.rbDesaturation.Margin = new System.Windows.Forms.Padding(2);
            this.rbDesaturation.Name = "rbDesaturation";
            this.rbDesaturation.Size = new System.Drawing.Size(85, 17);
            this.rbDesaturation.TabIndex = 0;
            this.rbDesaturation.Text = "Desaturation";
            this.rbDesaturation.UseVisualStyleBackColor = true;
            this.rbDesaturation.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbWeightedAverage
            // 
            this.rbWeightedAverage.AutoSize = true;
            this.rbWeightedAverage.Location = new System.Drawing.Point(5, 40);
            this.rbWeightedAverage.Margin = new System.Windows.Forms.Padding(2);
            this.rbWeightedAverage.Name = "rbWeightedAverage";
            this.rbWeightedAverage.Size = new System.Drawing.Size(114, 17);
            this.rbWeightedAverage.TabIndex = 0;
            this.rbWeightedAverage.Text = "Weighted Average";
            this.rbWeightedAverage.UseVisualStyleBackColor = true;
            this.rbWeightedAverage.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbSimpleAverage
            // 
            this.rbSimpleAverage.AutoSize = true;
            this.rbSimpleAverage.Location = new System.Drawing.Point(5, 18);
            this.rbSimpleAverage.Margin = new System.Windows.Forms.Padding(2);
            this.rbSimpleAverage.Name = "rbSimpleAverage";
            this.rbSimpleAverage.Size = new System.Drawing.Size(99, 17);
            this.rbSimpleAverage.TabIndex = 0;
            this.rbSimpleAverage.Text = "Simple Average";
            this.rbSimpleAverage.UseVisualStyleBackColor = true;
            this.rbSimpleAverage.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.trackBarBlendPer);
            this.groupBox4.Controls.Add(this.lblBlendPer);
            this.groupBox4.Controls.Add(this.trackBarB);
            this.groupBox4.Controls.Add(this.lblConstantB);
            this.groupBox4.Controls.Add(this.lblConstantG);
            this.groupBox4.Controls.Add(this.lblConstantR);
            this.groupBox4.Controls.Add(this.trackBarG);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.trackBarR);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnArithmeticOp);
            this.groupBox4.Controls.Add(this.cbWithImage);
            this.groupBox4.Controls.Add(this.cbWithConstant);
            this.groupBox4.Controls.Add(this.rbWithImage);
            this.groupBox4.Controls.Add(this.rbWithConstant);
            this.groupBox4.Location = new System.Drawing.Point(775, 235);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(288, 143);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arithmetic Operations";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 18);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBarBlendPer
            // 
            this.trackBarBlendPer.AutoSize = false;
            this.trackBarBlendPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarBlendPer.Enabled = false;
            this.trackBarBlendPer.LargeChange = 20;
            this.trackBarBlendPer.Location = new System.Drawing.Point(132, 122);
            this.trackBarBlendPer.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarBlendPer.Maximum = 100;
            this.trackBarBlendPer.Name = "trackBarBlendPer";
            this.trackBarBlendPer.Size = new System.Drawing.Size(86, 17);
            this.trackBarBlendPer.TabIndex = 3;
            this.trackBarBlendPer.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlendPer.ValueChanged += new System.EventHandler(this.trackBarBlendPer_ValueChanged);
            // 
            // lblBlendPer
            // 
            this.lblBlendPer.AutoSize = true;
            this.lblBlendPer.Location = new System.Drawing.Point(219, 123);
            this.lblBlendPer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlendPer.Name = "lblBlendPer";
            this.lblBlendPer.Size = new System.Drawing.Size(41, 13);
            this.lblBlendPer.TabIndex = 9;
            this.lblBlendPer.Text = "ValueP";
            // 
            // trackBarB
            // 
            this.trackBarB.AutoSize = false;
            this.trackBarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarB.Enabled = false;
            this.trackBarB.LargeChange = 20;
            this.trackBarB.Location = new System.Drawing.Point(130, 71);
            this.trackBarB.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(86, 17);
            this.trackBarB.TabIndex = 3;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarRGB_ValueChanged);
            // 
            // lblConstantB
            // 
            this.lblConstantB.AutoSize = true;
            this.lblConstantB.Location = new System.Drawing.Point(214, 71);
            this.lblConstantB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstantB.Name = "lblConstantB";
            this.lblConstantB.Size = new System.Drawing.Size(41, 13);
            this.lblConstantB.TabIndex = 9;
            this.lblConstantB.Text = "ValueB";
            // 
            // lblConstantG
            // 
            this.lblConstantG.AutoSize = true;
            this.lblConstantG.Location = new System.Drawing.Point(214, 57);
            this.lblConstantG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstantG.Name = "lblConstantG";
            this.lblConstantG.Size = new System.Drawing.Size(42, 13);
            this.lblConstantG.TabIndex = 9;
            this.lblConstantG.Text = "ValueG";
            // 
            // lblConstantR
            // 
            this.lblConstantR.AutoSize = true;
            this.lblConstantR.Location = new System.Drawing.Point(214, 41);
            this.lblConstantR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConstantR.Name = "lblConstantR";
            this.lblConstantR.Size = new System.Drawing.Size(42, 13);
            this.lblConstantR.TabIndex = 9;
            this.lblConstantR.Text = "ValueR";
            // 
            // trackBarG
            // 
            this.trackBarG.AutoSize = false;
            this.trackBarG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarG.Enabled = false;
            this.trackBarG.LargeChange = 20;
            this.trackBarG.Location = new System.Drawing.Point(130, 55);
            this.trackBarG.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarG.Maximum = 100;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(86, 17);
            this.trackBarG.TabIndex = 3;
            this.trackBarG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarG.ValueChanged += new System.EventHandler(this.trackBarRGB_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Constant B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Constant G";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Constant R";
            // 
            // trackBarR
            // 
            this.trackBarR.AutoSize = false;
            this.trackBarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarR.Enabled = false;
            this.trackBarR.LargeChange = 20;
            this.trackBarR.Location = new System.Drawing.Point(130, 41);
            this.trackBarR.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarR.Maximum = 100;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(86, 17);
            this.trackBarR.TabIndex = 3;
            this.trackBarR.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarR.ValueChanged += new System.EventHandler(this.trackBarRGB_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blend Percentage(%)";
            // 
            // btnArithmeticOp
            // 
            this.btnArithmeticOp.Location = new System.Drawing.Point(0, 40);
            this.btnArithmeticOp.Margin = new System.Windows.Forms.Padding(2);
            this.btnArithmeticOp.Name = "btnArithmeticOp";
            this.btnArithmeticOp.Size = new System.Drawing.Size(35, 27);
            this.btnArithmeticOp.TabIndex = 3;
            this.btnArithmeticOp.Text = "Apply";
            this.btnArithmeticOp.UseVisualStyleBackColor = true;
            this.btnArithmeticOp.Visible = false;
            // 
            // cbWithImage
            // 
            this.cbWithImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWithImage.Enabled = false;
            this.cbWithImage.FormattingEnabled = true;
            this.cbWithImage.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.cbWithImage.Location = new System.Drawing.Point(130, 94);
            this.cbWithImage.Margin = new System.Windows.Forms.Padding(2);
            this.cbWithImage.Name = "cbWithImage";
            this.cbWithImage.Size = new System.Drawing.Size(88, 21);
            this.cbWithImage.TabIndex = 1;
            // 
            // cbWithConstant
            // 
            this.cbWithConstant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWithConstant.Enabled = false;
            this.cbWithConstant.FormattingEnabled = true;
            this.cbWithConstant.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.cbWithConstant.Location = new System.Drawing.Point(126, 14);
            this.cbWithConstant.Margin = new System.Windows.Forms.Padding(2);
            this.cbWithConstant.Name = "cbWithConstant";
            this.cbWithConstant.Size = new System.Drawing.Size(88, 21);
            this.cbWithConstant.TabIndex = 1;
            // 
            // rbWithImage
            // 
            this.rbWithImage.AutoSize = true;
            this.rbWithImage.Location = new System.Drawing.Point(4, 98);
            this.rbWithImage.Margin = new System.Windows.Forms.Padding(2);
            this.rbWithImage.Name = "rbWithImage";
            this.rbWithImage.Size = new System.Drawing.Size(79, 17);
            this.rbWithImage.TabIndex = 0;
            this.rbWithImage.Text = "With Image";
            this.rbWithImage.UseVisualStyleBackColor = true;
            this.rbWithImage.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbWithConstant
            // 
            this.rbWithConstant.AutoSize = true;
            this.rbWithConstant.Location = new System.Drawing.Point(5, 18);
            this.rbWithConstant.Margin = new System.Windows.Forms.Padding(2);
            this.rbWithConstant.Name = "rbWithConstant";
            this.rbWithConstant.Size = new System.Drawing.Size(92, 17);
            this.rbWithConstant.TabIndex = 0;
            this.rbWithConstant.Text = "With Constant";
            this.rbWithConstant.UseVisualStyleBackColor = true;
            this.rbWithConstant.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbAdaptiveThresMatrix);
            this.groupBox5.Controls.Add(this.tbQuantization);
            this.groupBox5.Controls.Add(this.cbAdaptiveThres);
            this.groupBox5.Controls.Add(this.tbConvolution22);
            this.groupBox5.Controls.Add(this.tbConvolution12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.tbConvolution02);
            this.groupBox5.Controls.Add(this.tbConvolution21);
            this.groupBox5.Controls.Add(this.tbConvolution11);
            this.groupBox5.Controls.Add(this.tbConvolution01);
            this.groupBox5.Controls.Add(this.tbConvolution20);
            this.groupBox5.Controls.Add(this.tbConvolution10);
            this.groupBox5.Controls.Add(this.tbConvolution00);
            this.groupBox5.Controls.Add(this.btnPointOp);
            this.groupBox5.Controls.Add(this.btnHistogram);
            this.groupBox5.Controls.Add(this.tbThresholding);
            this.groupBox5.Controls.Add(this.rbConvolution);
            this.groupBox5.Controls.Add(this.rbQuantiation);
            this.groupBox5.Controls.Add(this.rbLogarithmOperator);
            this.groupBox5.Controls.Add(this.rbHistogramEq);
            this.groupBox5.Controls.Add(this.rbNormalization);
            this.groupBox5.Controls.Add(this.rbAdaptiveThresholding);
            this.groupBox5.Controls.Add(this.rbThresholding);
            this.groupBox5.Controls.Add(this.lblThresholdingValue);
            this.groupBox5.Controls.Add(this.trackBarThresholding);
            this.groupBox5.Location = new System.Drawing.Point(775, 382);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(288, 232);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Point Operators";
            // 
            // cbAdaptiveThresMatrix
            // 
            this.cbAdaptiveThresMatrix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdaptiveThresMatrix.Enabled = false;
            this.cbAdaptiveThresMatrix.FormattingEnabled = true;
            this.cbAdaptiveThresMatrix.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "17",
            "19"});
            this.cbAdaptiveThresMatrix.Location = new System.Drawing.Point(124, 58);
            this.cbAdaptiveThresMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.cbAdaptiveThresMatrix.Name = "cbAdaptiveThresMatrix";
            this.cbAdaptiveThresMatrix.Size = new System.Drawing.Size(54, 21);
            this.cbAdaptiveThresMatrix.TabIndex = 1;
            // 
            // tbQuantization
            // 
            this.tbQuantization.Enabled = false;
            this.tbQuantization.Location = new System.Drawing.Point(138, 137);
            this.tbQuantization.Name = "tbQuantization";
            this.tbQuantization.Size = new System.Drawing.Size(38, 20);
            this.tbQuantization.TabIndex = 4;
            this.tbQuantization.ValueChanged += new System.EventHandler(this.tbTransX_ValueChanged);
            // 
            // cbAdaptiveThres
            // 
            this.cbAdaptiveThres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdaptiveThres.Enabled = false;
            this.cbAdaptiveThres.FormattingEnabled = true;
            this.cbAdaptiveThres.Items.AddRange(new object[] {
            "Mean",
            "Median",
            "(Min+Max)/2"});
            this.cbAdaptiveThres.Location = new System.Drawing.Point(11, 58);
            this.cbAdaptiveThres.Margin = new System.Windows.Forms.Padding(2);
            this.cbAdaptiveThres.Name = "cbAdaptiveThres";
            this.cbAdaptiveThres.Size = new System.Drawing.Size(109, 21);
            this.cbAdaptiveThres.TabIndex = 1;
            // 
            // tbConvolution22
            // 
            this.tbConvolution22.Location = new System.Drawing.Point(244, 168);
            this.tbConvolution22.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution22.Name = "tbConvolution22";
            this.tbConvolution22.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution22.TabIndex = 0;
            // 
            // tbConvolution12
            // 
            this.tbConvolution12.Location = new System.Drawing.Point(244, 150);
            this.tbConvolution12.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution12.Name = "tbConvolution12";
            this.tbConvolution12.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution12.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Interval";
            // 
            // tbConvolution02
            // 
            this.tbConvolution02.Location = new System.Drawing.Point(244, 132);
            this.tbConvolution02.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution02.Name = "tbConvolution02";
            this.tbConvolution02.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution02.TabIndex = 0;
            // 
            // tbConvolution21
            // 
            this.tbConvolution21.Location = new System.Drawing.Point(221, 168);
            this.tbConvolution21.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution21.Name = "tbConvolution21";
            this.tbConvolution21.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution21.TabIndex = 0;
            // 
            // tbConvolution11
            // 
            this.tbConvolution11.Location = new System.Drawing.Point(221, 150);
            this.tbConvolution11.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution11.Name = "tbConvolution11";
            this.tbConvolution11.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution11.TabIndex = 0;
            // 
            // tbConvolution01
            // 
            this.tbConvolution01.Location = new System.Drawing.Point(221, 132);
            this.tbConvolution01.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution01.Name = "tbConvolution01";
            this.tbConvolution01.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution01.TabIndex = 0;
            // 
            // tbConvolution20
            // 
            this.tbConvolution20.Location = new System.Drawing.Point(198, 168);
            this.tbConvolution20.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution20.Name = "tbConvolution20";
            this.tbConvolution20.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution20.TabIndex = 0;
            // 
            // tbConvolution10
            // 
            this.tbConvolution10.Location = new System.Drawing.Point(198, 150);
            this.tbConvolution10.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution10.Name = "tbConvolution10";
            this.tbConvolution10.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution10.TabIndex = 0;
            // 
            // tbConvolution00
            // 
            this.tbConvolution00.Location = new System.Drawing.Point(198, 132);
            this.tbConvolution00.Margin = new System.Windows.Forms.Padding(2);
            this.tbConvolution00.Name = "tbConvolution00";
            this.tbConvolution00.Size = new System.Drawing.Size(24, 20);
            this.tbConvolution00.TabIndex = 0;
            // 
            // btnPointOp
            // 
            this.btnPointOp.Location = new System.Drawing.Point(198, 71);
            this.btnPointOp.Margin = new System.Windows.Forms.Padding(2);
            this.btnPointOp.Name = "btnPointOp";
            this.btnPointOp.Size = new System.Drawing.Size(72, 41);
            this.btnPointOp.TabIndex = 2;
            this.btnPointOp.Text = "Apply";
            this.btnPointOp.UseVisualStyleBackColor = true;
            this.btnPointOp.Click += new System.EventHandler(this.btnPointOp_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.Location = new System.Drawing.Point(198, 21);
            this.btnHistogram.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(72, 41);
            this.btnHistogram.TabIndex = 2;
            this.btnHistogram.Text = "Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // tbThresholding
            // 
            this.tbThresholding.Enabled = false;
            this.tbThresholding.Location = new System.Drawing.Point(87, 18);
            this.tbThresholding.Margin = new System.Windows.Forms.Padding(2);
            this.tbThresholding.Name = "tbThresholding";
            this.tbThresholding.Size = new System.Drawing.Size(26, 20);
            this.tbThresholding.TabIndex = 1;
            this.tbThresholding.Text = "100";
            this.tbThresholding.TextChanged += new System.EventHandler(this.tbThresholding_TextChanged);
            // 
            // rbConvolution
            // 
            this.rbConvolution.AutoSize = true;
            this.rbConvolution.Location = new System.Drawing.Point(9, 159);
            this.rbConvolution.Margin = new System.Windows.Forms.Padding(2);
            this.rbConvolution.Name = "rbConvolution";
            this.rbConvolution.Size = new System.Drawing.Size(81, 17);
            this.rbConvolution.TabIndex = 0;
            this.rbConvolution.Text = "Convolution";
            this.rbConvolution.UseVisualStyleBackColor = true;
            this.rbConvolution.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbQuantiation
            // 
            this.rbQuantiation.AutoSize = true;
            this.rbQuantiation.Location = new System.Drawing.Point(8, 138);
            this.rbQuantiation.Margin = new System.Windows.Forms.Padding(2);
            this.rbQuantiation.Name = "rbQuantiation";
            this.rbQuantiation.Size = new System.Drawing.Size(84, 17);
            this.rbQuantiation.TabIndex = 0;
            this.rbQuantiation.Text = "Quantization";
            this.rbQuantiation.UseVisualStyleBackColor = true;
            this.rbQuantiation.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbLogarithmOperator
            // 
            this.rbLogarithmOperator.AutoSize = true;
            this.rbLogarithmOperator.Location = new System.Drawing.Point(7, 117);
            this.rbLogarithmOperator.Margin = new System.Windows.Forms.Padding(2);
            this.rbLogarithmOperator.Name = "rbLogarithmOperator";
            this.rbLogarithmOperator.Size = new System.Drawing.Size(115, 17);
            this.rbLogarithmOperator.TabIndex = 0;
            this.rbLogarithmOperator.Text = "Logarithm Operator";
            this.rbLogarithmOperator.UseVisualStyleBackColor = true;
            this.rbLogarithmOperator.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbHistogramEq
            // 
            this.rbHistogramEq.AutoSize = true;
            this.rbHistogramEq.Location = new System.Drawing.Point(7, 101);
            this.rbHistogramEq.Margin = new System.Windows.Forms.Padding(2);
            this.rbHistogramEq.Name = "rbHistogramEq";
            this.rbHistogramEq.Size = new System.Drawing.Size(132, 17);
            this.rbHistogramEq.TabIndex = 0;
            this.rbHistogramEq.Text = "Histogram Equalization";
            this.rbHistogramEq.UseVisualStyleBackColor = true;
            this.rbHistogramEq.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbNormalization
            // 
            this.rbNormalization.AutoSize = true;
            this.rbNormalization.Location = new System.Drawing.Point(6, 83);
            this.rbNormalization.Margin = new System.Windows.Forms.Padding(2);
            this.rbNormalization.Name = "rbNormalization";
            this.rbNormalization.Size = new System.Drawing.Size(88, 17);
            this.rbNormalization.TabIndex = 0;
            this.rbNormalization.Text = "Normalization";
            this.rbNormalization.UseVisualStyleBackColor = true;
            this.rbNormalization.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbAdaptiveThresholding
            // 
            this.rbAdaptiveThresholding.AutoSize = true;
            this.rbAdaptiveThresholding.Location = new System.Drawing.Point(5, 40);
            this.rbAdaptiveThresholding.Margin = new System.Windows.Forms.Padding(2);
            this.rbAdaptiveThresholding.Name = "rbAdaptiveThresholding";
            this.rbAdaptiveThresholding.Size = new System.Drawing.Size(131, 17);
            this.rbAdaptiveThresholding.TabIndex = 0;
            this.rbAdaptiveThresholding.Text = "Adaptive Thresholding";
            this.rbAdaptiveThresholding.UseVisualStyleBackColor = true;
            this.rbAdaptiveThresholding.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbThresholding
            // 
            this.rbThresholding.AutoSize = true;
            this.rbThresholding.Location = new System.Drawing.Point(5, 18);
            this.rbThresholding.Margin = new System.Windows.Forms.Padding(2);
            this.rbThresholding.Name = "rbThresholding";
            this.rbThresholding.Size = new System.Drawing.Size(86, 17);
            this.rbThresholding.TabIndex = 0;
            this.rbThresholding.Text = "Thresholding";
            this.rbThresholding.UseVisualStyleBackColor = true;
            this.rbThresholding.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // lblThresholdingValue
            // 
            this.lblThresholdingValue.AutoSize = true;
            this.lblThresholdingValue.Location = new System.Drawing.Point(194, 20);
            this.lblThresholdingValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThresholdingValue.Name = "lblThresholdingValue";
            this.lblThresholdingValue.Size = new System.Drawing.Size(0, 13);
            this.lblThresholdingValue.TabIndex = 9;
            // 
            // trackBarThresholding
            // 
            this.trackBarThresholding.AutoSize = false;
            this.trackBarThresholding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarThresholding.Enabled = false;
            this.trackBarThresholding.LargeChange = 20;
            this.trackBarThresholding.Location = new System.Drawing.Point(108, 20);
            this.trackBarThresholding.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarThresholding.Maximum = 255;
            this.trackBarThresholding.Name = "trackBarThresholding";
            this.trackBarThresholding.Size = new System.Drawing.Size(82, 17);
            this.trackBarThresholding.TabIndex = 3;
            this.trackBarThresholding.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThresholding.ValueChanged += new System.EventHandler(this.trackPointOperators_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbScalingFactor);
            this.groupBox6.Controls.Add(this.tbTransY);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.tbTransX);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lblReflectionAng);
            this.groupBox6.Controls.Add(this.lblRotationAng);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.cbScalingMethod);
            this.groupBox6.Controls.Add(this.cbReflection);
            this.groupBox6.Controls.Add(this.trackBarReflection);
            this.groupBox6.Controls.Add(this.cbRotation);
            this.groupBox6.Controls.Add(this.rbTranslation);
            this.groupBox6.Controls.Add(this.trackBarRotation);
            this.groupBox6.Controls.Add(this.rbReflection);
            this.groupBox6.Controls.Add(this.cbScaling);
            this.groupBox6.Controls.Add(this.rbRotation);
            this.groupBox6.Controls.Add(this.rbScaling);
            this.groupBox6.Location = new System.Drawing.Point(1088, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 212);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Geometric Operations";
            // 
            // tbScalingFactor
            // 
            this.tbScalingFactor.Enabled = false;
            this.tbScalingFactor.Location = new System.Drawing.Point(135, 17);
            this.tbScalingFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbScalingFactor.Name = "tbScalingFactor";
            this.tbScalingFactor.Size = new System.Drawing.Size(38, 20);
            this.tbScalingFactor.TabIndex = 4;
            this.tbScalingFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbScalingFactor.ValueChanged += new System.EventHandler(this.tbScalingFactor_ValueChanged);
            // 
            // tbTransY
            // 
            this.tbTransY.Enabled = false;
            this.tbTransY.Location = new System.Drawing.Point(142, 178);
            this.tbTransY.Name = "tbTransY";
            this.tbTransY.Size = new System.Drawing.Size(38, 20);
            this.tbTransY.TabIndex = 4;
            this.tbTransY.ValueChanged += new System.EventHandler(this.tbTransX_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Beta(Y):";
            // 
            // tbTransX
            // 
            this.tbTransX.Enabled = false;
            this.tbTransX.Location = new System.Drawing.Point(50, 179);
            this.tbTransX.Name = "tbTransX";
            this.tbTransX.Size = new System.Drawing.Size(36, 20);
            this.tbTransX.TabIndex = 4;
            this.tbTransX.ValueChanged += new System.EventHandler(this.tbTransX_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Beta(X):";
            // 
            // lblReflectionAng
            // 
            this.lblReflectionAng.AutoSize = true;
            this.lblReflectionAng.Location = new System.Drawing.Point(120, 125);
            this.lblReflectionAng.Name = "lblReflectionAng";
            this.lblReflectionAng.Size = new System.Drawing.Size(46, 13);
            this.lblReflectionAng.TabIndex = 2;
            this.lblReflectionAng.Text = "Angle: 0";
            // 
            // lblRotationAng
            // 
            this.lblRotationAng.AutoSize = true;
            this.lblRotationAng.Location = new System.Drawing.Point(121, 79);
            this.lblRotationAng.Name = "lblRotationAng";
            this.lblRotationAng.Size = new System.Drawing.Size(46, 13);
            this.lblRotationAng.TabIndex = 2;
            this.lblRotationAng.Text = "Angle: 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Factor:";
            // 
            // cbScalingMethod
            // 
            this.cbScalingMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScalingMethod.Enabled = false;
            this.cbScalingMethod.FormattingEnabled = true;
            this.cbScalingMethod.Items.AddRange(new object[] {
            "Replacement",
            "Interpolation",
            "Replication"});
            this.cbScalingMethod.Location = new System.Drawing.Point(95, 41);
            this.cbScalingMethod.Margin = new System.Windows.Forms.Padding(2);
            this.cbScalingMethod.Name = "cbScalingMethod";
            this.cbScalingMethod.Size = new System.Drawing.Size(91, 21);
            this.cbScalingMethod.TabIndex = 1;
            // 
            // cbReflection
            // 
            this.cbReflection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReflection.Enabled = false;
            this.cbReflection.FormattingEnabled = true;
            this.cbReflection.Items.AddRange(new object[] {
            "Y Axis",
            "X Axis",
            "Both Axis",
            "Angle"});
            this.cbReflection.Location = new System.Drawing.Point(6, 136);
            this.cbReflection.Margin = new System.Windows.Forms.Padding(2);
            this.cbReflection.Name = "cbReflection";
            this.cbReflection.Size = new System.Drawing.Size(109, 21);
            this.cbReflection.TabIndex = 1;
            // 
            // trackBarReflection
            // 
            this.trackBarReflection.AutoSize = false;
            this.trackBarReflection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarReflection.Enabled = false;
            this.trackBarReflection.LargeChange = 20;
            this.trackBarReflection.Location = new System.Drawing.Point(113, 140);
            this.trackBarReflection.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarReflection.Maximum = 180;
            this.trackBarReflection.Name = "trackBarReflection";
            this.trackBarReflection.Size = new System.Drawing.Size(77, 17);
            this.trackBarReflection.TabIndex = 3;
            this.trackBarReflection.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarReflection.Scroll += new System.EventHandler(this.trackBarReflection_Scroll);
            // 
            // cbRotation
            // 
            this.cbRotation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRotation.Enabled = false;
            this.cbRotation.FormattingEnabled = true;
            this.cbRotation.Items.AddRange(new object[] {
            "With Alias",
            "Without Alias"});
            this.cbRotation.Location = new System.Drawing.Point(5, 90);
            this.cbRotation.Margin = new System.Windows.Forms.Padding(2);
            this.cbRotation.Name = "cbRotation";
            this.cbRotation.Size = new System.Drawing.Size(109, 21);
            this.cbRotation.TabIndex = 1;
            // 
            // rbTranslation
            // 
            this.rbTranslation.AutoSize = true;
            this.rbTranslation.Location = new System.Drawing.Point(5, 161);
            this.rbTranslation.Margin = new System.Windows.Forms.Padding(2);
            this.rbTranslation.Name = "rbTranslation";
            this.rbTranslation.Size = new System.Drawing.Size(77, 17);
            this.rbTranslation.TabIndex = 0;
            this.rbTranslation.Text = "Translation";
            this.rbTranslation.UseVisualStyleBackColor = true;
            this.rbTranslation.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // trackBarRotation
            // 
            this.trackBarRotation.AutoSize = false;
            this.trackBarRotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarRotation.Enabled = false;
            this.trackBarRotation.LargeChange = 20;
            this.trackBarRotation.Location = new System.Drawing.Point(112, 94);
            this.trackBarRotation.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarRotation.Maximum = 180;
            this.trackBarRotation.Name = "trackBarRotation";
            this.trackBarRotation.Size = new System.Drawing.Size(77, 17);
            this.trackBarRotation.TabIndex = 3;
            this.trackBarRotation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRotation.Scroll += new System.EventHandler(this.trackBarRotation_Scroll);
            // 
            // rbReflection
            // 
            this.rbReflection.AutoSize = true;
            this.rbReflection.Location = new System.Drawing.Point(5, 115);
            this.rbReflection.Margin = new System.Windows.Forms.Padding(2);
            this.rbReflection.Name = "rbReflection";
            this.rbReflection.Size = new System.Drawing.Size(73, 17);
            this.rbReflection.TabIndex = 0;
            this.rbReflection.Text = "Reflection";
            this.rbReflection.UseVisualStyleBackColor = true;
            this.rbReflection.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // cbScaling
            // 
            this.cbScaling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbScaling.Enabled = false;
            this.cbScaling.FormattingEnabled = true;
            this.cbScaling.Items.AddRange(new object[] {
            "Zoom Out",
            "Zoom In"});
            this.cbScaling.Location = new System.Drawing.Point(5, 41);
            this.cbScaling.Margin = new System.Windows.Forms.Padding(2);
            this.cbScaling.Name = "cbScaling";
            this.cbScaling.Size = new System.Drawing.Size(89, 21);
            this.cbScaling.TabIndex = 1;
            this.cbScaling.SelectedIndexChanged += new System.EventHandler(this.cbScaling_SelectedIndexChanged);
            // 
            // rbRotation
            // 
            this.rbRotation.AutoSize = true;
            this.rbRotation.Location = new System.Drawing.Point(5, 69);
            this.rbRotation.Margin = new System.Windows.Forms.Padding(2);
            this.rbRotation.Name = "rbRotation";
            this.rbRotation.Size = new System.Drawing.Size(65, 17);
            this.rbRotation.TabIndex = 0;
            this.rbRotation.Text = "Rotation";
            this.rbRotation.UseVisualStyleBackColor = true;
            this.rbRotation.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbScaling
            // 
            this.rbScaling.AutoSize = true;
            this.rbScaling.Location = new System.Drawing.Point(5, 18);
            this.rbScaling.Margin = new System.Windows.Forms.Padding(2);
            this.rbScaling.Name = "rbScaling";
            this.rbScaling.Size = new System.Drawing.Size(60, 17);
            this.rbScaling.TabIndex = 0;
            this.rbScaling.Text = "Scaling";
            this.rbScaling.UseVisualStyleBackColor = true;
            this.rbScaling.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbNOT);
            this.groupBox7.Controls.Add(this.btnLogicOperator);
            this.groupBox7.Controls.Add(this.rbXNOR);
            this.groupBox7.Controls.Add(this.rbNOR);
            this.groupBox7.Controls.Add(this.rbNAND);
            this.groupBox7.Controls.Add(this.rbXOR);
            this.groupBox7.Controls.Add(this.rbOR);
            this.groupBox7.Controls.Add(this.rbAND);
            this.groupBox7.Location = new System.Drawing.Point(1088, 514);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(217, 100);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Logic Operators";
            // 
            // rbNOT
            // 
            this.rbNOT.AutoSize = true;
            this.rbNOT.Location = new System.Drawing.Point(5, 58);
            this.rbNOT.Margin = new System.Windows.Forms.Padding(2);
            this.rbNOT.Name = "rbNOT";
            this.rbNOT.Size = new System.Drawing.Size(48, 17);
            this.rbNOT.TabIndex = 0;
            this.rbNOT.Text = "NOT";
            this.rbNOT.UseVisualStyleBackColor = true;
            this.rbNOT.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // btnLogicOperator
            // 
            this.btnLogicOperator.Location = new System.Drawing.Point(142, 58);
            this.btnLogicOperator.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogicOperator.Name = "btnLogicOperator";
            this.btnLogicOperator.Size = new System.Drawing.Size(64, 26);
            this.btnLogicOperator.TabIndex = 2;
            this.btnLogicOperator.Text = "Apply";
            this.btnLogicOperator.UseVisualStyleBackColor = true;
            this.btnLogicOperator.Click += new System.EventHandler(this.btnLogicOperator_Click);
            // 
            // rbXNOR
            // 
            this.rbXNOR.AutoSize = true;
            this.rbXNOR.Location = new System.Drawing.Point(122, 37);
            this.rbXNOR.Margin = new System.Windows.Forms.Padding(2);
            this.rbXNOR.Name = "rbXNOR";
            this.rbXNOR.Size = new System.Drawing.Size(56, 17);
            this.rbXNOR.TabIndex = 0;
            this.rbXNOR.Text = "XNOR";
            this.rbXNOR.UseVisualStyleBackColor = true;
            this.rbXNOR.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbNOR
            // 
            this.rbNOR.AutoSize = true;
            this.rbNOR.Location = new System.Drawing.Point(70, 37);
            this.rbNOR.Margin = new System.Windows.Forms.Padding(2);
            this.rbNOR.Name = "rbNOR";
            this.rbNOR.Size = new System.Drawing.Size(49, 17);
            this.rbNOR.TabIndex = 0;
            this.rbNOR.Text = "NOR";
            this.rbNOR.UseVisualStyleBackColor = true;
            this.rbNOR.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbNAND
            // 
            this.rbNAND.AutoSize = true;
            this.rbNAND.Location = new System.Drawing.Point(5, 37);
            this.rbNAND.Margin = new System.Windows.Forms.Padding(2);
            this.rbNAND.Name = "rbNAND";
            this.rbNAND.Size = new System.Drawing.Size(56, 17);
            this.rbNAND.TabIndex = 0;
            this.rbNAND.Text = "NAND";
            this.rbNAND.UseVisualStyleBackColor = true;
            this.rbNAND.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbXOR
            // 
            this.rbXOR.AutoSize = true;
            this.rbXOR.Location = new System.Drawing.Point(122, 18);
            this.rbXOR.Margin = new System.Windows.Forms.Padding(2);
            this.rbXOR.Name = "rbXOR";
            this.rbXOR.Size = new System.Drawing.Size(48, 17);
            this.rbXOR.TabIndex = 0;
            this.rbXOR.Text = "XOR";
            this.rbXOR.UseVisualStyleBackColor = true;
            this.rbXOR.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbOR
            // 
            this.rbOR.AutoSize = true;
            this.rbOR.Location = new System.Drawing.Point(70, 18);
            this.rbOR.Margin = new System.Windows.Forms.Padding(2);
            this.rbOR.Name = "rbOR";
            this.rbOR.Size = new System.Drawing.Size(41, 17);
            this.rbOR.TabIndex = 0;
            this.rbOR.Text = "OR";
            this.rbOR.UseVisualStyleBackColor = true;
            this.rbOR.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbAND
            // 
            this.rbAND.AutoSize = true;
            this.rbAND.Location = new System.Drawing.Point(5, 18);
            this.rbAND.Margin = new System.Windows.Forms.Padding(2);
            this.rbAND.Name = "rbAND";
            this.rbAND.Size = new System.Drawing.Size(48, 17);
            this.rbAND.TabIndex = 0;
            this.rbAND.Text = "AND";
            this.rbAND.UseVisualStyleBackColor = true;
            this.rbAND.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.gbGausMatrix);
            this.groupBox9.Controls.Add(this.rbUnsharpFilter);
            this.groupBox9.Controls.Add(this.rbGaussianSmoothing);
            this.groupBox9.Controls.Add(this.rbCrimminsSpeckleRemoval);
            this.groupBox9.Controls.Add(this.tbUnsharpScaling);
            this.groupBox9.Controls.Add(this.tbCrimmins);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label1);
            this.groupBox9.Controls.Add(this.rbConservativeSmoothing);
            this.groupBox9.Controls.Add(this.btnDigitalFilters);
            this.groupBox9.Controls.Add(this.rbMedian);
            this.groupBox9.Controls.Add(this.rbMean);
            this.groupBox9.Controls.Add(this.cbUnsharpFilter);
            this.groupBox9.Controls.Add(this.cbConservativeSmoothing);
            this.groupBox9.Controls.Add(this.cbMedian);
            this.groupBox9.Controls.Add(this.cbMean);
            this.groupBox9.Location = new System.Drawing.Point(1088, 228);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(217, 280);
            this.groupBox9.TabIndex = 4;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Digital Filters";
            // 
            // gbGausMatrix
            // 
            this.gbGausMatrix.Controls.Add(this.textBox7);
            this.gbGausMatrix.Controls.Add(this.textBox1);
            this.gbGausMatrix.Controls.Add(this.textBox2);
            this.gbGausMatrix.Controls.Add(this.textBox9);
            this.gbGausMatrix.Controls.Add(this.textBox3);
            this.gbGausMatrix.Controls.Add(this.textBox4);
            this.gbGausMatrix.Controls.Add(this.textBox8);
            this.gbGausMatrix.Controls.Add(this.textBox5);
            this.gbGausMatrix.Controls.Add(this.textBox6);
            this.gbGausMatrix.Enabled = false;
            this.gbGausMatrix.Location = new System.Drawing.Point(124, 204);
            this.gbGausMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.gbGausMatrix.Name = "gbGausMatrix";
            this.gbGausMatrix.Padding = new System.Windows.Forms.Padding(0);
            this.gbGausMatrix.Size = new System.Drawing.Size(71, 62);
            this.gbGausMatrix.TabIndex = 5;
            this.gbGausMatrix.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(46, 5);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(24, 20);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 23);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "2";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(46, 41);
            this.textBox9.Margin = new System.Windows.Forms.Padding(0);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(24, 20);
            this.textBox9.TabIndex = 0;
            this.textBox9.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 41);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(24, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 5);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(24, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "2";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(46, 23);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(24, 20);
            this.textBox8.TabIndex = 0;
            this.textBox8.Text = "2";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(23, 23);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(24, 20);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "4";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(23, 41);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(24, 20);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "2";
            // 
            // rbUnsharpFilter
            // 
            this.rbUnsharpFilter.AutoSize = true;
            this.rbUnsharpFilter.Location = new System.Drawing.Point(5, 160);
            this.rbUnsharpFilter.Margin = new System.Windows.Forms.Padding(2);
            this.rbUnsharpFilter.Name = "rbUnsharpFilter";
            this.rbUnsharpFilter.Size = new System.Drawing.Size(90, 17);
            this.rbUnsharpFilter.TabIndex = 0;
            this.rbUnsharpFilter.Text = "Unsharp Filter";
            this.rbUnsharpFilter.UseVisualStyleBackColor = true;
            this.rbUnsharpFilter.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbGaussianSmoothing
            // 
            this.rbGaussianSmoothing.AutoSize = true;
            this.rbGaussianSmoothing.Location = new System.Drawing.Point(6, 135);
            this.rbGaussianSmoothing.Margin = new System.Windows.Forms.Padding(2);
            this.rbGaussianSmoothing.Name = "rbGaussianSmoothing";
            this.rbGaussianSmoothing.Size = new System.Drawing.Size(122, 17);
            this.rbGaussianSmoothing.TabIndex = 0;
            this.rbGaussianSmoothing.Text = "Gaussian Smoothing";
            this.rbGaussianSmoothing.UseVisualStyleBackColor = true;
            this.rbGaussianSmoothing.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbCrimminsSpeckleRemoval
            // 
            this.rbCrimminsSpeckleRemoval.AutoSize = true;
            this.rbCrimminsSpeckleRemoval.Location = new System.Drawing.Point(6, 93);
            this.rbCrimminsSpeckleRemoval.Margin = new System.Windows.Forms.Padding(2);
            this.rbCrimminsSpeckleRemoval.Name = "rbCrimminsSpeckleRemoval";
            this.rbCrimminsSpeckleRemoval.Size = new System.Drawing.Size(153, 17);
            this.rbCrimminsSpeckleRemoval.TabIndex = 0;
            this.rbCrimminsSpeckleRemoval.Text = "Crimmins Speckle Removal";
            this.rbCrimminsSpeckleRemoval.UseVisualStyleBackColor = true;
            this.rbCrimminsSpeckleRemoval.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbUnsharpScaling
            // 
            this.tbUnsharpScaling.DecimalPlaces = 1;
            this.tbUnsharpScaling.Enabled = false;
            this.tbUnsharpScaling.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.tbUnsharpScaling.Location = new System.Drawing.Point(61, 187);
            this.tbUnsharpScaling.Name = "tbUnsharpScaling";
            this.tbUnsharpScaling.Size = new System.Drawing.Size(48, 20);
            this.tbUnsharpScaling.TabIndex = 4;
            // 
            // tbCrimmins
            // 
            this.tbCrimmins.Enabled = false;
            this.tbCrimmins.Location = new System.Drawing.Point(118, 110);
            this.tbCrimmins.Name = "tbCrimmins";
            this.tbCrimmins.Size = new System.Drawing.Size(38, 20);
            this.tbCrimmins.TabIndex = 4;
            this.tbCrimmins.ValueChanged += new System.EventHandler(this.cbMean_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Scaling:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iteration:";
            // 
            // rbConservativeSmoothing
            // 
            this.rbConservativeSmoothing.AutoSize = true;
            this.rbConservativeSmoothing.Location = new System.Drawing.Point(6, 68);
            this.rbConservativeSmoothing.Margin = new System.Windows.Forms.Padding(2);
            this.rbConservativeSmoothing.Name = "rbConservativeSmoothing";
            this.rbConservativeSmoothing.Size = new System.Drawing.Size(140, 17);
            this.rbConservativeSmoothing.TabIndex = 0;
            this.rbConservativeSmoothing.Text = "Conservative Smoothing";
            this.rbConservativeSmoothing.UseVisualStyleBackColor = true;
            this.rbConservativeSmoothing.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // btnDigitalFilters
            // 
            this.btnDigitalFilters.Location = new System.Drawing.Point(16, 225);
            this.btnDigitalFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnDigitalFilters.Name = "btnDigitalFilters";
            this.btnDigitalFilters.Size = new System.Drawing.Size(78, 41);
            this.btnDigitalFilters.TabIndex = 2;
            this.btnDigitalFilters.Text = "Apply";
            this.btnDigitalFilters.UseVisualStyleBackColor = true;
            this.btnDigitalFilters.Click += new System.EventHandler(this.btnDigitalFilters_Click);
            // 
            // rbMedian
            // 
            this.rbMedian.AutoSize = true;
            this.rbMedian.Location = new System.Drawing.Point(6, 43);
            this.rbMedian.Margin = new System.Windows.Forms.Padding(2);
            this.rbMedian.Name = "rbMedian";
            this.rbMedian.Size = new System.Drawing.Size(60, 17);
            this.rbMedian.TabIndex = 0;
            this.rbMedian.Text = "Median";
            this.rbMedian.UseVisualStyleBackColor = true;
            this.rbMedian.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // rbMean
            // 
            this.rbMean.AutoSize = true;
            this.rbMean.Location = new System.Drawing.Point(6, 18);
            this.rbMean.Margin = new System.Windows.Forms.Padding(2);
            this.rbMean.Name = "rbMean";
            this.rbMean.Size = new System.Drawing.Size(52, 17);
            this.rbMean.TabIndex = 0;
            this.rbMean.Text = "Mean";
            this.rbMean.UseVisualStyleBackColor = true;
            this.rbMean.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // cbUnsharpFilter
            // 
            this.cbUnsharpFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnsharpFilter.Enabled = false;
            this.cbUnsharpFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbUnsharpFilter.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13"});
            this.cbUnsharpFilter.Location = new System.Drawing.Point(131, 159);
            this.cbUnsharpFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnsharpFilter.Name = "cbUnsharpFilter";
            this.cbUnsharpFilter.Size = new System.Drawing.Size(38, 21);
            this.cbUnsharpFilter.TabIndex = 1;
            // 
            // cbConservativeSmoothing
            // 
            this.cbConservativeSmoothing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConservativeSmoothing.Enabled = false;
            this.cbConservativeSmoothing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbConservativeSmoothing.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13"});
            this.cbConservativeSmoothing.Location = new System.Drawing.Point(154, 68);
            this.cbConservativeSmoothing.Margin = new System.Windows.Forms.Padding(2);
            this.cbConservativeSmoothing.Name = "cbConservativeSmoothing";
            this.cbConservativeSmoothing.Size = new System.Drawing.Size(38, 21);
            this.cbConservativeSmoothing.TabIndex = 1;
            this.cbConservativeSmoothing.SelectedIndexChanged += new System.EventHandler(this.cbMean_SelectedIndexChanged);
            // 
            // cbMedian
            // 
            this.cbMedian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedian.Enabled = false;
            this.cbMedian.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMedian.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13"});
            this.cbMedian.Location = new System.Drawing.Point(118, 37);
            this.cbMedian.Margin = new System.Windows.Forms.Padding(2);
            this.cbMedian.Name = "cbMedian";
            this.cbMedian.Size = new System.Drawing.Size(38, 21);
            this.cbMedian.TabIndex = 1;
            this.cbMedian.SelectedIndexChanged += new System.EventHandler(this.cbMean_SelectedIndexChanged);
            // 
            // cbMean
            // 
            this.cbMean.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMean.Enabled = false;
            this.cbMean.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMean.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13"});
            this.cbMean.Location = new System.Drawing.Point(118, 12);
            this.cbMean.Margin = new System.Windows.Forms.Padding(2);
            this.cbMean.Name = "cbMean";
            this.cbMean.Size = new System.Drawing.Size(38, 21);
            this.cbMean.TabIndex = 1;
            this.cbMean.SelectedIndexChanged += new System.EventHandler(this.cbMean_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.udEdgeDetectors2);
            this.groupBox8.Controls.Add(this.udEdgeDetectors1);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.tbDifferenceOfGaussian);
            this.groupBox8.Controls.Add(this.rbDifferenceOfGaussian);
            this.groupBox8.Controls.Add(this.tbLaplacianOfGaussaian);
            this.groupBox8.Controls.Add(this.rbLaplacianOfGaussaian);
            this.groupBox8.Controls.Add(this.tbLaplacian);
            this.groupBox8.Controls.Add(this.rbLaplacian);
            this.groupBox8.Controls.Add(this.tbScharr);
            this.groupBox8.Controls.Add(this.btnEdgeDetectors);
            this.groupBox8.Controls.Add(this.rbScharr);
            this.groupBox8.Controls.Add(this.tbRoberts);
            this.groupBox8.Controls.Add(this.rbRoberts);
            this.groupBox8.Controls.Add(this.tbPrewitt);
            this.groupBox8.Controls.Add(this.rbPrewitt);
            this.groupBox8.Controls.Add(this.tbSobel);
            this.groupBox8.Controls.Add(this.rbSobel);
            this.groupBox8.Location = new System.Drawing.Point(473, 15);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(247, 323);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Edge Detectors";
            // 
            // udEdgeDetectors2
            // 
            this.udEdgeDetectors2.Items.Add("Matrix 1");
            this.udEdgeDetectors2.Items.Add("Matrix 2");
            this.udEdgeDetectors2.Items.Add("Matrix 3");
            this.udEdgeDetectors2.Location = new System.Drawing.Point(88, 279);
            this.udEdgeDetectors2.Name = "udEdgeDetectors2";
            this.udEdgeDetectors2.ReadOnly = true;
            this.udEdgeDetectors2.Size = new System.Drawing.Size(71, 20);
            this.udEdgeDetectors2.TabIndex = 6;
            this.udEdgeDetectors2.SelectedItemChanged += new System.EventHandler(this.udEdgeDetectors2_SelectedItemChanged);
            // 
            // udEdgeDetectors1
            // 
            this.udEdgeDetectors1.Items.Add("Matrix 1");
            this.udEdgeDetectors1.Items.Add("Matrix 2");
            this.udEdgeDetectors1.Items.Add("Matrix 3");
            this.udEdgeDetectors1.Location = new System.Drawing.Point(18, 279);
            this.udEdgeDetectors1.Name = "udEdgeDetectors1";
            this.udEdgeDetectors1.ReadOnly = true;
            this.udEdgeDetectors1.Size = new System.Drawing.Size(71, 20);
            this.udEdgeDetectors1.TabIndex = 6;
            this.udEdgeDetectors1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBox19);
            this.groupBox11.Controls.Add(this.textBox20);
            this.groupBox11.Controls.Add(this.textBox21);
            this.groupBox11.Controls.Add(this.textBox22);
            this.groupBox11.Controls.Add(this.textBox23);
            this.groupBox11.Controls.Add(this.textBox24);
            this.groupBox11.Controls.Add(this.textBox25);
            this.groupBox11.Controls.Add(this.textBox26);
            this.groupBox11.Controls.Add(this.textBox27);
            this.groupBox11.Location = new System.Drawing.Point(89, 215);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox11.Size = new System.Drawing.Size(71, 61);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(46, 5);
            this.textBox19.Margin = new System.Windows.Forms.Padding(0);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(24, 20);
            this.textBox19.TabIndex = 0;
            this.textBox19.Text = "1";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(0, 5);
            this.textBox20.Margin = new System.Windows.Forms.Padding(0);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(24, 20);
            this.textBox20.TabIndex = 0;
            this.textBox20.Text = "1";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(0, 23);
            this.textBox21.Margin = new System.Windows.Forms.Padding(0);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(24, 20);
            this.textBox21.TabIndex = 0;
            this.textBox21.Text = "2";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(46, 41);
            this.textBox22.Margin = new System.Windows.Forms.Padding(0);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(24, 20);
            this.textBox22.TabIndex = 0;
            this.textBox22.Text = "1";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(0, 41);
            this.textBox23.Margin = new System.Windows.Forms.Padding(0);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(24, 20);
            this.textBox23.TabIndex = 0;
            this.textBox23.Text = "1";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(23, 5);
            this.textBox24.Margin = new System.Windows.Forms.Padding(0);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(24, 20);
            this.textBox24.TabIndex = 0;
            this.textBox24.Text = "2";
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(46, 23);
            this.textBox25.Margin = new System.Windows.Forms.Padding(0);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(24, 20);
            this.textBox25.TabIndex = 0;
            this.textBox25.Text = "2";
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(23, 23);
            this.textBox26.Margin = new System.Windows.Forms.Padding(0);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(24, 20);
            this.textBox26.TabIndex = 0;
            this.textBox26.Text = "4";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(23, 41);
            this.textBox27.Margin = new System.Windows.Forms.Padding(0);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(24, 20);
            this.textBox27.TabIndex = 0;
            this.textBox27.Text = "2";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox10);
            this.groupBox10.Controls.Add(this.textBox11);
            this.groupBox10.Controls.Add(this.textBox12);
            this.groupBox10.Controls.Add(this.textBox13);
            this.groupBox10.Controls.Add(this.textBox14);
            this.groupBox10.Controls.Add(this.textBox15);
            this.groupBox10.Controls.Add(this.textBox16);
            this.groupBox10.Controls.Add(this.textBox17);
            this.groupBox10.Controls.Add(this.textBox18);
            this.groupBox10.Location = new System.Drawing.Point(18, 215);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox10.Size = new System.Drawing.Size(71, 61);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(46, 5);
            this.textBox10.Margin = new System.Windows.Forms.Padding(0);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(24, 20);
            this.textBox10.TabIndex = 0;
            this.textBox10.Text = "1";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(0, 5);
            this.textBox11.Margin = new System.Windows.Forms.Padding(0);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(24, 20);
            this.textBox11.TabIndex = 0;
            this.textBox11.Text = "1";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(0, 23);
            this.textBox12.Margin = new System.Windows.Forms.Padding(0);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(24, 20);
            this.textBox12.TabIndex = 0;
            this.textBox12.Text = "2";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(46, 41);
            this.textBox13.Margin = new System.Windows.Forms.Padding(0);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(24, 20);
            this.textBox13.TabIndex = 0;
            this.textBox13.Text = "1";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(0, 41);
            this.textBox14.Margin = new System.Windows.Forms.Padding(0);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(24, 20);
            this.textBox14.TabIndex = 0;
            this.textBox14.Text = "1";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(23, 5);
            this.textBox15.Margin = new System.Windows.Forms.Padding(0);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(24, 20);
            this.textBox15.TabIndex = 0;
            this.textBox15.Text = "2";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(46, 23);
            this.textBox16.Margin = new System.Windows.Forms.Padding(0);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(24, 20);
            this.textBox16.TabIndex = 0;
            this.textBox16.Text = "2";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(23, 23);
            this.textBox17.Margin = new System.Windows.Forms.Padding(0);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(24, 20);
            this.textBox17.TabIndex = 0;
            this.textBox17.Text = "4";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(23, 41);
            this.textBox18.Margin = new System.Windows.Forms.Padding(0);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(24, 20);
            this.textBox18.TabIndex = 0;
            this.textBox18.Text = "2";
            // 
            // tbDifferenceOfGaussian
            // 
            this.tbDifferenceOfGaussian.Enabled = false;
            this.tbDifferenceOfGaussian.Location = new System.Drawing.Point(138, 188);
            this.tbDifferenceOfGaussian.Name = "tbDifferenceOfGaussian";
            this.tbDifferenceOfGaussian.Size = new System.Drawing.Size(100, 20);
            this.tbDifferenceOfGaussian.TabIndex = 1;
            // 
            // rbDifferenceOfGaussian
            // 
            this.rbDifferenceOfGaussian.AutoSize = true;
            this.rbDifferenceOfGaussian.Location = new System.Drawing.Point(6, 189);
            this.rbDifferenceOfGaussian.Name = "rbDifferenceOfGaussian";
            this.rbDifferenceOfGaussian.Size = new System.Drawing.Size(133, 17);
            this.rbDifferenceOfGaussian.TabIndex = 0;
            this.rbDifferenceOfGaussian.TabStop = true;
            this.rbDifferenceOfGaussian.Text = "Difference of Gaussian";
            this.rbDifferenceOfGaussian.UseVisualStyleBackColor = true;
            this.rbDifferenceOfGaussian.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbLaplacianOfGaussaian
            // 
            this.tbLaplacianOfGaussaian.Enabled = false;
            this.tbLaplacianOfGaussaian.Location = new System.Drawing.Point(138, 161);
            this.tbLaplacianOfGaussaian.Name = "tbLaplacianOfGaussaian";
            this.tbLaplacianOfGaussaian.Size = new System.Drawing.Size(100, 20);
            this.tbLaplacianOfGaussaian.TabIndex = 1;
            // 
            // rbLaplacianOfGaussaian
            // 
            this.rbLaplacianOfGaussaian.AutoSize = true;
            this.rbLaplacianOfGaussaian.Location = new System.Drawing.Point(6, 162);
            this.rbLaplacianOfGaussaian.Name = "rbLaplacianOfGaussaian";
            this.rbLaplacianOfGaussaian.Size = new System.Drawing.Size(136, 17);
            this.rbLaplacianOfGaussaian.TabIndex = 0;
            this.rbLaplacianOfGaussaian.TabStop = true;
            this.rbLaplacianOfGaussaian.Text = "Laplacian of Gaussaian";
            this.rbLaplacianOfGaussaian.UseVisualStyleBackColor = true;
            this.rbLaplacianOfGaussaian.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbLaplacian
            // 
            this.tbLaplacian.Enabled = false;
            this.tbLaplacian.Location = new System.Drawing.Point(138, 134);
            this.tbLaplacian.Name = "tbLaplacian";
            this.tbLaplacian.Size = new System.Drawing.Size(100, 20);
            this.tbLaplacian.TabIndex = 1;
            // 
            // rbLaplacian
            // 
            this.rbLaplacian.AutoSize = true;
            this.rbLaplacian.Location = new System.Drawing.Point(6, 135);
            this.rbLaplacian.Name = "rbLaplacian";
            this.rbLaplacian.Size = new System.Drawing.Size(71, 17);
            this.rbLaplacian.TabIndex = 0;
            this.rbLaplacian.TabStop = true;
            this.rbLaplacian.Text = "Laplacian";
            this.rbLaplacian.UseVisualStyleBackColor = true;
            this.rbLaplacian.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbScharr
            // 
            this.tbScharr.Enabled = false;
            this.tbScharr.Location = new System.Drawing.Point(138, 103);
            this.tbScharr.Name = "tbScharr";
            this.tbScharr.Size = new System.Drawing.Size(100, 20);
            this.tbScharr.TabIndex = 1;
            // 
            // btnEdgeDetectors
            // 
            this.btnEdgeDetectors.Location = new System.Drawing.Point(164, 258);
            this.btnEdgeDetectors.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdgeDetectors.Name = "btnEdgeDetectors";
            this.btnEdgeDetectors.Size = new System.Drawing.Size(78, 41);
            this.btnEdgeDetectors.TabIndex = 2;
            this.btnEdgeDetectors.Text = "Apply";
            this.btnEdgeDetectors.UseVisualStyleBackColor = true;
            this.btnEdgeDetectors.Click += new System.EventHandler(this.btnEdgeDetectors_Click);
            // 
            // rbScharr
            // 
            this.rbScharr.AutoSize = true;
            this.rbScharr.Location = new System.Drawing.Point(6, 104);
            this.rbScharr.Name = "rbScharr";
            this.rbScharr.Size = new System.Drawing.Size(56, 17);
            this.rbScharr.TabIndex = 0;
            this.rbScharr.TabStop = true;
            this.rbScharr.Text = "Scharr";
            this.rbScharr.UseVisualStyleBackColor = true;
            this.rbScharr.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbRoberts
            // 
            this.tbRoberts.Enabled = false;
            this.tbRoberts.Location = new System.Drawing.Point(138, 77);
            this.tbRoberts.Name = "tbRoberts";
            this.tbRoberts.Size = new System.Drawing.Size(100, 20);
            this.tbRoberts.TabIndex = 1;
            // 
            // rbRoberts
            // 
            this.rbRoberts.AutoSize = true;
            this.rbRoberts.Location = new System.Drawing.Point(6, 78);
            this.rbRoberts.Name = "rbRoberts";
            this.rbRoberts.Size = new System.Drawing.Size(62, 17);
            this.rbRoberts.TabIndex = 0;
            this.rbRoberts.TabStop = true;
            this.rbRoberts.Text = "Roberts";
            this.rbRoberts.UseVisualStyleBackColor = true;
            this.rbRoberts.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbPrewitt
            // 
            this.tbPrewitt.Enabled = false;
            this.tbPrewitt.Location = new System.Drawing.Point(138, 50);
            this.tbPrewitt.Name = "tbPrewitt";
            this.tbPrewitt.Size = new System.Drawing.Size(100, 20);
            this.tbPrewitt.TabIndex = 1;
            // 
            // rbPrewitt
            // 
            this.rbPrewitt.AutoSize = true;
            this.rbPrewitt.Location = new System.Drawing.Point(6, 51);
            this.rbPrewitt.Name = "rbPrewitt";
            this.rbPrewitt.Size = new System.Drawing.Size(57, 17);
            this.rbPrewitt.TabIndex = 0;
            this.rbPrewitt.TabStop = true;
            this.rbPrewitt.Text = "Prewitt";
            this.rbPrewitt.UseVisualStyleBackColor = true;
            this.rbPrewitt.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // tbSobel
            // 
            this.tbSobel.Enabled = false;
            this.tbSobel.Location = new System.Drawing.Point(138, 24);
            this.tbSobel.Name = "tbSobel";
            this.tbSobel.Size = new System.Drawing.Size(100, 20);
            this.tbSobel.TabIndex = 1;
            // 
            // rbSobel
            // 
            this.rbSobel.AutoSize = true;
            this.rbSobel.Location = new System.Drawing.Point(6, 25);
            this.rbSobel.Name = "rbSobel";
            this.rbSobel.Size = new System.Drawing.Size(52, 17);
            this.rbSobel.TabIndex = 0;
            this.rbSobel.TabStop = true;
            this.rbSobel.Text = "Sobel";
            this.rbSobel.UseVisualStyleBackColor = true;
            this.rbSobel.CheckedChanged += new System.EventHandler(this.RadioButton_Checked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 780);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInputImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInputImage1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlendPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholding)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScalingFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReflection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.gbGausMatrix.ResumeLayout(false);
            this.gbGausMatrix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnsharpScaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCrimmins)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbRGBComponents;
        private System.Windows.Forms.RadioButton rbArtificialImages;
        private System.Windows.Forms.RadioButton rbRGBComponents;
        private System.Windows.Forms.Button btnRGBComponents;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResultImage;
        private System.Windows.Forms.Button btnInputImage1;
        private System.Windows.Forms.TextBox tbResultImage;
        private System.Windows.Forms.TextBox tbInputImage1;
        private System.Windows.Forms.PictureBox pbResultImage;
        private System.Windows.Forms.PictureBox pbInputImage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbWeightedAverage;
        private System.Windows.Forms.RadioButton rbWeightedAverage;
        private System.Windows.Forms.RadioButton rbSimpleAverage;
        private System.Windows.Forms.RadioButton rbDecomposition;
        private System.Windows.Forms.RadioButton rbDesaturation;
        private System.Windows.Forms.ComboBox cbDecomposition;
        private System.Windows.Forms.ComboBox cbSingleColorChannel;
        private System.Windows.Forms.RadioButton rbSingleColorChannel;
        private System.Windows.Forms.Button btnColorToGrayscale;
        private System.Windows.Forms.ComboBox cbArtificialImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInputImage2;
        private System.Windows.Forms.TextBox tbInputImage2;
        private System.Windows.Forms.PictureBox pbInputImage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnArithmeticOp;
        private System.Windows.Forms.ComboBox cbWithConstant;
        private System.Windows.Forms.RadioButton rbWithImage;
        private System.Windows.Forms.RadioButton rbWithConstant;
        private System.Windows.Forms.ComboBox cbWithImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarBlendPer;
        private System.Windows.Forms.Label lblConstantR;
        private System.Windows.Forms.Label lblBlendPer;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblConstantG;
        private System.Windows.Forms.Label lblConstantB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPointOp;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.TextBox tbThresholding;
        private System.Windows.Forms.RadioButton rbConvolution;
        private System.Windows.Forms.RadioButton rbQuantiation;
        private System.Windows.Forms.RadioButton rbLogarithmOperator;
        private System.Windows.Forms.RadioButton rbNormalization;
        private System.Windows.Forms.RadioButton rbAdaptiveThresholding;
        private System.Windows.Forms.RadioButton rbThresholding;
        private System.Windows.Forms.TrackBar trackBarThresholding;
        private System.Windows.Forms.Label lblThresholdingValue;
        private System.Windows.Forms.ComboBox cbAdaptiveThresMatrix;
        private System.Windows.Forms.ComboBox cbAdaptiveThres;
        private System.Windows.Forms.TextBox tbConvolution02;
        private System.Windows.Forms.TextBox tbConvolution01;
        private System.Windows.Forms.TextBox tbConvolution00;
        private System.Windows.Forms.TextBox tbConvolution22;
        private System.Windows.Forms.TextBox tbConvolution12;
        private System.Windows.Forms.TextBox tbConvolution21;
        private System.Windows.Forms.TextBox tbConvolution11;
        private System.Windows.Forms.TextBox tbConvolution20;
        private System.Windows.Forms.TextBox tbConvolution10;
        private System.Windows.Forms.RadioButton rbHistogramEq;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbScalingMethod;
        private System.Windows.Forms.ComboBox cbReflection;
        private System.Windows.Forms.TrackBar trackBarReflection;
        private System.Windows.Forms.ComboBox cbRotation;
        private System.Windows.Forms.RadioButton rbTranslation;
        private System.Windows.Forms.TrackBar trackBarRotation;
        private System.Windows.Forms.RadioButton rbReflection;
        private System.Windows.Forms.ComboBox cbScaling;
        private System.Windows.Forms.RadioButton rbRotation;
        private System.Windows.Forms.RadioButton rbScaling;
        private System.Windows.Forms.Label lblReflectionAng;
        private System.Windows.Forms.Label lblRotationAng;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbNOT;
        private System.Windows.Forms.Button btnLogicOperator;
        private System.Windows.Forms.RadioButton rbXNOR;
        private System.Windows.Forms.RadioButton rbNOR;
        private System.Windows.Forms.RadioButton rbNAND;
        private System.Windows.Forms.RadioButton rbXOR;
        private System.Windows.Forms.RadioButton rbOR;
        private System.Windows.Forms.RadioButton rbAND;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbImageBit;
        private System.Windows.Forms.RadioButton rbImage;
        private System.Windows.Forms.RadioButton rbGray;
        private System.Windows.Forms.RadioButton rbRGB;
        private System.Windows.Forms.RadioButton rbMatrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown tbTransX;
        private System.Windows.Forms.NumericUpDown tbTransY;
        private System.Windows.Forms.NumericUpDown tbScalingFactor;
        private System.Windows.Forms.NumericUpDown tbQuantization;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton rbUnsharpFilter;
        private System.Windows.Forms.RadioButton rbGaussianSmoothing;
        private System.Windows.Forms.RadioButton rbCrimminsSpeckleRemoval;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.NumericUpDown tbUnsharpScaling;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.NumericUpDown tbCrimmins;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton rbConservativeSmoothing;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton rbMedian;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton rbMean;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cbConservativeSmoothing;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbMedian;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbMean;
        private System.Windows.Forms.ComboBox cbUnsharpFilter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDigitalFilters;
        private System.Windows.Forms.GroupBox gbGausMatrix;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox tbDifferenceOfGaussian;
        private System.Windows.Forms.RadioButton rbDifferenceOfGaussian;
        private System.Windows.Forms.TextBox tbLaplacianOfGaussaian;
        private System.Windows.Forms.RadioButton rbLaplacianOfGaussaian;
        private System.Windows.Forms.TextBox tbLaplacian;
        private System.Windows.Forms.RadioButton rbLaplacian;
        private System.Windows.Forms.TextBox tbScharr;
        private System.Windows.Forms.RadioButton rbScharr;
        private System.Windows.Forms.TextBox tbRoberts;
        private System.Windows.Forms.RadioButton rbRoberts;
        private System.Windows.Forms.TextBox tbPrewitt;
        private System.Windows.Forms.RadioButton rbPrewitt;
        private System.Windows.Forms.TextBox tbSobel;
        private System.Windows.Forms.RadioButton rbSobel;
        private System.Windows.Forms.Button btnEdgeDetectors;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.DomainUpDown udEdgeDetectors1;
        private System.Windows.Forms.DomainUpDown udEdgeDetectors2;
    }
}

