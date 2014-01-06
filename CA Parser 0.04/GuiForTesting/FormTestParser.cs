using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Toom.CellularAutomata.Parser;
using Toom.CellularAutomata.Model;


namespace Toom.CellularAutomata.Parser.GuiForTesting
{
	public partial class FormTestParser : Form
	{
		public FormTestParser()
		{
			InitializeComponent();
		}

		private void buttonParse_Click(object sender, EventArgs e)
		{
			string s = textBoxInput.Text;

			CAExpressionParser parser = new CAExpressionParser();


			//// go all the way
			//CARule rule;

			//try
			//{
			//	rule = parser.parse(s);
			//	textBoxOutput.Text = rule.ToString();
			//}
			//catch ( Exception ex )
			//{
			//	MessageBox.Show(this, ex.Message);
			//}


			// show temps
			CAParserTempFunction outerFunction;

			try
			{
				outerFunction = parser.parse12(s);

				sb = new StringBuilder();
				PrintFunction(0, outerFunction);
				sb.AppendLine("DONE");


				textBoxOutput.Text = sb.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message);
			}



			
		}

		StringBuilder sb;

		public void PrintFunction(int indentLevel, CAParserTempFunction func )
		{
			sb.Append(GenerateIndent(indentLevel));
			sb.AppendLine("function '" + func.name + "' has " + func.args.Count + " args");
			foreach ( CAParserTemp t in func.args )
			{
				if (t is CAParserTempVector)
					PrintVector(indentLevel + 1, (CAParserTempVector)t);
				else
					PrintFunction(indentLevel + 1, (CAParserTempFunction)t);
			}
		}


		public void PrintVector(int indentLevel, CAParserTempVector vec)
		{
			sb.Append(GenerateIndent(indentLevel));
			sb.AppendLine("vector '" + vec.vector + "'");
		}

		public string GenerateIndent(int indentLevel)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < indentLevel; i++)
				sb.Append("> ");
			return sb.ToString();
		}

	}
}
