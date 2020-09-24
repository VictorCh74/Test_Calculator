﻿/*
 * Created by SharpDevelop.
 * User: victor
 * Date: 24.09.2020
 * Time: 15:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using Calculator ;
using System.Collections.Generic ;

namespace Tests
{
	[TestFixture]
	public class ParserClassTest
	{
		[Test]
		public void GetRevPolNoteTestMethod()
		{
			ParserClass PC = new ParserClass( "2*(3+4)+10" , new RegularLineClass()) ;
			System.Collections.Generic.List<string> result = PC.GetRevPolNote() ;
			System.Collections.Generic.List<string> pat = new System.Collections.Generic.List<string>();
			pat.AddRange(new string[] { "2" , "3" , "4" ,  "+" , "*" , "10" , "+"} ) ;
	
			Assert.AreEqual( pat , result) ;
		}
	}
}
