using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Toom.CellularAutomata.Model;
using Toom.CellularAutomata.Parser;


namespace Toom.CellularAutomata.GUI
{
	public partial class FormCaGui : Form
	{
		public CAField field = null;

		// CTOR
		public FormCaGui()
		{
			InitializeComponent();
		}


		// LOAD
		private void FormCaGui_Load(object sender, EventArgs e)
		{
			// set window title
			this.Text = Application.ProductName + " " + Application.ProductVersion;

			// initial settings
			textboxWorkerSleep.Text = workerSleepInSec.ToString("0.0");
			comboBoxWhichGame.SelectedIndex = 0;
			panel1.Enabled = false;

	
			// list of game rules
			//foreach (string s in Game.GameTypeNames)
			//	MessageBox.Show(this, s);
			//comboBoxWhichGame.Items.AddRange(Game.GameTypeNames);
			//if (comboBoxWhichGame.Items.Count < 1)
			//	MessageBox.Show(this, "dropdown is empty");
		}


		// init buttons


		private void buttonInitRandom_Click(object sender, EventArgs e)
		{
			// get min and max
			int min, max;
			try
			{
				min = int.Parse(textBoxAutomataValMin.Text);
				max = int.Parse(textBoxAutomataValMax.Text);
			}
			catch(Exception )
			{
				MessageBox.Show(this, "problem determining min and max values");
				return;
			}

			if (!CreateField())
				return;
			field.InitRandom(min,max);
			DisplayField();
			panel1.Enabled = true;
		}
		private void buttonInitBar_Click(object sender, EventArgs e)
		{
			if (!CreateField())
				return;
			field.InitBar();
			DisplayField();
			panel1.Enabled = true;
		}

		private void buttonInitDiamond_Click(object sender, EventArgs e)
		{
			if (!CreateField())
				return;
			field.InitDiamond();
			DisplayField();
			panel1.Enabled = true;
		}

		private void buttonInitCircle_Click(object sender, EventArgs e)
		{
			if (!CreateField())
				return;
			field.InitCircle();
			DisplayField();
			panel1.Enabled = true;
		}

		private void buttonInitHalfZeroHalfTwo_Click(object sender, EventArgs e)
		{
			if (!CreateField())
				return;
			field.InitHalfZeroHalfTwo();
			DisplayField();
			panel1.Enabled = true;
		}



		private bool CreateField()
		{
			int rows, cols;
			try 
			{
				rows = int.Parse(textboxFieldSizeRows.Text);
				cols = int.Parse(textboxFieldSizeCols.Text);
				this.field = new CAField(cols, rows);
			}
			catch( Exception )
			{
				ShowErrorDialog("invalid values for field size");
				return false;
			}
			return true;	// success
		}



		private void buttonPrint_Click(object sender, EventArgs e)
		{
			DisplayFieldAsText(field.ToString());
		}

		private void buttonTransform_Click(object sender, EventArgs e)
		{
			if (workerRunning) return;

			CATimer timer = new CATimer();

			CAGameType game = DetermineGameType();

			if (game == CAGameType.CUSTOM)
			{

				try
				{
					customRule = ParseCustomRule(textBoxUserRule.Text);
				}
				catch (Exception ex)
				{
					ShowErrorDialog(ex.Message);
					return;
				}


				field.DoTransform(customRule);
			}
			else
				field.DoTransform(game);

			double timeDiffS1 = timer.GetSAndReset();

			DisplayField();

			double timeDiffS2 = timer.GetSAndReset();

			if (!workerRunning)
				DebugPrintLine(
					"Transform took " + timeDiffS1.ToString("##0.000") +
					" Display took " + timeDiffS2.ToString("##0.000"));
		}


		private void DisplayField()
		{
			if ( field == null )
				return;

			CATimer timer = new CATimer();

			//Image img      = new Bitmap(pictureBoxField.Width-2, pictureBoxField.Height-2);
			Bitmap img = new Bitmap(field.sizeX, field.sizeY);
			Bitmap imgTitle = new Bitmap(pictureBoxFieldTitle.Width-2, pictureBoxFieldTitle.Height-2);

			double time = timer.GetSAndReset();

			if (!workerRunning)
				DebugPrintLine("image init took " + time.ToString("0.000"));

			DisplayFieldAsImageNew(field, img, imgTitle);
		}

