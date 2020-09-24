'@desc: 4 : Over Loading Functions

'================================================================
'Author: Anoop - anoop@logicmatrixonline.com 
'        http://www.logicmatrixonline.com/anoop
'================================================================

'
'You need Microsoft.NET framework SDK installed in your system to 
'compile and execute the excercises in this article. 
'You can download it from http://www.asp.net 

'You need a good editor to compile .NET applications. You can try 
'Smart Editor Professional, a free to try editor which supports 
'C#, VB.NET etc. See http://www.logicmatrixonline.com/sepro

'================================================================

'Note: See Readme.htm in the same folder to learn how to
'compile this file.
'================================================================

'LESSON 4: OVERLOADING
'----------------------------------------------------

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------


'Overloading is a simple technique, to enable a single
'function name to accept parameters of different type.


'Our simple Adder class
Class Adder

    'Here, we have two Add() functions. 
    
    'This one adds two integers.
    'Convert.ToString is equivalent to good old Cstr  
      
	Overloads Public Sub Add(A as Integer, B as Integer)
		Console.Writeline ("Adding Integers: " + Convert.ToString(a + b))
	End Sub
	

    'This one adds two strings
	Overloads Public Sub Add(A as String, B as String)
		Console.Writeline ("Adding Strings: " + a + b)
	End Sub
	
	'And both have the same name. This is possible because, we used the
	'Overloads keyword, to overload them.
	
	
	'Here, we have the Main Function with in this class. When you write.
	'your main function inside the class, it should be a shared function.
	
	Shared Sub Main() 
		
		Dim AdderObj as Adder
		
		'Create the object
		AdderObj=new Adder
		
		'This will invoke first function
		AdderObj.Add(10,20)
		'This will invoke second function
		AdderObj.Add("hello"," how are you")
		
		
	End Sub
	
	
End Class



