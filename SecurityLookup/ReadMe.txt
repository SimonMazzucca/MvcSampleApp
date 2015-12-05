Notes
-----

This is a sample app I had to do for an interview.
It is a bare-bone MVC app with AJAX calls to get data.


Relevant Files
--------------

Index.cshtml
•	Since the template project comes with references to the bootstrap css and js files I made the two panels
	col-lg-4 and col-lg-8. In full screen they will be side by side (first panel using up 1/3 of available
	space, second panel using 2/3), but on smaller screens they will be automatically rearranged on top of each other.
•	The Submit button is hooked to lookupSecurity() in home.js

home.js
•	Upon loading the form, focus the first input box
•	lookupSecurity() calls the GetSecurityTable action with text in input boxes as parameters
•	lookupSecuritySuccess():data returned (partial view) is used to replace content of securityTableContainer
•	success and error functions are refactored outside of parameters definition, so they can be easily extended in the future

HomeController.cs
Contains two actions:
•	Default Index action for initial load
•	Action to return Partial View SecurityTable. The view returned is used to replace the whole default empty table

HomeModel.cs
•	One method: LoadSecurities()
•	The logic implemented here returns either an exact match for the symbol (using the first input box) or any partial
	match in all other 4 fields (using the second input box). 
•	Possible improvement: add check-box to OR results (current implementation) or to AND them  

Site.css
•	#securityLookupTable and #submitButton apply to those 2 elements and those 2 only
•	.form-label and .result-header apply to any element of that class
