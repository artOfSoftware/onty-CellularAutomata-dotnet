using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Toom.CellularAutomata.Model;


namespace Toom.CellularAutomata.Parser
{
	public class CAExpressionParser
	{

		public CAExpressionParser()
		{

		}

		public static string[] SeparatorsNewline = new string[] { "\r", "\n" };
		public static string[] SeparatorsWhitespace = new string[] { " ", "\t" };
		public static string[] SeparatorsAll = new string[] { "\r", "\n", " ", "\t" };

		public CARule parse(string input)
		{
			Queue<string> tokenized = eat1(input);
			//CallFunctionWithArgsTmp cfwat = eat2(out1);

			CAParserTempFunction outerTempFunction = eat2(tokenized);

			CARule outerRule = eat3(outerTempFunction);

			return outerRule;
		}

		public CAParserTempFunction parse12(string input)
		{
			Queue<string> tokenized = eat1(input);
			//CallFunctionWithArgsTmp cfwat = eat2(out1);

			CAParserTempFunction outerTempFunction = eat2(tokenized);

			return outerTempFunction;
		}


		#region eat1,2,3
		public Queue<string> eat1(string input)
		{
			string[] tokens1 = input.Split(
				SeparatorsAll, 
				StringSplitOptions.RemoveEmptyEntries);

			Queue<string> tokensOut = new Queue<string>();
			foreach ( string s in tokens1 )
				tokensOut.Enqueue(s);
			return tokensOut;
		}//eat1()

		public CAParserTempFunction eat2(Queue<string> input2)
		{
			CAParserTempFunction outerFunction = ParseCAFunction(input2);
			return outerFunction;
		}//eat2()

		public CARule eat3(CAParserTempFunction outerFunction)
		{
			CARule rule = DigestCAFunction(outerFunction);
			return rule;
		}//eat2()

		#endregion



		#region Parse into temp (eat1)
		public CAParserTempFunction ParseCAFunction(Queue<string> input)
		{
			// is queue empty?  if yes, exit throw exception
			if (input.Count == 0)
				throw new CAParserException( "trying to parse an empty input!" );

			// get first token
			string token = input.Dequeue();

			// make sure it ends in "("

			if ( ! token.EndsWith("(") )
				throw new CAParserException("function does not end with '('.  you specified '" + token + "'" );

			CAParserTempFunction myFunction = new CAParserTempFunction();
			myFunction.name = token.Substring(0, token.Length - 1);

			// look ahead. 
			// if we see a function, we call ourselves.
			// if we see a vector, we call ParseCAVector.
			// if we see a ')' -- base case, and we exit recursion.

			while (true)
			{
				string tokenPeek = input.Peek();

				if (tokenPeek.EndsWith("("))
					// its a function, recurse
					myFunction.args.Add(ParseCAFunction(input));
				else if (tokenPeek.StartsWith("(") && tokenPeek.EndsWith(")"))
					// its a vector
					myFunction.args.Add(ParseCAVector(input));
				else if (tokenPeek == ")")
				{
					// base case. exit while loop.
					input.Dequeue(); // remove ')'
					break;
				}
				else
					// bad syntax
					throw new CAParserException("invalid token found while reading custom function: '" + tokenPeek + "'");
			}
			return myFunction;
		}


		public CAParserTempVector ParseCAVector( Queue<string> input )
		{
			string token = input.Dequeue();

			if ( ! token.StartsWith("(") )
				throw new CAParserException("vectors must begin with '('");

			if ( ! token.EndsWith(")") )
				throw new CAParserException("vectors must end with ')'");

			CAParserTempVector v = new CAParserTempVector();
			v.vector = token.Substring(1, token.Length - 2);

			return v;
		}

		#endregion


		#region Digest temp into usable rule

		public CARule DigestCAFunction( CAParserTempFunction ft )
		{
			CARule f;

			// process function

			if (ft.name == "mid")
				f = new CARuleMedian();
			else if (ft.name == "min")
				f = new CARuleMinimum();
			else if (ft.name == "max")
				f = new CARuleMaximum();
			else
				throw new CAParserException("parser DigestCAFunction: Unknown function '" + ft.name + "' found in input");

			// process arguments
			List<CAExpression> args = new List<CAExpression>();

			foreach( CAParserTemp arg in ft.args )
			{
				if ( arg is CAParserTempFunction )
				{
					args.Add(DigestCAFunction((CAParserTempFunction)arg));
				}
				else
				{
					// vector
					CAVector v = DigestCAVector((CAParserTempVector)arg);
					args.Add(v);
				}
			}

			f.SpecifyArguments(args);

			return f;
		}



		public CAVector DigestCAVector(CAParserTempVector vt)
		{
			string[] elems = vt.vector.Split(',');
			int i, j;
			try
			{
				i = int.Parse(elems[0]);
				j = int.Parse(elems[1]);
			}
			catch (Exception ex)
			{
				throw new CAParserException("parser DigestCAVector: problem parsing vector elements", ex);
			}

			CAVector v = new CAVector(i, j);

			return v;
		}

		#endregion


	}//class CAExpressionParser




}//ns
