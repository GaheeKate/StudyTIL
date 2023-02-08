# Javascript : Cypress

Today I studied Cypress


- Unit Testing
  - Unit Testing involves testing your application on a per function level. Unit testing is testing the smallest testable unit of an application.
- Integration Testing
  - Integration Testing "…involves testing a particular functionality—usually referred to as a module—that has dependencies on another functionality. a type of software testing in which the different units, modules or components of a software application are tested as a combined entity
  - Big Bang Testing
  - Top-down
  - Bottom up
  - Sandwich Testing(Hybrid)

- End-to-end Testing (e2e)
  - "End-to-end testing verifies that your software works correctly from the beginning to the end of a particular user flow.
  - User testing: getting a human to execute a common user action testing task.
  - Automated testing: getting software to execute a common user action testing task.

- Cypress Automated End-to-end Testing
  - A testing framework built with JavaScript

- describe, it, expect, to. equal
```
describe('My First Test', () => {
  it('Does not do much!', () => {
    expect(true).to.equal(true)
  })
})
```
- cy.visit
> cy.visit('https://example.cypress.io')
- cy.contains().
> cy.contains('type')
- .click()
> cy.contains('type').click()
- Make an assertion: .should()
> cy.url().should('include', '/commands/actions')
- cy.get() to select an element based on its class. Then we can use the .type() command to enter text into the selected input