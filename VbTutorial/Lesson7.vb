'@desc: 7 : Polymorphism

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


'LESSON 7: POLYMORPHISM
'----------------------------------------------------

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------


'This example is exactly the same one we saw in previous lesson.
'The only difference is in the Shared Sub Main() in class
'ClassMain. So scroll down.

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

'// Carefully examine the code in Main()

Class MainClass


	'Our main function
	Shared Sub Main()
		
		'Let us define Tom as a human (base class)
		Dim Tom as Human
		
		'Now, I am assiging an Indian (derived class)
		Tom=new Indian
		
		'The above assignment is legal, because
		'Indian IS_A human.
		
		'Now, let me call Speak as
		Tom.Speak()
		
		'Which Speak() will work? The Speak() in Indian, or the
		'Speak() in human?
		
		'The question arises because, Tom is declared as a Human,
		'but an object of type Indian is assigned to Tom.
		
		'The Answer is, the Speak() in Indian will work. This is because,
		'most object oriented languages like Vb.net can automatically
		'detect the type of the object assigned to a base class variable.
		
		'This is called Polymorphism
		
		
	End Sub

End Class

'-----------------------------------------------------------------
