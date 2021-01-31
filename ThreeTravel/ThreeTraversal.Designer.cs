namespace MyProject
{
    partial class ThreeTraversal
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
            this.BTN_PostOrder = new System.Windows.Forms.Button();
            this.BTN_InOrder = new System.Windows.Forms.Button();
            this.BTN_PreOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Numbers = new System.Windows.Forms.TextBox();
            this.BTN_Insert = new System.Windows.Forms.Button();
            this.TB_key = new System.Windows.Forms.TextBox();
            this.TB_Value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_LevelOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Min = new System.Windows.Forms.TextBox();
            this.BTN_FindMin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Max = new System.Windows.Forms.TextBox();
            this.BTN_FindMax = new System.Windows.Forms.Button();
            this.BTN_RemoveMin = new System.Windows.Forms.Button();
            this.BTN_RemoveAny = new System.Windows.Forms.Button();
            this.TB_NumberNeedRemove = new System.Windows.Forms.TextBox();
            this.TB_MyKey = new System.Windows.Forms.TextBox();
            this.TB_Floor = new System.Windows.Forms.TextBox();
            this.TB_Ceil = new System.Windows.Forms.TextBox();
            this.BTN_FindFloorAndCeil = new System.Windows.Forms.Button();
            this.TB_KeyWantCount = new System.Windows.Forms.TextBox();
            this.BTN_FindCount = new System.Windows.Forms.Button();
            this.TB_Count = new System.Windows.Forms.TextBox();
            this.TB_KeyWantCountReverse = new System.Windows.Forms.TextBox();
            this.BTN_FindCountReverse = new System.Windows.Forms.Button();
            this.TB_CountReverse = new System.Windows.Forms.TextBox();
            this.TB_CountWant = new System.Windows.Forms.TextBox();
            this.BTN_FindKey = new System.Windows.Forms.Button();
            this.TB_KeyWanted = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_PostOrder
            // 
            this.BTN_PostOrder.Location = new System.Drawing.Point(700, 321);
            this.BTN_PostOrder.Name = "BTN_PostOrder";
            this.BTN_PostOrder.Size = new System.Drawing.Size(211, 34);
            this.BTN_PostOrder.TabIndex = 13;
            this.BTN_PostOrder.Text = "PostOrder";
            this.BTN_PostOrder.UseVisualStyleBackColor = true;
            this.BTN_PostOrder.Click += new System.EventHandler(this.BTN_PostOrder_Click);
            // 
            // BTN_InOrder
            // 
            this.BTN_InOrder.Location = new System.Drawing.Point(434, 321);
            this.BTN_InOrder.Name = "BTN_InOrder";
            this.BTN_InOrder.Size = new System.Drawing.Size(211, 34);
            this.BTN_InOrder.TabIndex = 14;
            this.BTN_InOrder.Text = "InOrder";
            this.BTN_InOrder.UseVisualStyleBackColor = true;
            this.BTN_InOrder.Click += new System.EventHandler(this.BTN_InOrder_Click);
            // 
            // BTN_PreOrder
            // 
            this.BTN_PreOrder.Location = new System.Drawing.Point(127, 321);
            this.BTN_PreOrder.Name = "BTN_PreOrder";
            this.BTN_PreOrder.Size = new System.Drawing.Size(211, 34);
            this.BTN_PreOrder.TabIndex = 15;
            this.BTN_PreOrder.Text = "PreOrder";
            this.BTN_PreOrder.UseVisualStyleBackColor = true;
            this.BTN_PreOrder.Click += new System.EventHandler(this.BTN_PreOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "The Numbers";
            // 
            // TB_Numbers
            // 
            this.TB_Numbers.Location = new System.Drawing.Point(264, 408);
            this.TB_Numbers.Name = "TB_Numbers";
            this.TB_Numbers.Size = new System.Drawing.Size(688, 28);
            this.TB_Numbers.TabIndex = 17;
            // 
            // BTN_Insert
            // 
            this.BTN_Insert.Location = new System.Drawing.Point(423, 65);
            this.BTN_Insert.Name = "BTN_Insert";
            this.BTN_Insert.Size = new System.Drawing.Size(211, 34);
            this.BTN_Insert.TabIndex = 28;
            this.BTN_Insert.Text = "Insert";
            this.BTN_Insert.UseVisualStyleBackColor = true;
            this.BTN_Insert.Click += new System.EventHandler(this.BTN_Insert_Click);
            // 
            // TB_key
            // 
            this.TB_key.Location = new System.Drawing.Point(191, 37);
            this.TB_key.Name = "TB_key";
            this.TB_key.Size = new System.Drawing.Size(147, 28);
            this.TB_key.TabIndex = 27;
            // 
            // TB_Value
            // 
            this.TB_Value.Location = new System.Drawing.Point(191, 100);
            this.TB_Value.Name = "TB_Value";
            this.TB_Value.Size = new System.Drawing.Size(147, 28);
            this.TB_Value.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "value:";
            // 
            // BTN_LevelOrder
            // 
            this.BTN_LevelOrder.Location = new System.Drawing.Point(127, 368);
            this.BTN_LevelOrder.Name = "BTN_LevelOrder";
            this.BTN_LevelOrder.Size = new System.Drawing.Size(211, 34);
            this.BTN_LevelOrder.TabIndex = 29;
            this.BTN_LevelOrder.Text = "LevelOrder";
            this.BTN_LevelOrder.UseVisualStyleBackColor = true;
            this.BTN_LevelOrder.Click += new System.EventHandler(this.BTN_LevelOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(728, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Min:";
            // 
            // TB_Min
            // 
            this.TB_Min.Location = new System.Drawing.Point(805, 37);
            this.TB_Min.Name = "TB_Min";
            this.TB_Min.Size = new System.Drawing.Size(147, 28);
            this.TB_Min.TabIndex = 31;
            // 
            // BTN_FindMin
            // 
            this.BTN_FindMin.Location = new System.Drawing.Point(980, 37);
            this.BTN_FindMin.Name = "BTN_FindMin";
            this.BTN_FindMin.Size = new System.Drawing.Size(162, 34);
            this.BTN_FindMin.TabIndex = 32;
            this.BTN_FindMin.Text = "FindMin";
            this.BTN_FindMin.UseVisualStyleBackColor = true;
            this.BTN_FindMin.Click += new System.EventHandler(this.BTN_FindMin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Max:";
            // 
            // TB_Max
            // 
            this.TB_Max.Location = new System.Drawing.Point(805, 103);
            this.TB_Max.Name = "TB_Max";
            this.TB_Max.Size = new System.Drawing.Size(147, 28);
            this.TB_Max.TabIndex = 34;
            // 
            // BTN_FindMax
            // 
            this.BTN_FindMax.Location = new System.Drawing.Point(980, 95);
            this.BTN_FindMax.Name = "BTN_FindMax";
            this.BTN_FindMax.Size = new System.Drawing.Size(162, 34);
            this.BTN_FindMax.TabIndex = 35;
            this.BTN_FindMax.Text = "FindMax";
            this.BTN_FindMax.UseVisualStyleBackColor = true;
            this.BTN_FindMax.Click += new System.EventHandler(this.BTN_FindMax_Click);
            // 
            // BTN_RemoveMin
            // 
            this.BTN_RemoveMin.Location = new System.Drawing.Point(943, 368);
            this.BTN_RemoveMin.Name = "BTN_RemoveMin";
            this.BTN_RemoveMin.Size = new System.Drawing.Size(211, 34);
            this.BTN_RemoveMin.TabIndex = 36;
            this.BTN_RemoveMin.Text = "RemoveMin";
            this.BTN_RemoveMin.UseVisualStyleBackColor = true;
            this.BTN_RemoveMin.Click += new System.EventHandler(this.BTN_RemoveMin_Click);
            // 
            // BTN_RemoveAny
            // 
            this.BTN_RemoveAny.Location = new System.Drawing.Point(980, 159);
            this.BTN_RemoveAny.Name = "BTN_RemoveAny";
            this.BTN_RemoveAny.Size = new System.Drawing.Size(211, 34);
            this.BTN_RemoveAny.TabIndex = 37;
            this.BTN_RemoveAny.Text = "RemoveAny";
            this.BTN_RemoveAny.UseVisualStyleBackColor = true;
            this.BTN_RemoveAny.Click += new System.EventHandler(this.BTN_RemoveAny_Click);
            // 
            // TB_NumberNeedRemove
            // 
            this.TB_NumberNeedRemove.Location = new System.Drawing.Point(805, 165);
            this.TB_NumberNeedRemove.Name = "TB_NumberNeedRemove";
            this.TB_NumberNeedRemove.Size = new System.Drawing.Size(147, 28);
            this.TB_NumberNeedRemove.TabIndex = 38;
            // 
            // TB_MyKey
            // 
            this.TB_MyKey.Location = new System.Drawing.Point(109, 146);
            this.TB_MyKey.Name = "TB_MyKey";
            this.TB_MyKey.Size = new System.Drawing.Size(147, 28);
            this.TB_MyKey.TabIndex = 39;
            // 
            // TB_Floor
            // 
            this.TB_Floor.Location = new System.Drawing.Point(462, 145);
            this.TB_Floor.Name = "TB_Floor";
            this.TB_Floor.Size = new System.Drawing.Size(147, 28);
            this.TB_Floor.TabIndex = 42;
            // 
            // TB_Ceil
            // 
            this.TB_Ceil.Location = new System.Drawing.Point(462, 179);
            this.TB_Ceil.Name = "TB_Ceil";
            this.TB_Ceil.Size = new System.Drawing.Size(147, 28);
            this.TB_Ceil.TabIndex = 43;
            // 
            // BTN_FindFloorAndCeil
            // 
            this.BTN_FindFloorAndCeil.Location = new System.Drawing.Point(275, 145);
            this.BTN_FindFloorAndCeil.Name = "BTN_FindFloorAndCeil";
            this.BTN_FindFloorAndCeil.Size = new System.Drawing.Size(151, 34);
            this.BTN_FindFloorAndCeil.TabIndex = 44;
            this.BTN_FindFloorAndCeil.Text = "FloorAndCeil";
            this.BTN_FindFloorAndCeil.UseVisualStyleBackColor = true;
            this.BTN_FindFloorAndCeil.Click += new System.EventHandler(this.BTN_FindFloorAndCeil_Click);
            // 
            // TB_KeyWantCount
            // 
            this.TB_KeyWantCount.Location = new System.Drawing.Point(731, 228);
            this.TB_KeyWantCount.Name = "TB_KeyWantCount";
            this.TB_KeyWantCount.Size = new System.Drawing.Size(147, 28);
            this.TB_KeyWantCount.TabIndex = 45;
            // 
            // BTN_FindCount
            // 
            this.BTN_FindCount.Location = new System.Drawing.Point(907, 222);
            this.BTN_FindCount.Name = "BTN_FindCount";
            this.BTN_FindCount.Size = new System.Drawing.Size(165, 34);
            this.BTN_FindCount.TabIndex = 46;
            this.BTN_FindCount.Text = "FindCount";
            this.BTN_FindCount.UseVisualStyleBackColor = true;
            this.BTN_FindCount.Click += new System.EventHandler(this.BTN_FindCount_Click);
            // 
            // TB_Count
            // 
            this.TB_Count.Location = new System.Drawing.Point(1095, 227);
            this.TB_Count.Name = "TB_Count";
            this.TB_Count.Size = new System.Drawing.Size(147, 28);
            this.TB_Count.TabIndex = 47;
            // 
            // TB_KeyWantCountReverse
            // 
            this.TB_KeyWantCountReverse.Location = new System.Drawing.Point(731, 272);
            this.TB_KeyWantCountReverse.Name = "TB_KeyWantCountReverse";
            this.TB_KeyWantCountReverse.Size = new System.Drawing.Size(147, 28);
            this.TB_KeyWantCountReverse.TabIndex = 48;
            // 
            // BTN_FindCountReverse
            // 
            this.BTN_FindCountReverse.Location = new System.Drawing.Point(907, 272);
            this.BTN_FindCountReverse.Name = "BTN_FindCountReverse";
            this.BTN_FindCountReverse.Size = new System.Drawing.Size(165, 34);
            this.BTN_FindCountReverse.TabIndex = 49;
            this.BTN_FindCountReverse.Text = "FindCountReverse";
            this.BTN_FindCountReverse.UseVisualStyleBackColor = true;
            this.BTN_FindCountReverse.Click += new System.EventHandler(this.BTN_FindCountReverse_Click);
            // 
            // TB_CountReverse
            // 
            this.TB_CountReverse.Location = new System.Drawing.Point(1095, 272);
            this.TB_CountReverse.Name = "TB_CountReverse";
            this.TB_CountReverse.Size = new System.Drawing.Size(147, 28);
            this.TB_CountReverse.TabIndex = 50;
            // 
            // TB_CountWant
            // 
            this.TB_CountWant.Location = new System.Drawing.Point(109, 228);
            this.TB_CountWant.Name = "TB_CountWant";
            this.TB_CountWant.Size = new System.Drawing.Size(147, 28);
            this.TB_CountWant.TabIndex = 51;
            // 
            // BTN_FindKey
            // 
            this.BTN_FindKey.Location = new System.Drawing.Point(275, 223);
            this.BTN_FindKey.Name = "BTN_FindKey";
            this.BTN_FindKey.Size = new System.Drawing.Size(151, 34);
            this.BTN_FindKey.TabIndex = 52;
            this.BTN_FindKey.Text = "FindKey";
            this.BTN_FindKey.UseVisualStyleBackColor = true;
            this.BTN_FindKey.Click += new System.EventHandler(this.BTN_FindKey_Click);
            // 
            // TB_KeyWanted
            // 
            this.TB_KeyWanted.Location = new System.Drawing.Point(462, 227);
            this.TB_KeyWanted.Name = "TB_KeyWanted";
            this.TB_KeyWanted.Size = new System.Drawing.Size(147, 28);
            this.TB_KeyWanted.TabIndex = 53;
            // 
            // ThreeTraversal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 461);
            this.Controls.Add(this.TB_KeyWanted);
            this.Controls.Add(this.BTN_FindKey);
            this.Controls.Add(this.TB_CountWant);
            this.Controls.Add(this.TB_CountReverse);
            this.Controls.Add(this.BTN_FindCountReverse);
            this.Controls.Add(this.TB_KeyWantCountReverse);
            this.Controls.Add(this.TB_Count);
            this.Controls.Add(this.BTN_FindCount);
            this.Controls.Add(this.TB_KeyWantCount);
            this.Controls.Add(this.BTN_FindFloorAndCeil);
            this.Controls.Add(this.TB_Ceil);
            this.Controls.Add(this.TB_Floor);
            this.Controls.Add(this.TB_MyKey);
            this.Controls.Add(this.TB_NumberNeedRemove);
            this.Controls.Add(this.BTN_RemoveAny);
            this.Controls.Add(this.BTN_RemoveMin);
            this.Controls.Add(this.BTN_FindMax);
            this.Controls.Add(this.TB_Max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_FindMin);
            this.Controls.Add(this.TB_Min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_LevelOrder);
            this.Controls.Add(this.BTN_Insert);
            this.Controls.Add(this.TB_key);
            this.Controls.Add(this.TB_Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Numbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_PreOrder);
            this.Controls.Add(this.BTN_InOrder);
            this.Controls.Add(this.BTN_PostOrder);
            this.Name = "ThreeTraversal";
            this.Text = "ThreeTraversal";
            this.Load += new System.EventHandler(this.ThreeTraversal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_PostOrder;
        private System.Windows.Forms.Button BTN_InOrder;
        private System.Windows.Forms.Button BTN_PreOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Numbers;
        private System.Windows.Forms.Button BTN_Insert;
        private System.Windows.Forms.TextBox TB_key;
        private System.Windows.Forms.TextBox TB_Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_LevelOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Min;
        private System.Windows.Forms.Button BTN_FindMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Max;
        private System.Windows.Forms.Button BTN_FindMax;
        private System.Windows.Forms.Button BTN_RemoveMin;
        private System.Windows.Forms.Button BTN_RemoveAny;
        private System.Windows.Forms.TextBox TB_NumberNeedRemove;
        private System.Windows.Forms.TextBox TB_MyKey;
        private System.Windows.Forms.TextBox TB_Floor;
        private System.Windows.Forms.TextBox TB_Ceil;
        private System.Windows.Forms.Button BTN_FindFloorAndCeil;
        private System.Windows.Forms.TextBox TB_KeyWantCount;
        private System.Windows.Forms.Button BTN_FindCount;
        private System.Windows.Forms.TextBox TB_Count;
        private System.Windows.Forms.TextBox TB_KeyWantCountReverse;
        private System.Windows.Forms.Button BTN_FindCountReverse;
        private System.Windows.Forms.TextBox TB_CountReverse;
        private System.Windows.Forms.TextBox TB_CountWant;
        private System.Windows.Forms.Button BTN_FindKey;
        private System.Windows.Forms.TextBox TB_KeyWanted;
    }
}