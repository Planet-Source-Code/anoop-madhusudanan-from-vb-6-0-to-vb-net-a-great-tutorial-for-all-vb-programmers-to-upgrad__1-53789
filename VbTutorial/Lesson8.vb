'@desc: 8 : Constructors  & Destructors

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

'LESSON 8: CONSTRUCTORS & DESTRUCTORS
'----------------------------------------------------

'-----------------------------------------------------------------
'Import the System namespace (already available in .NET)
Imports System
'-----------------------------------------------------------------

'A Constructor is a special function, which is called
'automatically when a class is created. In VB.NET, you should use
'New() to create constructors as in the below examples.

'Constructors can be overloaded (see Lesson 4), but unlike
'in functions, the Overloads keyword is not required.

'A Destructor is a special function, which is called
'automatically when a class is Destroyed. In VB.NET, you should use
'Finalize() routine to create Destructors.

'They are similiar to Class_Initialize and Class_Terminate
'in VB 6.0


'-----------------------------------------------------------------

'Dog is a class 
Class Dog

	'The age variable
	Private Age as integer
	    
    'The Default Constructor.
	Public Sub New()
		Console.Writeline ("Dog is Created With Age Zero")
		Age=0
	End Sub

    'The Parameterized Constructor
	Public Sub New(val as Integer)
		Console.Writeline ("Dog is Created With Age " + Convert.ToString(val))
		Age=val
	End Sub


    'This is the destructor.
	Overrides Protected Sub Finalize()
		Console.Writeline ("Dog is Destroyed")
	End Sub
	
	
	'The Main Function
	Shared Sub Main() 
		Dim Jimmy, Jacky as Dog
		
		'Create the objects
		
		'This will call the default constructor
		Jimmy=new Dog
		
		'This will call the parameterized constructor
		Jacky=new Dog(10)
		
	End Sub
	
	'The Destruction will be done automatically, when
	'the program ends. This is done by the Garbage
	'Collector.
	
End Class



