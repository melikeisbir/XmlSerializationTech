namespace XmlSerializationOrnek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Adlabel = new Label();
            Telefonlabel = new Label();
            Dogumtarihilabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            Departmanlabel = new Label();
            maaslabel = new Label();
            adtextBox = new TextBox();
            telefontextBox = new TextBox();
            departmantextBox = new TextBox();
            maastextBox = new TextBox();
            xmlserializedbutton = new Button();
            Sonuclabel = new Label();
            xmldeserializedbutton = new Button();
            SuspendLayout();
            // 
            // Adlabel
            // 
            Adlabel.AutoSize = true;
            Adlabel.Location = new Point(181, 32);
            Adlabel.Name = "Adlabel";
            Adlabel.Size = new Size(22, 15);
            Adlabel.TabIndex = 0;
            Adlabel.Text = "Ad";
            // 
            // Telefonlabel
            // 
            Telefonlabel.AutoSize = true;
            Telefonlabel.Location = new Point(181, 87);
            Telefonlabel.Name = "Telefonlabel";
            Telefonlabel.Size = new Size(45, 15);
            Telefonlabel.TabIndex = 1;
            Telefonlabel.Text = "Telefon";
            // 
            // Dogumtarihilabel
            // 
            Dogumtarihilabel.AutoSize = true;
            Dogumtarihilabel.Location = new Point(181, 144);
            Dogumtarihilabel.Name = "Dogumtarihilabel";
            Dogumtarihilabel.Size = new Size(78, 15);
            Dogumtarihilabel.TabIndex = 2;
            Dogumtarihilabel.Text = "Doğum Tarihi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(300, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // Departmanlabel
            // 
            Departmanlabel.AutoSize = true;
            Departmanlabel.Location = new Point(181, 207);
            Departmanlabel.Name = "Departmanlabel";
            Departmanlabel.Size = new Size(66, 15);
            Departmanlabel.TabIndex = 4;
            Departmanlabel.Text = "Departman";
            // 
            // maaslabel
            // 
            maaslabel.AutoSize = true;
            maaslabel.Location = new Point(184, 267);
            maaslabel.Name = "maaslabel";
            maaslabel.Size = new Size(35, 15);
            maaslabel.TabIndex = 5;
            maaslabel.Text = "Maaş";
            // 
            // adtextBox
            // 
            adtextBox.Location = new Point(300, 32);
            adtextBox.Name = "adtextBox";
            adtextBox.Size = new Size(100, 23);
            adtextBox.TabIndex = 7;
            // 
            // telefontextBox
            // 
            telefontextBox.Location = new Point(300, 84);
            telefontextBox.Name = "telefontextBox";
            telefontextBox.Size = new Size(100, 23);
            telefontextBox.TabIndex = 8;
            // 
            // departmantextBox
            // 
            departmantextBox.Location = new Point(300, 199);
            departmantextBox.Name = "departmantextBox";
            departmantextBox.Size = new Size(100, 23);
            departmantextBox.TabIndex = 9;
            // 
            // maastextBox
            // 
            maastextBox.Location = new Point(300, 259);
            maastextBox.Name = "maastextBox";
            maastextBox.Size = new Size(100, 23);
            maastextBox.TabIndex = 10;
            // 
            // xmlserializedbutton
            // 
            xmlserializedbutton.Location = new Point(184, 347);
            xmlserializedbutton.Name = "xmlserializedbutton";
            xmlserializedbutton.Size = new Size(130, 47);
            xmlserializedbutton.TabIndex = 11;
            xmlserializedbutton.Text = "XML'e Dönüştür";
            xmlserializedbutton.UseVisualStyleBackColor = true;
            xmlserializedbutton.Click += xmlserializedbutton_Click;
            // 
            // Sonuclabel
            // 
            Sonuclabel.AutoSize = true;
            Sonuclabel.Location = new Point(530, 40);
            Sonuclabel.Name = "Sonuclabel";
            Sonuclabel.Size = new Size(40, 15);
            Sonuclabel.TabIndex = 12;
            Sonuclabel.Text = "Sonuç";
            // 
            // xmldeserializedbutton
            // 
            xmldeserializedbutton.Location = new Point(372, 347);
            xmldeserializedbutton.Name = "xmldeserializedbutton";
            xmldeserializedbutton.Size = new Size(128, 47);
            xmldeserializedbutton.TabIndex = 13;
            xmldeserializedbutton.Text = "button1";
            xmldeserializedbutton.UseVisualStyleBackColor = true;
            xmldeserializedbutton.Click += xmldeserializedbutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(xmldeserializedbutton);
            Controls.Add(Sonuclabel);
            Controls.Add(xmlserializedbutton);
            Controls.Add(maastextBox);
            Controls.Add(departmantextBox);
            Controls.Add(telefontextBox);
            Controls.Add(adtextBox);
            Controls.Add(maaslabel);
            Controls.Add(Departmanlabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(Dogumtarihilabel);
            Controls.Add(Telefonlabel);
            Controls.Add(Adlabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Adlabel;
        private Label Telefonlabel;
        private Label Dogumtarihilabel;
        private DateTimePicker dateTimePicker1;
        private Label Departmanlabel;
        private Label maaslabel;
        private TextBox adtextBox;
        private TextBox telefontextBox;
        private TextBox departmantextBox;
        private TextBox maastextBox;
        private Button xmlserializedbutton;
        private Label Sonuclabel;
        private Button xmldeserializedbutton;
    }
}
