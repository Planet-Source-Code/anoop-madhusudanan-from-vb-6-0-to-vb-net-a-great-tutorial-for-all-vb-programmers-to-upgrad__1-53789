'@desc: 6 : Over Riding

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

'LESSON 6: OVERRIDING
'----------------------------------------------------

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------


'By default, a derived class inherits methods from its base class. 
'If an inherited property or method needs to behave differently in 
'the derived class it can be overridden; that is, you can define a 
'new implementation of the method in the derived class.

'The 'Overridable' keyword is used to mark a function as 
'overridable. The keyword 'Overrides' is used to mark that a function
'is overriding some base class function.

'Let us see an example

'// Our simple base class
Class Human

	'Speak() is declared Overridable
	Overridable Public Sub Speak()
		Console.Writeline ("Speaking")
	End Sub
		
End Class


'-----------------------------------------------------------------

'// Now, let us derive a class from human

'An Indian IS_A Human

Class Indian
	Inherits Human
	
	'Let us make Indian speak Hindi, the National Language
	'in India
	
	'Speak() is overriding Speak() in its base class (Human)
	
	Overrides Public Sub Speak()
		Console.Writeline ("Speaking Hindi")


	'Important: As you expect, any call to Speak() inside this class
	'will invoke the Speak() in this class. If you need to
	'call Speak() in base class, you can use MyBase keyword.
	
	'Like this
	'Mybase.Speak()

	End Sub
	
	
	
	
End Class

'-----------------------------------------------------------------

'// Just a class to put our Main()

Class MainClass


	'Our main function
	Shared Sub Main()
		
		'Tom is a generic Human
		Dim Tom as Human
		Tom=new Human
		
		'Tony is a human and an Indian
		Dim Tony as Indian
		Tony=new Indian
		
		
		'This call will invoke the Speak() function
		'in class Human
		Tom.Speak()
		
		'This call will invoke the Speak() function
		'in class Indian
		Tony.Speak() 
		
	End Sub

End Class

'-----------------------------------------------------------------
