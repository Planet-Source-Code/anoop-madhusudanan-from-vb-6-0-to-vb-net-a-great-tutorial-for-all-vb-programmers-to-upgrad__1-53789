'@desc: 2 : Access Types
'@desc: 1 : Classes and objects

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

'LESSON 2: ACCESS TYPES 
'----------------------------------------------------

'The major access types are Public, Private, Friend And Protected.

'A class may contain functions, variables etc, either public
'or private or protected or friend. If they are public, 
'they can be accessed by creating objects of the class. 

'Private and Protected members can be accessed only by functions 
'inside the class. Protected members are much like private members,
'but they have some special use while inheriting the class. We
'will see this later, in Inheritance (Lesson 5).

'Friend members can be accessed only from elements in the
'same project, and not by elements outer the current project.


'Let us expand our dog class.

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------

'-----------------------------------------------------------------
'Animals is a namespace
Namespace Animals

'Dog is a class in the namespace Animals
Public Class Dog

	'A public variable	
	Public AgeOfDog as Integer


    'Bark is a function in this class. It is public
	Public Function Bark()
		Console.Writeline ("Dog is barking")
	End Function
	
    'Walk is a function in this class. It is private
	Private Function Walk()
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
		
	   'Call our function. See below
	   OurFunction()	
   End sub


	'OurFunction: Called from Main()
	
	Function OurFunction()
		
		Dim Jimmy as Animals.Dog
		Jimmy=new Animals.Dog()
		
		
		'This will work, because Bark & Ageofdog are public
		Jimmy.Bark
		Jimmy.AgeOfDog=10
		
		'Calling the Walk function will not work here, because
		'Walk() is outside the class Dog		

		'So this is wrong. Uncomment this and try to compile, it will
		'cause an error.
		
		'Jimmy.Walk
		
	End Function		
	
End Module


'-----------------------------------------------------------------
'Additional Notes:

'Encapsulation: 

'Putting all the data and related functions, in the class is called
'as Encapsulation.

'Data Hiding or Abstraction:

'Normally, in a class, variables used to hold data (like the age of
'a dog) is declared as private. Functions or property routines are used 
'to access these variables. Protecting the data of an object from
'outer functions is called as Abstraction or Data Hiding. This prevents
'accidental modification of data by functions outside the class.
