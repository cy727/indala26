using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indala26
{
	public partial class FormIndala : Form
	{
		//private char P1 = '1';
		//private char P2 = '0';

		DataTable dtIndala = new DataTable();

		public FormIndala()
		{

			InitializeComponent();

			dtIndala.Columns.Add("S1", System.Type.GetType("System.String"));//1
			dtIndala.Columns.Add("S2", System.Type.GetType("System.String"));//1
			dtIndala.Columns.Add("CARDNO", System.Type.GetType("System.String"));//1

			dataGridViewIndala.DataSource = dtIndala;
			for (int i = 0; i < dataGridViewIndala.ColumnCount; i++)
			{
				dataGridViewIndala.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			}

		}

		private void buttonSingle_Click(object sender, EventArgs e)
		{
			labelHigh.Text = numericUpDownHigh.Value.ToString();
			labelLow.Text = numericUpDownLowBottom.Value.ToString();
			textBoxIndala.Text = Indala(int.Parse(numericUpDownLowBottom.Value.ToString()), int.Parse(numericUpDownHigh.Value.ToString()));


		



		}

		private string Indala(int iInLow,int iInHigh)
		{
			string sIndala = "00000000";
			string sTHigh = System.Convert.ToString(iInHigh, 2);
			string sTLow = System.Convert.ToString(iInLow, 2);
			string sT1 = "";
			char P1 = '1',P2='1';
			int i,k;

			if (sTHigh.Length <= 8)
			{
				sTHigh = sTHigh.PadLeft(8, '0');
			}
			else //数字过大
			{
				return sIndala;
			}

			if (sTLow.Length <= 16)
			{
				sTLow = sTLow.PadLeft(16, '0');
			}
			else //数字过大
			{
				return sIndala;
			}

			//计算奇偶校验
			//P1
			sT1 = "";
			//前12位
			sT1 = sTHigh + sTLow.Substring(0, 4);
			k = 0;
			for (i = 0; i < 12; i++)
			{
				k += int.Parse(sT1[i].ToString());
			}
			if (k % 2 == 1) //奇数
			{
				P1 = '1';
			}
			else
			{
				P1 = '0';
			}

			//P2
			sT1 = "";
			//前12位
			sT1 = sTLow.Substring(4, 12);
			k = 0;
			for (i = 0; i < 12; i++)
			{
				k += int.Parse(sT1[i].ToString());
			}
			if (k % 2 == 1) //奇数
			{
				P2 = '0';
			}
			else
			{
				P2 = '1';
			}


			string sT = "00000000000000000000000000000000000";
			char[] csT = sT.ToCharArray(0, 35);

			csT[0] = '1';
			csT[1] = sTLow[9];
			csT[2] = P1;
			csT[3] = sTLow[6];
			csT[4] = sTLow[5];
			csT[5] = sTLow[10];
			csT[6] = P2;
			csT[7] = sTHigh[6];
			csT[8] = sTLow[3];
			csT[9] = sTLow[15];
			csT[10] = sTLow[0];
			csT[11] = sTLow[2];
			csT[12] = sTHigh[2];
			csT[13] = sTLow[1];
			csT[14] = sTLow[8];
			csT[15] = sTHigh[3];
			csT[16] = sTHigh[4];
			csT[17] = sTHigh[1];
			csT[18] = sTLow[14];
			csT[19] = sTLow[7];
			csT[20] = sTLow[4];
			csT[21] = sTHigh[5];
			csT[22] = sTLow[11];
			csT[23] = '0';
			csT[24] = sTLow[12];
			csT[25] = sTHigh[0];
			csT[26] = sTHigh[7];
			csT[27] = sTLow[13];
			csT[28] = '0';
			csT[29] = '0';
			csT[30] = '0';
			csT[31] = '1';
			csT[32] = '1';
			csT[33] = '0';
			csT[34] = '1';

			string s2Bit = new string(csT);
			s2Bit = "0" + s2Bit;

			sIndala = "";
			for (k = 0; k < 9; k++)
			{
				sT1 = s2Bit.Substring(k*4,4);
				sIndala += Convert.ToString(Convert.ToInt32(sT1, 2), 16);

			}

	

			return sIndala;
		}

		private void numericUpDownLowBottom_ValueChanged(object sender, EventArgs e)
		{
			if (numericUpDownLowTop.Value < numericUpDownLowBottom.Value)
				numericUpDownLowTop.Value = numericUpDownLowBottom.Value;
		}

		private void buttonMany_Click(object sender, EventArgs e)
		{
			dtIndala.Clear();
			object[] oTemp = new object[3];
			int i;
			int k;

			k = int.Parse(numericUpDownHigh.Value.ToString());
			for (i = int.Parse(numericUpDownLowBottom.Value.ToString()); i <= int.Parse(numericUpDownLowTop.Value.ToString()); i++)
			{
				oTemp[0] = k.ToString();
				oTemp[1] = i.ToString();
				oTemp[2] = Indala(i, k);

				dtIndala.Rows.Add(oTemp);
			}

			dataGridViewIndala.DataSource = dtIndala;
		}

		private void dataGridViewIndala_KeyDown(object sender, KeyEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.C)
			{

				if (sender != null && sender.GetType() == typeof(DataGridView))

					DataGridViewEnableCopy((DataGridView)sender);

			}
		}
		public void DataGridViewEnableCopy(DataGridView p_Data)
		{

			Clipboard.SetData(DataFormats.Text, p_Data.GetClipboardContent());

		}
	}
}
