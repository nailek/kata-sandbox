Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](the-lift-kata.specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120	


Scenario: Add two zeroes
	Given the first number is 0
	And the second number is 0
	When the two numbers are added
	Then the result should be 0

Scenario: Asking lift down
	Given the lift is in floor 1
	When the lift is called from 0
	Then the lift goes to floor 0

Scenario: Asking lift up
	Given the lift is in floor 0
	When the lift is called from 2
	Then the lift goes to floor 2

Scenario: Asking lift up with status
	Given the lift is in floor 0
	When the lift is called from 2
	Then the lift goes to floor 2
	And traveled through floor/s 0,1