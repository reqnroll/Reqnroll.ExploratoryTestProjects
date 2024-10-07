Imports NUnit.Framework
Imports Reqnroll

Namespace StepDefinitions

    <Binding>
    Public Class CalculatorStepDefinitions

        <Given("the first number is {int}")>
        Public Sub GivenTheFirstNumberIs(number As Integer)
        End Sub

        <Given("the second number is {int}")>
        Public Sub GivenTheSecondNumberIs(number As Integer)
        End Sub

        <Reqnroll.When("the two numbers are added")>
        Public Sub WhenTheTwoNumbersAreAdded()
        End Sub

        <Reqnroll.Then("the result should be {int}")>
        Public Sub ThenTheResultShouldBe(result As Integer)
            Assert.AreEqual(result, result)
        End Sub
    
    End Class
End NameSpace