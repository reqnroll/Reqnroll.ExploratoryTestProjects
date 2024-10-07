Imports Xunit.Abstractions
Imports Reqnroll
Imports Xunit

Namespace StepDefinitions

    <Binding>
    Public Class CalculatorStepDefinitions

        Private ReadOnly _testOutputHelper As ITestOutputHelper

        Public Sub New(testOutputHelper As ITestOutputHelper)
            _testOutputHelper = testOutputHelper
        End Sub

        <Given("the first number is {int}")>
        Public Sub GivenTheFirstNumberIs(number As Integer)
        End Sub

        <Given("the second number is {int}")>
        Public Sub GivenTheSecondNumberIs(number As Integer)
        End Sub

        <Reqnroll.When("the two numbers are added")>
        Public Sub WhenTheTwoNumbersAreAdded()
            _testOutputHelper.WriteLine("numbers added")
        End Sub

        <Reqnroll.Then("the result should be {int}")>
        Public Sub ThenTheResultShouldBe(result As Integer)
            Assert.Equal(result, result)
        End Sub
    
    End Class
End NameSpace