		private void DisplayFieldAsText(string fieldAsString)
		{
			string newText = fieldAsString;

			// InvokeRequired required compares the thread ID of the 
			// calling thread to the thread ID of the creating thread. 
			// If these threads are different, it returns true. 
			//if (this.textboxField.InvokeRequired)
			//{
			//	DisplayFieldAsTextCallback d = new DisplayFieldAsTextCallback(DisplayField);
			//	this.Invoke(d, new object[] { newText });
			//}
			//else
			//{
				this.textboxField.Text = newText;
			//}
		}


		//private void DisplayFieldAsImage(CAField f, Image img, Image imgTitle)
		//{
		//	CATimer timer = new CATimer();
		//	// title
		//	Graphics g = Graphics.FromImage(imgTitle);

		//	Brush b = Brushes.Black;
		//	//Brush b = new SolidBrush( Color.Black);
		//	//Font font = SystemFonts.StatusFont;
		//	Font font = new Font(FontFamily.GenericMonospace, 14.0f, FontStyle.Regular);
		//	PointF point = new PointF(0.0f,0.0f);
		//	string title = f.GetTitle();
		//	g.DrawString(title, font, b, point);
		//	pictureBoxFieldTitle.Image = imgTitle;


		//	// field
		//	float kx = (float)img.Size.Width / f.sizeX;
		//	float ky = (float)img.Size.Height / f.sizeY;
		//	//Brush b;

		//	g = Graphics.FromImage(img);
		//	//g.CompositingQuality = CompositingQuality.HighSpeed;
		//	//g.CompositingMode = CompositingMode.SourceCopy;
		//	//g.SmoothingMode = SmoothingMode.None;
		//	//g.InterpolationMode = InterpolationMode.NearestNeighbor;

		//	double time1 = timer.GetSAndReset();

		//	// init field to white
		//	g.FillRectangle(Brushes.White, 0,0, img.Size.Width, img.Size.Height);


		//	for (int y = 0; y < f.sizeY ; y++)
		//	{
		//		for (int x = 0; x < f.sizeX; x++)
		//		{
		//			int d = f.data[x, y];

		//			// optimize
		//			if (d == 0)
		//				continue;

		//			switch (d)
		//			{
		//				//case 0:
		//				//	b = Brushes.White;
		//				//	break;
		//				case 1:
		//					b = Brushes.SkyBlue;
		//					break;
		//				case 2:
		//					b = Brushes.DarkBlue;
		//					break;
		//				default:
		//					b = Brushes.Red;
		//					break;
		//			}

		//			float p1x = (x*kx);
		//			float p1y = img.Size.Height - ((y+1) * ky);

		//			g.FillRectangle(b, p1x, p1y, kx, ky);

		//		}
		//	}
		//	double time2 = timer.GetSAndReset();
			
		//	pictureBoxField.Image = img;
		//	double time3 = timer.GetSAndReset();

		//	if (!workerRunning)
		//	{
		//		DebugPrintLine(
		//			"DisplayAsImage one " + time1.ToString("0.000") +
		//			" two " + time2.ToString("0.000") +
		//			" three " + time3.ToString("0.000")
		//			);
		//	}
		//}


		private void DisplayFieldAsImageNew(CAField f, Bitmap img, Bitmap imgTitle)
		{
			CATimer timer = new CATimer();
			// title
			Graphics g = Graphics.FromImage(imgTitle);

			Brush b = Brushes.Black;
			//Brush b = new SolidBrush( Color.Black);
			//Font font = SystemFonts.StatusFont;
			Font font = new Font(FontFamily.GenericMonospace, 14.0f, FontStyle.Regular);
			PointF point = new PointF(0.0f, 0.0f);
			string title = f.GetTitle();
			g.DrawString(title, font, b, point);
			pictureBoxFieldTitle.Image = imgTitle;


			// field
			//float kx = (float)img.Size.Width / f.sizeX;
			//float ky = (float)img.Size.Height / f.sizeY;
			Color c;

			g = Graphics.FromImage(img);
			//g.CompositingQuality = CompositingQuality.HighSpeed;
			//g.CompositingMode = CompositingMode.SourceCopy;
			//g.SmoothingMode = SmoothingMode.None;
			//g.InterpolationMode = InterpolationMode.NearestNeighbor;

			double time1 = timer.GetSAndReset();

			// init field to white
			g.FillRectangle(Brushes.White, 0, 0, img.Size.Width, img.Size.Height);


			for (int y = 0; y < f.sizeY; y++)
			{
				for (int x = 0; x < f.sizeX; x++)
				{
					int d = f.data[x, y];

					// optimize
					if (d == 0)
						continue;

					switch (d)
					{
						//case 0:
						//	b = Brushes.White;
						//	break;
						case 1:
							c = Color.SkyBlue;
							break;
						case 2:
							c = Color.DarkBlue;
							break;
						default:
							c = Color.Red;
							break;
					}

					//float p1x = (x * kx);
					//float p1y = img.Size.Height - ((y + 1) * ky);

					//g.FillRectangle(b, p1x, p1y, kx, ky);
					img.SetPixel(x, y, c);
				}
			}
			double time2 = timer.GetSAndReset();

			pictureBoxField.Image = img;
			double time3 = timer.GetSAndReset();

			if (!workerRunning)
			{
				DebugPrintLine(
					"DisplayAsImage one " + time1.ToString("0.000") +
					" two " + time2.ToString("0.000") +
					" three " + time3.ToString("0.000")
					);
			}
		}


