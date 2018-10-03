namespace TESTExercise
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAllUser = new System.Windows.Forms.Button();
            this.btnGetUser = new System.Windows.Forms.Button();
            this.tbGetUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.resultGetAllUsers = new System.Windows.Forms.TextBox();
            this.resultGetUser = new System.Windows.Forms.TextBox();
            this.resultCreate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUPName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUPBD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUPID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.resultUpdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDLID = new System.Windows.Forms.TextBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.resultRemove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAllUser
            // 
            this.btnAllUser.Location = new System.Drawing.Point(439, 47);
            this.btnAllUser.Name = "btnAllUser";
            this.btnAllUser.Size = new System.Drawing.Size(88, 70);
            this.btnAllUser.TabIndex = 0;
            this.btnAllUser.Text = "GET";
            this.btnAllUser.UseVisualStyleBackColor = true;
            this.btnAllUser.Click += new System.EventHandler(this.btnAllUser_Click);
            // 
            // btnGetUser
            // 
            this.btnGetUser.Location = new System.Drawing.Point(439, 158);
            this.btnGetUser.Name = "btnGetUser";
            this.btnGetUser.Size = new System.Drawing.Size(88, 20);
            this.btnGetUser.TabIndex = 3;
            this.btnGetUser.Text = "GET";
            this.btnGetUser.UseVisualStyleBackColor = true;
            this.btnGetUser.Click += new System.EventHandler(this.btnGetUser_Click);
            // 
            // tbGetUser
            // 
            this.tbGetUser.Location = new System.Drawing.Point(308, 158);
            this.tbGetUser.Name = "tbGetUser";
            this.tbGetUser.Size = new System.Drawing.Size(118, 20);
            this.tbGetUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SEARCH ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "1- ALL USERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(20, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "2- GET USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(20, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "3- CREATE USER";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(166, 227);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(118, 20);
            this.tbName.TabIndex = 12;
            // 
            // tbBD
            // 
            this.tbBD.Location = new System.Drawing.Point(307, 228);
            this.tbBD.Name = "tbBD";
            this.tbBD.Size = new System.Drawing.Size(119, 20);
            this.tbBD.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "NAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "BIRTHDATE";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(439, 227);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 20);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // resultGetAllUsers
            // 
            this.resultGetAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.resultGetAllUsers.Location = new System.Drawing.Point(533, 47);
            this.resultGetAllUsers.Multiline = true;
            this.resultGetAllUsers.Name = "resultGetAllUsers";
            this.resultGetAllUsers.ReadOnly = true;
            this.resultGetAllUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultGetAllUsers.Size = new System.Drawing.Size(244, 70);
            this.resultGetAllUsers.TabIndex = 18;
            // 
            // resultGetUser
            // 
            this.resultGetUser.Location = new System.Drawing.Point(533, 159);
            this.resultGetUser.Name = "resultGetUser";
            this.resultGetUser.ReadOnly = true;
            this.resultGetUser.Size = new System.Drawing.Size(244, 20);
            this.resultGetUser.TabIndex = 19;
            // 
            // resultCreate
            // 
            this.resultCreate.Location = new System.Drawing.Point(533, 227);
            this.resultCreate.Name = "resultCreate";
            this.resultCreate.ReadOnly = true;
            this.resultCreate.Size = new System.Drawing.Size(244, 20);
            this.resultCreate.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(20, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "4- UPDATE USER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "NEW NAME";
            // 
            // tbUPName
            // 
            this.tbUPName.Location = new System.Drawing.Point(249, 278);
            this.tbUPName.Name = "tbUPName";
            this.tbUPName.Size = new System.Drawing.Size(90, 20);
            this.tbUPName.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "NEW BIRTHDATE";
            // 
            // tbUPBD
            // 
            this.tbUPBD.Location = new System.Drawing.Point(345, 278);
            this.tbUPBD.Name = "tbUPBD";
            this.tbUPBD.Size = new System.Drawing.Size(81, 20);
            this.tbUPBD.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "SEARCH ID";
            // 
            // tbUPID
            // 
            this.tbUPID.Location = new System.Drawing.Point(166, 278);
            this.tbUPID.Name = "tbUPID";
            this.tbUPID.Size = new System.Drawing.Size(76, 20);
            this.tbUPID.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(439, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 20);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // resultUpdate
            // 
            this.resultUpdate.Location = new System.Drawing.Point(533, 279);
            this.resultUpdate.Name = "resultUpdate";
            this.resultUpdate.ReadOnly = true;
            this.resultUpdate.Size = new System.Drawing.Size(244, 20);
            this.resultUpdate.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label11.Location = new System.Drawing.Point(20, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "5- DELETE USER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "SEARCH ID";
            // 
            // tbDLID
            // 
            this.tbDLID.Location = new System.Drawing.Point(308, 325);
            this.tbDLID.Name = "tbDLID";
            this.tbDLID.Size = new System.Drawing.Size(118, 20);
            this.tbDLID.TabIndex = 31;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(439, 327);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(88, 20);
            this.btnRemoveUser.TabIndex = 33;
            this.btnRemoveUser.Text = "REMOVE";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(342, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "REST EXERCISE";
            // 
            // resultRemove
            // 
            this.resultRemove.Location = new System.Drawing.Point(533, 328);
            this.resultRemove.Name = "resultRemove";
            this.resultRemove.ReadOnly = true;
            this.resultRemove.Size = new System.Drawing.Size(244, 20);
            this.resultRemove.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.resultRemove);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbDLID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resultUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbUPID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUPBD);
            this.Controls.Add(this.tbUPName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultCreate);
            this.Controls.Add(this.resultGetUser);
            this.Controls.Add(this.resultGetAllUsers);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBD);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGetUser);
            this.Controls.Add(this.btnGetUser);
            this.Controls.Add(this.btnAllUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllUser;
        private System.Windows.Forms.Button btnGetUser;
        private System.Windows.Forms.TextBox tbGetUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox resultGetAllUsers;
        private System.Windows.Forms.TextBox resultGetUser;
        private System.Windows.Forms.TextBox resultCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUPName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUPBD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbUPID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox resultUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDLID;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox resultRemove;
    }
}

