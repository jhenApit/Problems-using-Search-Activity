using System.Windows.Forms;

namespace APIT_Problems_using_Search_Activity
{
    partial class MazeSolverApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_Find = new System.Windows.Forms.RadioButton();
            this.rdb_Draw = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.mazeArea = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblPathCaption = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mazeArea)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Find);
            this.groupBox1.Controls.Add(this.rdb_Draw);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(388, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // rdb_Find
            // 
            this.rdb_Find.AutoSize = true;
            this.rdb_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Find.Location = new System.Drawing.Point(50, 74);
            this.rdb_Find.Name = "rdb_Find";
            this.rdb_Find.Size = new System.Drawing.Size(101, 24);
            this.rdb_Find.TabIndex = 1;
            this.rdb_Find.TabStop = true;
            this.rdb_Find.Text = "Find Path";
            this.rdb_Find.UseVisualStyleBackColor = true;
            this.rdb_Find.CheckedChanged += new System.EventHandler(this.rdb_Find_CheckedChanged);
            // 
            // rdb_Draw
            // 
            this.rdb_Draw.AutoSize = true;
            this.rdb_Draw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Draw.Location = new System.Drawing.Point(50, 35);
            this.rdb_Draw.Name = "rdb_Draw";
            this.rdb_Draw.Size = new System.Drawing.Size(117, 24);
            this.rdb_Draw.TabIndex = 0;
            this.rdb_Draw.TabStop = true;
            this.rdb_Draw.Text = "Draw Walls";
            this.rdb_Draw.UseVisualStyleBackColor = true;
            this.rdb_Draw.CheckedChanged += new System.EventHandler(this.rdb_Draw_CheckedChanged);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(388, 265);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(203, 33);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Reset Maze";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(388, 304);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(203, 33);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // mazeArea
            // 
            this.mazeArea.Location = new System.Drawing.Point(12, 12);
            this.mazeArea.Name = "mazeArea";
            this.mazeArea.Size = new System.Drawing.Size(370, 340);
            this.mazeArea.TabIndex = 3;
            this.mazeArea.TabStop = false;
            this.mazeArea.Paint += new System.Windows.Forms.PaintEventHandler(this.mazeArea_Paint);
            this.mazeArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mazeArea_MouseDown);
            this.mazeArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mazeArea_MouseMove);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(435, 199);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 17);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path";
            // 
            // lblPathCaption
            // 
            this.lblPathCaption.AutoSize = true;
            this.lblPathCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathCaption.Location = new System.Drawing.Point(434, 167);
            this.lblPathCaption.Name = "lblPathCaption";
            this.lblPathCaption.Size = new System.Drawing.Size(116, 20);
            this.lblPathCaption.TabIndex = 5;
            this.lblPathCaption.Text = "Current Path";
            // 
            // MazeSolverApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 365);
            this.Controls.Add(this.lblPathCaption);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.mazeArea);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.groupBox1);
            this.Name = "MazeSolverApp";
            this.Text = "Maze Solver App";
            this.Load += new System.EventHandler(this.MazeSolverApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mazeArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private RadioButton rdb_Find;
        private RadioButton rdb_Draw;
        private Button btn_Reset;
        private Button btn_Exit;
        private PictureBox mazeArea;
        private Label lblPath;
        private Label lblPathCaption;
    }
}

