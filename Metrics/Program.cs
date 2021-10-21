﻿using Lab1ConsoleProg.Enties;
using Metrics.JilbMetric;
using Lab1ConsoleProg.ProgramAnalyzer;
using System;
using System.IO;

namespace Lab1ConsoleProg
{
	class Program
	{

		static void Main(string[] args)
		{
			StreamReader stream = new StreamReader(@"..\..\..\Data\TextFile1.txt");
			var a = new Lexer(stream.ReadToEnd());
			//var a = new Lexer("int __;");
			//var items = a.TokenizeCode();
			stream.Close();
			new Metrics.JilbMetric.Parcer(a.TokenizeCode());
			/*foreach (var item in items)
			{
				Console.WriteLine("Type : {0, 10} Value : {1}", item.Type, item.Value);
			}*/
			/*HalsteadMetric metric = new HalsteadMetric(items);
			var metricData = metric.CreateListsOfOperandsAndOperators();
			//var items = a.TokenizeCode();
			Console.WriteLine(metricData.DictionaryOfProgram + " " + metricData.VolumeOfProgram + " " + metricData.VolumeOfProgram );
			/*foreach (var item in metricData.ListOfOperands)
			{
				Console.WriteLine("Numb : {0, 5} Value : {1}", item.NumOfRep, item.ValueText);
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			foreach (var item in metricData.ListOfOperators)
			{
				Console.WriteLine("Numb : {0, 5} Value : {1}", item.NumOfRep, item.ValueText);
			}*/
		}
	}
}
