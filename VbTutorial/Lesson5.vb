'@desc: 5 : Inheritance

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

'LESSON 5: INHERITANCE
'----------------------------------------------------

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------


'Inheritance is the property in which, a derived class
'aquires the attributes of its base class. In simple terms,
'you can create or 'inherit' your own class (derived class), 
'using an existing class (base class). You can use the
'Inherits keyword for this.

'Let us see a simple example.

'// Our simple base class
Class Human

	'This is something that all humans do
	Public Sub Walk()
		Console.Writeline ("Walking")
	End Sub
		
End Class


'-----------------------------------------------------------------

'// Now, let us derive a class from human

'A programmer IS_A Human

Class Programmer
	Inherits Human
	
	'We already have the above Walk() function
	
	'This is something that all programmers do ;)
	Public Sub StealCode()
		Console.Writeline ("Stealing code")
	End Sub

'MS.NET has a rich set of built in classes, which can be derived
'to create your own classes.

End Class

'-----------------------------------------------------------------
'Just a main class

Class MainClass


	'Our main function
	Shared Sub Main()
		Dim Tom as Programmer
		Tom=new Programmer
		
		'This call is okie because programmer got this function
		'from its base class
		Tom.Walk() 
		
		'This is also correct because Tom is a programmer
		Tom.StealCode()
	
	End Sub

End Class

'-----------------------------------------------------------------

'Additional Notes:

'MustInherit: The MustInherit keyword specifies that a class cannot 
'be instantiated and can be used only as a base class.

'i.e, if you declare our Human class as 'MustInherit Class Human' , 
'then you can't create object of type Human with out inheriting it.

'NotInheritable: The NotInheritable keyword specifies that a class cannot 
'be inherited. I.e, if you specify 'NotInheritable Class Human', no
'derived classes can be made from Human class
