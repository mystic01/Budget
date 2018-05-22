Feature: BudgetAdd

@mytag
Scenario: Add first budget
	When I input month "2018-02" and amount 500
	Then the result should be "2018-02" and "500" on the screen
