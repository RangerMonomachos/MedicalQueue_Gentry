namespace MedicalQueue_Gentry
{
    partial class MedicalQueue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalQueue));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CurrentPatient = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.listPatients = new System.Windows.Forms.Button();
            this.ListPoint = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameToAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriorityToAdd = new System.Windows.Forms.ComboBox();
            this.AddToQueue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to The ER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current  Patient";
            // 
            // CurrentPatient
            // 
            this.CurrentPatient.AutoSize = true;
            this.CurrentPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPatient.Location = new System.Drawing.Point(18, 70);
            this.CurrentPatient.Name = "CurrentPatient";
            this.CurrentPatient.Size = new System.Drawing.Size(163, 24);
            this.CurrentPatient.TabIndex = 2;
            this.CurrentPatient.Text = "No Current Patient";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(187, 73);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next Patient";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // listPatients
            // 
            this.listPatients.Location = new System.Drawing.Point(350, 13);
            this.listPatients.Name = "listPatients";
            this.listPatients.Size = new System.Drawing.Size(75, 23);
            this.listPatients.TabIndex = 4;
            this.listPatients.Text = "list Patients";
            this.listPatients.UseVisualStyleBackColor = true;
            this.listPatients.Click += new System.EventHandler(this.listPatients_Click);
            // 
            // ListPoint
            // 
            this.ListPoint.AutoSize = true;
            this.ListPoint.Location = new System.Drawing.Point(350, 43);
            this.ListPoint.Name = "ListPoint";
            this.ListPoint.Size = new System.Drawing.Size(132, 13);
            this.ListPoint.TabIndex = 5;
            this.ListPoint.Text = "push buttion to list patients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Patient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // NameToAdd
            // 
            this.NameToAdd.Location = new System.Drawing.Point(25, 232);
            this.NameToAdd.Name = "NameToAdd";
            this.NameToAdd.Size = new System.Drawing.Size(120, 20);
            this.NameToAdd.TabIndex = 8;
            this.NameToAdd.Text = "John Doe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Priority";
            // 
            // PriorityToAdd
            // 
            this.PriorityToAdd.FormattingEnabled = true;
            this.PriorityToAdd.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.PriorityToAdd.Location = new System.Drawing.Point(152, 230);
            this.PriorityToAdd.Name = "PriorityToAdd";
            this.PriorityToAdd.Size = new System.Drawing.Size(64, 21);
            this.PriorityToAdd.TabIndex = 10;
            // 
            // AddToQueue
            // 
            this.AddToQueue.Location = new System.Drawing.Point(223, 228);
            this.AddToQueue.Name = "AddToQueue";
            this.AddToQueue.Size = new System.Drawing.Size(75, 23);
            this.AddToQueue.TabIndex = 11;
            this.AddToQueue.Text = "Add";
            this.AddToQueue.UseVisualStyleBackColor = true;
            this.AddToQueue.Click += new System.EventHandler(this.AddToQueue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Curent Patient Count";
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCount.Location = new System.Drawing.Point(18, 298);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(90, 18);
            this.totalCount.TabIndex = 13;
            this.totalCount.Text = "Add Patients";
            // 
            // MedicalQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddToQueue);
            this.Controls.Add(this.PriorityToAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameToAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListPoint);
            this.Controls.Add(this.listPatients);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CurrentPatient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicalQueue";
            this.Text = "MedicalQueue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentPatient;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button listPatients;
        private System.Windows.Forms.Label ListPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameToAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PriorityToAdd;
        private System.Windows.Forms.Button AddToQueue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalCount;
    }
}