		private void buttonTransRun_Click(object sender, EventArgs e)
		{
			// read sleep value
			try
			{
				workerSleepInSec = double.Parse(textboxWorkerSleep.Text);
			}
			catch ( Exception )
			{
				MessageBox.Show(this, "Invalid real number for sleep");
				return;
			}



			if (!workerRunning)
			{
				game = DetermineGameType();

				try
				{
					if (game == CAGameType.CUSTOM)
						customRule = ParseCustomRule(textBoxUserRule.Text);
				}
				catch ( Exception ex)
				{
					ShowErrorDialog(ex.Message);
					return;
				}

				backgroundWorker1.RunWorkerAsync();
				workerRunning = true;

				workerSavedButtonTitle = buttonTransRun.Text;
				buttonTransRun.Text = "STOP";
			}
			else
			{
				backgroundWorker1.CancelAsync();

				buttonTransRun.Text = workerSavedButtonTitle;
				workerRunning = false;
			}
		}

		bool workerRunning = false;
		string workerSavedButtonTitle;
		double workerSleepInSec=0.2;
		//delegate void DisplayFieldCallback(string text);
		CAGameType game;
		CARule customRule;
		//bool useCustomRule;


		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			int workerSleepInMs = (int) (workerSleepInSec*1000);
			while (true)
			{
				if (backgroundWorker1.CancellationPending == true)
				{
					e.Cancel = true;
					break;
				}

				if ( game == CAGameType.CUSTOM )
					field.DoTransform(customRule);
				else
					field.DoTransform(game);

				DisplayField();
				System.Threading.Thread.Sleep(workerSleepInMs);
			}
		}


		private void pictureBoxField_SizeChanged(object sender, EventArgs e)
		{
			if (!workerRunning)
				DisplayField();

		}

		private CAGameType DetermineGameType()
		{
			if (radioButtonRuleCanned.Checked)
			{

				if ( (string)comboBoxWhichGame.SelectedItem == "Conway")
					return CAGameType.CONWAY;
				if ( (string)comboBoxWhichGame.SelectedItem == "NEC Max")
					return CAGameType.NEC_MAX;
				if ((string)comboBoxWhichGame.SelectedItem == "NEC Min")
					return CAGameType.NEC_MIN;
				if ((string)comboBoxWhichGame.SelectedItem == "NEC Median")
					return CAGameType.NEC_MEDIAN;
				if ((string)comboBoxWhichGame.SelectedItem == "Swap 0s and 2s")
					return CAGameType.SWAP_ZEROS_AND_TWOS;
				return CAGameType.NONE;
			}
			else if (radioButtonRuleCustom.Checked)
				return CAGameType.CUSTOM;
			else
				return CAGameType.NONE;
		}

		private CARule ParseCustomRule( string ruleAsText )
		{
			CAExpressionParser parser = new CAExpressionParser();
			CARule rule;

			//try
			//{
				rule = parser.parse(ruleAsText);
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(this, ex.Message);
			//	return null;
			//}

			return rule;

		}


		public void ShowErrorDialog( string message)
		{
			MessageBox.Show(this, message, "ERROR");

		}

		public void DebugPrintLine( string s )
		{
			try
			{
				textBoxDebug.AppendText(s + "\r\n");
			}
			catch ( Exception )
			{ }
		}

		private void buttonSizeMax_Click(object sender, EventArgs e)
		{
			int xMax = pictureBoxField.Size.Width  - 2;
			int yMax = pictureBoxField.Size.Height - 2;
			textboxFieldSizeCols.Text = xMax.ToString();
			textboxFieldSizeRows.Text = yMax.ToString();
		}

	}
}//ns
