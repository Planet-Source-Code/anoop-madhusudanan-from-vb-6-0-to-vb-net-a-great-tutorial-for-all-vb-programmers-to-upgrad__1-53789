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

'LESSON 1: NAMESPACES, CLASSES AND OBJECTS, MODULES
'====================================================

'// 1) A Namespace
'====================================
'
'In VB.NET, classes and other data structures for a specific purpose are 
'grouped together to form a namespace.

'You can use the classes in a namespace, by simply importing the namespace.
'The 'imports' keyword is used to import a namespace to your project.
'.NET framework provides a rich set of built in classes, grouped
'to various namespaces.

'In this lesson, we are using the system namespace.

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------


'// 2) A Class
'====================================
'
'Probably, you are already familiar with classes and objects
'Simply speaking, a class is a definition of a real life
'object. For example, Human is a class for representing all 
'human beings. Dog is a class to represent all Dogs.

'Classes can contain functions too.

'-----------------------------------------------------------------
'Animals is a namespace
Namespace Animals

'Dog is a class in the namespace Animals
Class Dog

    'Bark is a function in this class
	Function Bark()
		Console.Writeline ("Dog is barking")
	End Function

End Class

End Namespace
'-----------------------------------------------------------------


'// 3) An Object
'====================================
'
'An object is an instance of a class. For example,
'Jimmy is an object of type Dog. We will create 
'an object in the next section. Read on.


'// 4) Modules
'====================================
'
'You can use modules to write common functions. A module is a
'group of functions. Unlike functions in classes, public functions
'in modules can be called directly from some where else.

'VB provides Functions and Subroutines. Functions and Sub
'routines are almost same, but subroutines can't return
'a value. 
'

'-----------------------------------------------------------------
Public Module modMain

   'Execution will start from the Main() subroutine
   
   Sub Main()
		
	   'Call our function. See below
	   OurFunction()	
   End sub
   
   
   'OurFunction: Our own little function to use the class Dog

   Function OurFunction()	
	   'Here is how we declare a variable Jimmy of type Dog.
	   'We use Animals.Dog because, the class Dog is in the
	   'namespace Animals (see above).
	   
	   Dim Jimmy as Animals.Dog    
	   
	   'Create an object. Unlike in VB 6, it is not required to use
	   'the 'set' keyword. 
	   	   
	   Jimmy = new Animals.Dog()
	   
	   'Another way to create an object is 
	   'Dim Jimmy as new Dog
	
	   'Call Jimmy's Main Function 	
	   Jimmy.Bark()
	   
   End Function

End module
'-----------------------------------------------------------------

