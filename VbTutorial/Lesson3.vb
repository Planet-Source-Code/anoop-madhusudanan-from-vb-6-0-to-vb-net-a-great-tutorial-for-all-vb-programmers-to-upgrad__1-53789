'@desc: 3 : Shared Functions

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

'LESSON 3: SHARED FUNCTIONS
'----------------------------------------------------

'The shared members in a class (both functions and variables)
'can be used with out creating objects of the class as shown.

'The Shared modifier indicates the method does not operate on a 
'specific instance of a type and may be invoked directly from 
'a type rather than through a particular instance of a type.

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------

'-----------------------------------------------------------------
'Animals is a namespace
Namespace Animals

'Dog is a class in the namespace Animals
Class Dog

    'Bark is a now a public, shared function in this class
    
	Public Shared Function Bark()
		Console.Writeline ("Dog is barking")
	End Function
	
	
    'Walk is a public function in this class. It is not shared
	Public Function Walk()
		Console.Writeline ("Dog is walking")
	End Function
	
End Class

End Namespace
'-----------------------------------------------------------------


'-----------------------------------------------------------------
'Our Module

Public Module modMain

   'Execution will start from the Main() subroutine
   
   Sub Main()
		
		
		'We can call the Bark() function directly,
		'with out creating an object of type Dog -
		'because it is shared.
			
		Animals.Dog.Bark()
		
		
		'We can call the Walk() function only
		'after creating an object, because
		'it is not shared.
		
		Dim Jimmy as Animals.Dog
		Jimmy=new Animals.Dog()
		Jimmy.Walk()
		
		'Now Guess? The WriteLine() function we used so far
		'is a shared function in class Console :)
		
		'Also, we can write the Main() function itself as a shared
		'function in a class. i.e Shared Sub Main(). Try 
		'moving Main() from this module to the above class
		
		
   End sub

End Module
'-----------------------------------------------------------------
