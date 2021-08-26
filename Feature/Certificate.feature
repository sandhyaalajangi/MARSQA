Feature: certifications
	As  a seller
	I want the feature to add  a certifications to my profile
	so that
	people looking for certifications can look into my details
	Acceptance criteria 
	Seller is able to add/edit the  certifications

@ignore @web
Scenario: Add certifications Successfully
  Given The seller should able to enter all fields in certifications
	And The seller should able to enter cerificate,certified from ,select "Year"from the dropdown list
	When click on "Addnew" action button
	Then the seller can able to see details has been added to your certificates successful message on top right corner


	@ignore @web
Scenario: Add certifications unSuccessfully
  Given The seller didnot  enter few fields in certifications
	And The seller didnot enter cerificate orcertified from or didnot select "Year"from the dropdown list
	When click on "Addnew" action button
	Then the seller can able to see error message "enter cerificate,certified from ,Year"


	@ignore @web
Scenario: update certifications 
  Given The seller should able to update certifications
	And The seller should able to update  by clicking "edit" symbol for any changes in cerificate,certified from ,select "Year"from the dropdown list
	When click on "update" action button
	Then the seller can able to see "details has been updated to your certifications". successful message on top right corner



	@ignore @web
Scenario: Delete certifications Successfully
  Given The seller should able to delete in certifications
	And The seller should able to enter cerificate,certified from ,select "Year"from the dropdown list
	When click on Delete symbol
	Then the seller can able to see "details has been deleted from your certications". successful message on top right corner



