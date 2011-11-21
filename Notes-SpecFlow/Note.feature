Feature: Saving a Note
	In order not to forget things to do
	As a featherbrained
	I want to save notes to get them later on

@mytag
Scenario: Save button should get enabled when I write a note
	Given I am editing a new TODO note
	When I add "Fix the washing machine" to the note
	Then the save button should be enabled
