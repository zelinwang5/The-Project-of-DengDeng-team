using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyProject
{
    public partial class ThreeTraversal : Form
    {
        MyProject.ThreeTraversalMethod<int, string> TTM = new ThreeTraversalMethod<int, string>();
        public ThreeTraversal()
        {
            InitializeComponent();
        }
        private void BTN_PreOrder_Click(object sender, EventArgs e)
        {
            string PO = TTM.PreOrderEnter();
            TB_Numbers.Text = PO;
        }

        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            int key = int.Parse(TB_key.Text);
            string value = TB_Value.Text;
            TTM.insert(key, value);
            TB_key.Text = "";
            string LO = TTM.LevelOrderEnter();
            TB_Numbers.Text = LO;
        }

        private void BTN_InOrder_Click(object sender, EventArgs e)
        {
            string IO = TTM.InOrderEnter();
            TB_Numbers.Text = IO;
        }

        private void BTN_PostOrder_Click(object sender, EventArgs e)
        {
            string POO = TTM.PostOrderEnter();
            TB_Numbers.Text = POO;
        }

        private void BTN_LevelOrder_Click(object sender, EventArgs e)
        {
            string LO = TTM.LevelOrderEnter();
            TB_Numbers.Text = LO;
        }

        private void BTN_FindMin_Click(object sender, EventArgs e)
        {
            string Min = TTM.MinimumEnter();
            TB_Min.Text = Min;
        }

        private void BTN_FindMax_Click(object sender, EventArgs e)
        {
            string Max = TTM.MaximumEnter();
            TB_Max.Text = Max;
        }

        private void BTN_RemoveMin_Click(object sender, EventArgs e)
        {
            TTM.RemoveMinEnter();
        }

        private void BTN_RemoveAny_Click(object sender, EventArgs e)
        {
            int KeyNeedRemove = int.Parse(TB_NumberNeedRemove.Text);
            TTM.RemoveEnter(KeyNeedRemove);
        }

        private void BTN_FindFloorAndCeil_Click(object sender, EventArgs e)
        {
            TB_Floor.Text = " ";
            TB_Ceil.Text = " ";
            int KeyWantToFind = int.Parse(TB_MyKey.Text);
            string Temp = TTM.FloorCeilEnter(KeyWantToFind);
            if (Temp == "ok")
            {
                TB_Floor.Text = TTM.ReturnFloor();
                TB_Ceil.Text = TTM.ReturnCeil();                
            }
            else
            {
                TB_Floor.Text = TB_Ceil.Text = Temp;
            }
            //TTM.floor = null;
            //TTM.ceil = null;
        }

        private void BTN_FindCount_Click(object sender, EventArgs e)
        {
            //此处如果想在每次点击按钮时初始化TB_Count内的文字，应当在程序体里把TempFC初始化
            //TB_Count.Text = "";
            int KeyWantCount = int.Parse(TB_KeyWantCount.Text);
            string FC = TTM.FindCountEnter(KeyWantCount);
            TB_Count.Text = FC;
        }

        private void ThreeTraversal_Load(object sender, EventArgs e)
        {

        }

        private void BTN_FindCountReverse_Click(object sender, EventArgs e)
        {
            int KeyWantCountReverse = int.Parse(TB_KeyWantCountReverse.Text);
            string FCR = TTM.FindCountReverseEnter(KeyWantCountReverse);
            TB_CountReverse.Text = FCR;
        }

        private void BTN_FindKey_Click(object sender, EventArgs e)
        {
            int CountWant = int.Parse(TB_CountWant.Text);
            string FK = TTM.FindKeyEnter(CountWant);
            TB_KeyWanted.Text = FK;
        }

       
    }
}
