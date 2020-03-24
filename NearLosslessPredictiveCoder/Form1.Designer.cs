namespace NearLosslessPredictiveCoder
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
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.buttonLoadOrig = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonSaveEncode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_JPEG_LS = new System.Windows.Forms.RadioButton();
            this.radioBtn_AB = new System.Windows.Forms.RadioButton();
            this.radioBtnBCA = new System.Windows.Forms.RadioButton();
            this.radioBtnACB = new System.Windows.Forms.RadioButton();
            this.radioBtn_ABC = new System.Windows.Forms.RadioButton();
            this.radioBtn_C = new System.Windows.Forms.RadioButton();
            this.radioBtn_B = new System.Windows.Forms.RadioButton();
            this.radioBtn_A = new System.Windows.Forms.RadioButton();
            this.radioBtn_128 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtn_Arithmetic = new System.Windows.Forms.RadioButton();
            this.radioBtn_Table = new System.Windows.Forms.RadioButton();
            this.radioBtn_Fixed = new System.Windows.Forms.RadioButton();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownKValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtn_Error_Quant = new System.Windows.Forms.RadioButton();
            this.radioBtn_Error_Pred = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.buttonRefreshError = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioBtn_Hist_Decoded = new System.Windows.Forms.RadioButton();
            this.radioBtn_Hist_Quant = new System.Windows.Forms.RadioButton();
            this.radioBtn_Hist_Prediction = new System.Windows.Forms.RadioButton();
            this.radioBtn_Hist_Original = new System.Windows.Forms.RadioButton();
            this.pictureBoxEncode = new System.Windows.Forms.PictureBox();
            this.buttonSaveDecode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.buttonLoadEncode = new System.Windows.Forms.Button();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonRefreshHisto = new System.Windows.Forms.Button();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOrigDiffDecod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKValue)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Image = global::NearLosslessPredictiveCoder.Properties.Resources.original;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // buttonLoadOrig
            // 
            this.buttonLoadOrig.Location = new System.Drawing.Point(12, 284);
            this.buttonLoadOrig.Name = "buttonLoadOrig";
            this.buttonLoadOrig.Size = new System.Drawing.Size(79, 29);
            this.buttonLoadOrig.TabIndex = 1;
            this.buttonLoadOrig.Text = "Load";
            this.buttonLoadOrig.UseVisualStyleBackColor = true;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(98, 284);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(79, 29);
            this.buttonEncode.TabIndex = 2;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            // 
            // buttonSaveEncode
            // 
            this.buttonSaveEncode.Location = new System.Drawing.Point(184, 284);
            this.buttonSaveEncode.Name = "buttonSaveEncode";
            this.buttonSaveEncode.Size = new System.Drawing.Size(79, 29);
            this.buttonSaveEncode.TabIndex = 3;
            this.buttonSaveEncode.Text = "Save";
            this.buttonSaveEncode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_JPEG_LS);
            this.groupBox1.Controls.Add(this.radioBtn_AB);
            this.groupBox1.Controls.Add(this.radioBtnBCA);
            this.groupBox1.Controls.Add(this.radioBtnACB);
            this.groupBox1.Controls.Add(this.radioBtn_ABC);
            this.groupBox1.Controls.Add(this.radioBtn_C);
            this.groupBox1.Controls.Add(this.radioBtn_B);
            this.groupBox1.Controls.Add(this.radioBtn_A);
            this.groupBox1.Controls.Add(this.radioBtn_128);
            this.groupBox1.Location = new System.Drawing.Point(12, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 202);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predictor Selection";
            // 
            // radioBtn_JPEG_LS
            // 
            this.radioBtn_JPEG_LS.AutoSize = true;
            this.radioBtn_JPEG_LS.Location = new System.Drawing.Point(132, 135);
            this.radioBtn_JPEG_LS.Name = "radioBtn_JPEG_LS";
            this.radioBtn_JPEG_LS.Size = new System.Drawing.Size(87, 21);
            this.radioBtn_JPEG_LS.TabIndex = 5;
            this.radioBtn_JPEG_LS.TabStop = true;
            this.radioBtn_JPEG_LS.Text = "JPEG-LS";
            this.radioBtn_JPEG_LS.UseVisualStyleBackColor = true;
            // 
            // radioBtn_AB
            // 
            this.radioBtn_AB.AutoSize = true;
            this.radioBtn_AB.Location = new System.Drawing.Point(132, 103);
            this.radioBtn_AB.Name = "radioBtn_AB";
            this.radioBtn_AB.Size = new System.Drawing.Size(93, 21);
            this.radioBtn_AB.TabIndex = 6;
            this.radioBtn_AB.TabStop = true;
            this.radioBtn_AB.Text = "(A + B) / 2";
            this.radioBtn_AB.UseVisualStyleBackColor = true;
            // 
            // radioBtnBCA
            // 
            this.radioBtnBCA.AutoSize = true;
            this.radioBtnBCA.Location = new System.Drawing.Point(132, 66);
            this.radioBtnBCA.Name = "radioBtnBCA";
            this.radioBtnBCA.Size = new System.Drawing.Size(115, 21);
            this.radioBtnBCA.TabIndex = 5;
            this.radioBtnBCA.TabStop = true;
            this.radioBtnBCA.Text = "B + (A - C) / 2";
            this.radioBtnBCA.UseVisualStyleBackColor = true;
            // 
            // radioBtnACB
            // 
            this.radioBtnACB.AutoSize = true;
            this.radioBtnACB.Location = new System.Drawing.Point(132, 30);
            this.radioBtnACB.Name = "radioBtnACB";
            this.radioBtnACB.Size = new System.Drawing.Size(115, 21);
            this.radioBtnACB.TabIndex = 5;
            this.radioBtnACB.TabStop = true;
            this.radioBtnACB.Text = "A + (B - C) / 2";
            this.radioBtnACB.UseVisualStyleBackColor = true;
            // 
            // radioBtn_ABC
            // 
            this.radioBtn_ABC.AutoSize = true;
            this.radioBtn_ABC.Location = new System.Drawing.Point(10, 171);
            this.radioBtn_ABC.Name = "radioBtn_ABC";
            this.radioBtn_ABC.Size = new System.Drawing.Size(85, 21);
            this.radioBtn_ABC.TabIndex = 5;
            this.radioBtn_ABC.TabStop = true;
            this.radioBtn_ABC.Text = "A + B - C";
            this.radioBtn_ABC.UseVisualStyleBackColor = true;
            // 
            // radioBtn_C
            // 
            this.radioBtn_C.AutoSize = true;
            this.radioBtn_C.Location = new System.Drawing.Point(10, 135);
            this.radioBtn_C.Name = "radioBtn_C";
            this.radioBtn_C.Size = new System.Drawing.Size(38, 21);
            this.radioBtn_C.TabIndex = 3;
            this.radioBtn_C.TabStop = true;
            this.radioBtn_C.Text = "C";
            this.radioBtn_C.UseVisualStyleBackColor = true;
            // 
            // radioBtn_B
            // 
            this.radioBtn_B.AutoSize = true;
            this.radioBtn_B.Location = new System.Drawing.Point(10, 103);
            this.radioBtn_B.Name = "radioBtn_B";
            this.radioBtn_B.Size = new System.Drawing.Size(38, 21);
            this.radioBtn_B.TabIndex = 2;
            this.radioBtn_B.TabStop = true;
            this.radioBtn_B.Text = "B";
            this.radioBtn_B.UseVisualStyleBackColor = true;
            // 
            // radioBtn_A
            // 
            this.radioBtn_A.AutoSize = true;
            this.radioBtn_A.Location = new System.Drawing.Point(10, 66);
            this.radioBtn_A.Name = "radioBtn_A";
            this.radioBtn_A.Size = new System.Drawing.Size(38, 21);
            this.radioBtn_A.TabIndex = 1;
            this.radioBtn_A.TabStop = true;
            this.radioBtn_A.Text = "A";
            this.radioBtn_A.UseVisualStyleBackColor = true;
            // 
            // radioBtn_128
            // 
            this.radioBtn_128.AutoSize = true;
            this.radioBtn_128.Location = new System.Drawing.Point(10, 30);
            this.radioBtn_128.Name = "radioBtn_128";
            this.radioBtn_128.Size = new System.Drawing.Size(53, 21);
            this.radioBtn_128.TabIndex = 0;
            this.radioBtn_128.TabStop = true;
            this.radioBtn_128.Text = "128";
            this.radioBtn_128.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtn_Arithmetic);
            this.groupBox2.Controls.Add(this.radioBtn_Table);
            this.groupBox2.Controls.Add(this.radioBtn_Fixed);
            this.groupBox2.Location = new System.Drawing.Point(12, 605);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 112);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save mode";
            // 
            // radioBtn_Arithmetic
            // 
            this.radioBtn_Arithmetic.AutoSize = true;
            this.radioBtn_Arithmetic.Location = new System.Drawing.Point(10, 78);
            this.radioBtn_Arithmetic.Name = "radioBtn_Arithmetic";
            this.radioBtn_Arithmetic.Size = new System.Drawing.Size(91, 21);
            this.radioBtn_Arithmetic.TabIndex = 8;
            this.radioBtn_Arithmetic.TabStop = true;
            this.radioBtn_Arithmetic.Text = "Arithmetic";
            this.radioBtn_Arithmetic.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Table
            // 
            this.radioBtn_Table.AutoSize = true;
            this.radioBtn_Table.Location = new System.Drawing.Point(10, 51);
            this.radioBtn_Table.Name = "radioBtn_Table";
            this.radioBtn_Table.Size = new System.Drawing.Size(65, 21);
            this.radioBtn_Table.TabIndex = 7;
            this.radioBtn_Table.TabStop = true;
            this.radioBtn_Table.Text = "Table";
            this.radioBtn_Table.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Fixed
            // 
            this.radioBtn_Fixed.AutoSize = true;
            this.radioBtn_Fixed.Location = new System.Drawing.Point(10, 24);
            this.radioBtn_Fixed.Name = "radioBtn_Fixed";
            this.radioBtn_Fixed.Size = new System.Drawing.Size(62, 21);
            this.radioBtn_Fixed.TabIndex = 6;
            this.radioBtn_Fixed.TabStop = true;
            this.radioBtn_Fixed.Text = "Fixed";
            this.radioBtn_Fixed.UseVisualStyleBackColor = true;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = global::NearLosslessPredictiveCoder.Properties.Resources.error;
            this.pictureBoxError.Location = new System.Drawing.Point(355, 12);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxError.TabIndex = 6;
            this.pictureBoxError.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "K value";
            // 
            // numericUpDownKValue
            // 
            this.numericUpDownKValue.Location = new System.Drawing.Point(79, 334);
            this.numericUpDownKValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKValue.Name = "numericUpDownKValue";
            this.numericUpDownKValue.Size = new System.Drawing.Size(90, 22);
            this.numericUpDownKValue.TabIndex = 8;
            this.numericUpDownKValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownKValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtn_Error_Quant);
            this.groupBox3.Controls.Add(this.radioBtn_Error_Pred);
            this.groupBox3.Location = new System.Drawing.Point(355, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 84);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Error";
            // 
            // radioBtn_Error_Quant
            // 
            this.radioBtn_Error_Quant.AutoSize = true;
            this.radioBtn_Error_Quant.Location = new System.Drawing.Point(16, 54);
            this.radioBtn_Error_Quant.Name = "radioBtn_Error_Quant";
            this.radioBtn_Error_Quant.Size = new System.Drawing.Size(210, 21);
            this.radioBtn_Error_Quant.TabIndex = 11;
            this.radioBtn_Error_Quant.TabStop = true;
            this.radioBtn_Error_Quant.Text = "Quantization prediction error";
            this.radioBtn_Error_Quant.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Error_Pred
            // 
            this.radioBtn_Error_Pred.AutoSize = true;
            this.radioBtn_Error_Pred.Location = new System.Drawing.Point(16, 21);
            this.radioBtn_Error_Pred.Name = "radioBtn_Error_Pred";
            this.radioBtn_Error_Pred.Size = new System.Drawing.Size(127, 21);
            this.radioBtn_Error_Pred.TabIndex = 10;
            this.radioBtn_Error_Pred.TabStop = true;
            this.radioBtn_Error_Pred.Text = "Prediction error";
            this.radioBtn_Error_Pred.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contrast";
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Location = new System.Drawing.Point(416, 404);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.Size = new System.Drawing.Size(100, 22);
            this.textBoxContrast.TabIndex = 11;
            this.textBoxContrast.Text = "12.3";
            // 
            // buttonRefreshError
            // 
            this.buttonRefreshError.Location = new System.Drawing.Point(355, 446);
            this.buttonRefreshError.Name = "buttonRefreshError";
            this.buttonRefreshError.Size = new System.Drawing.Size(79, 29);
            this.buttonRefreshError.TabIndex = 12;
            this.buttonRefreshError.Text = "Refresh";
            this.buttonRefreshError.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioBtn_Hist_Decoded);
            this.groupBox4.Controls.Add(this.radioBtn_Hist_Quant);
            this.groupBox4.Controls.Add(this.radioBtn_Hist_Prediction);
            this.groupBox4.Controls.Add(this.radioBtn_Hist_Original);
            this.groupBox4.Location = new System.Drawing.Point(355, 511);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 206);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Source image for histogram";
            // 
            // radioBtn_Hist_Decoded
            // 
            this.radioBtn_Hist_Decoded.AutoSize = true;
            this.radioBtn_Hist_Decoded.Location = new System.Drawing.Point(16, 149);
            this.radioBtn_Hist_Decoded.Name = "radioBtn_Hist_Decoded";
            this.radioBtn_Hist_Decoded.Size = new System.Drawing.Size(86, 21);
            this.radioBtn_Hist_Decoded.TabIndex = 14;
            this.radioBtn_Hist_Decoded.TabStop = true;
            this.radioBtn_Hist_Decoded.Text = "Decoded";
            this.radioBtn_Hist_Decoded.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Hist_Quant
            // 
            this.radioBtn_Hist_Quant.AutoSize = true;
            this.radioBtn_Hist_Quant.Location = new System.Drawing.Point(16, 111);
            this.radioBtn_Hist_Quant.Name = "radioBtn_Hist_Quant";
            this.radioBtn_Hist_Quant.Size = new System.Drawing.Size(210, 21);
            this.radioBtn_Hist_Quant.TabIndex = 15;
            this.radioBtn_Hist_Quant.TabStop = true;
            this.radioBtn_Hist_Quant.Text = "Quantization prediction error";
            this.radioBtn_Hist_Quant.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Hist_Prediction
            // 
            this.radioBtn_Hist_Prediction.AutoSize = true;
            this.radioBtn_Hist_Prediction.Location = new System.Drawing.Point(16, 74);
            this.radioBtn_Hist_Prediction.Name = "radioBtn_Hist_Prediction";
            this.radioBtn_Hist_Prediction.Size = new System.Drawing.Size(127, 21);
            this.radioBtn_Hist_Prediction.TabIndex = 14;
            this.radioBtn_Hist_Prediction.TabStop = true;
            this.radioBtn_Hist_Prediction.Text = "Prediction error";
            this.radioBtn_Hist_Prediction.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Hist_Original
            // 
            this.radioBtn_Hist_Original.AutoSize = true;
            this.radioBtn_Hist_Original.Location = new System.Drawing.Point(15, 36);
            this.radioBtn_Hist_Original.Name = "radioBtn_Hist_Original";
            this.radioBtn_Hist_Original.Size = new System.Drawing.Size(78, 21);
            this.radioBtn_Hist_Original.TabIndex = 12;
            this.radioBtn_Hist_Original.TabStop = true;
            this.radioBtn_Hist_Original.Text = "Original";
            this.radioBtn_Hist_Original.UseVisualStyleBackColor = true;
            // 
            // pictureBoxEncode
            // 
            this.pictureBoxEncode.Image = global::NearLosslessPredictiveCoder.Properties.Resources.decoded;
            this.pictureBoxEncode.Location = new System.Drawing.Point(800, 12);
            this.pictureBoxEncode.Name = "pictureBoxEncode";
            this.pictureBoxEncode.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxEncode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEncode.TabIndex = 14;
            this.pictureBoxEncode.TabStop = false;
            // 
            // buttonSaveDecode
            // 
            this.buttonSaveDecode.Location = new System.Drawing.Point(977, 282);
            this.buttonSaveDecode.Name = "buttonSaveDecode";
            this.buttonSaveDecode.Size = new System.Drawing.Size(79, 29);
            this.buttonSaveDecode.TabIndex = 17;
            this.buttonSaveDecode.Text = "Save";
            this.buttonSaveDecode.UseVisualStyleBackColor = true;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(892, 282);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(79, 29);
            this.buttonDecode.TabIndex = 16;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            // 
            // buttonLoadEncode
            // 
            this.buttonLoadEncode.Location = new System.Drawing.Point(800, 282);
            this.buttonLoadEncode.Name = "buttonLoadEncode";
            this.buttonLoadEncode.Size = new System.Drawing.Size(79, 29);
            this.buttonLoadEncode.TabIndex = 15;
            this.buttonLoadEncode.Text = "Load";
            this.buttonLoadEncode.UseVisualStyleBackColor = true;
            // 
            // chartHistogram
            // 
            this.chartHistogram.Location = new System.Drawing.Point(637, 330);
            this.chartHistogram.Name = "chartHistogram";
            this.chartHistogram.Size = new System.Drawing.Size(684, 313);
            this.chartHistogram.TabIndex = 18;
            this.chartHistogram.Text = "Histogram";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Histogram";
            title3.Text = "Histogram";
            this.chartHistogram.Titles.Add(title3);
            // 
            // buttonRefreshHisto
            // 
            this.buttonRefreshHisto.Location = new System.Drawing.Point(800, 665);
            this.buttonRefreshHisto.Name = "buttonRefreshHisto";
            this.buttonRefreshHisto.Size = new System.Drawing.Size(79, 29);
            this.buttonRefreshHisto.TabIndex = 19;
            this.buttonRefreshHisto.Text = "Refresh";
            this.buttonRefreshHisto.UseVisualStyleBackColor = true;
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(687, 669);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(100, 22);
            this.textBoxScale.TabIndex = 21;
            this.textBoxScale.Text = "12.3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Scale";
            // 
            // buttonOrigDiffDecod
            // 
            this.buttonOrigDiffDecod.Enabled = false;
            this.buttonOrigDiffDecod.Location = new System.Drawing.Point(639, 706);
            this.buttonOrigDiffDecod.Name = "buttonOrigDiffDecod";
            this.buttonOrigDiffDecod.Size = new System.Drawing.Size(122, 29);
            this.buttonOrigDiffDecod.TabIndex = 22;
            this.buttonOrigDiffDecod.Text = "Compute error";
            this.buttonOrigDiffDecod.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 743);
            this.Controls.Add(this.buttonOrigDiffDecod);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRefreshHisto);
            this.Controls.Add(this.chartHistogram);
            this.Controls.Add(this.buttonSaveDecode);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonLoadEncode);
            this.Controls.Add(this.pictureBoxEncode);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonRefreshError);
            this.Controls.Add(this.textBoxContrast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.numericUpDownKValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSaveEncode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonLoadOrig);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Near Lossless Predictive Coder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKValue)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEncode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.Button buttonLoadOrig;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonSaveEncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_JPEG_LS;
        private System.Windows.Forms.RadioButton radioBtn_AB;
        private System.Windows.Forms.RadioButton radioBtnBCA;
        private System.Windows.Forms.RadioButton radioBtnACB;
        private System.Windows.Forms.RadioButton radioBtn_ABC;
        private System.Windows.Forms.RadioButton radioBtn_C;
        private System.Windows.Forms.RadioButton radioBtn_B;
        private System.Windows.Forms.RadioButton radioBtn_A;
        private System.Windows.Forms.RadioButton radioBtn_128;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtn_Arithmetic;
        private System.Windows.Forms.RadioButton radioBtn_Table;
        private System.Windows.Forms.RadioButton radioBtn_Fixed;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownKValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioBtn_Error_Quant;
        private System.Windows.Forms.RadioButton radioBtn_Error_Pred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.Button buttonRefreshError;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioBtn_Hist_Decoded;
        private System.Windows.Forms.RadioButton radioBtn_Hist_Quant;
        private System.Windows.Forms.RadioButton radioBtn_Hist_Prediction;
        private System.Windows.Forms.RadioButton radioBtn_Hist_Original;
        private System.Windows.Forms.PictureBox pictureBoxEncode;
        private System.Windows.Forms.Button buttonSaveDecode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.Button buttonLoadEncode;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
        private System.Windows.Forms.Button buttonRefreshHisto;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOrigDiffDecod;
    }
}

