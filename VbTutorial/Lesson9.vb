'@desc: 9 : Property Routines

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

'LESSON 9: Property Routines
'----------------------------------------------------

'You can use both properties and fields to store information in an object. 
'Whereas fields are simply public variables, properties use property procedures 
'to control how values are set or returned.

'You can use the Get/Set keywords for getting/setting properties.

'See the following example.

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------


'Dog is a class 
Public Class Dog

	'A private variable	to hold the value
	Private mAgeOfDog as Integer

    'This is our property routine

    Public Property Age() As Integer   
      
      'Called when someone tries to retreive the value
      Get
      	 Console.Writeline ("Getting Property")
         Return mAgeOfdog
      End Get
      
      'Called when someone tries to assign a value
      Set(ByVal Value As Integer)
      	 Console.Writeline ("Setting Property")
         mAgeOfDog=Value
      End Set
      
    End Property

	
End Class

'-----------------------------------------------------------------

'// Another Class 

Class MainClass


	'Our main function. Execution starts here.
	Shared Sub Main()
	
	'Let us create an object.
	Dim Jimmy as Dog
	Jimmy=new Dog		
	
	'We can't access mAgeofDog directly, so we should
	'use Age() property routine.
	
	'Set it. The Age Set routine will work
	Jimmy.Age=30
	
	'Get it back. The Age GEt routine will work
	Dim curAge=Jimmy.Age()
		
	End Sub

End Class

'-----------------------------------------------------------------
