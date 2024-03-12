import codewars_test as test

def fizz_buzz_custom(fizz="Fizz", buzz="Buzz", a=3, b=5):
    return [fizz + buzz if i % a == 0 and i % b == 0 else fizz if i % a == 0 else buzz if i % b == 0 else i for i in range(1 ,101)]

@test.describe('Example Tests')
def example_tests():

    @test.it("should return an array counting from 1 to 100, when the number is not divisible by 3 or 5")
    def example_test_case():
        test.assert_equals(fizz_buzz_custom()[3], 4)
        test.assert_equals(fizz_buzz_custom()[15], 16)

    @test.it("should return 'FizzBuzz' at the index of a number divisible by 3 and 5")
    def example_test_case():
        test.assert_equals(fizz_buzz_custom()[14], 'FizzBuzz')

    @test.it("should return 'Fizz' at the index of a number divisible by 3")
    def example_test_case():
        test.assert_equals(fizz_buzz_custom()[2], 'Fizz')        
        

    @test.it("should return 'Buzz' at the index of a number divisible by 5")
    def example_test_case():
        test.assert_equals(fizz_buzz_custom()[4], 'Buzz')  

    @test.it("should return custom strings in place of 'Fizz' and 'Buzz' if two strings are passed as parameters")
    def example_test_case():
        test.assert_equals(fizz_buzz_custom('Hey', 'There')[14], 'HeyThere')  
        test.assert_equals(fizz_buzz_custom('Lol', 'Zor')[2], 'Lol')  
        test.assert_equals(fizz_buzz_custom('Rainbow', 'Pony')[4], 'Pony')  
        
    @test.it("should return custom strings at custom divisions if 2 strings and 2 intgers are passed as parameters")
    def example_test_case():
        test.assert_equals(fizz_buzz_custom("What's ", "up?", 2, 7)[97], "What's up?")
        test.assert_equals(fizz_buzz_custom("Sixty", "Five", 6, 11)[65], "SixtyFive")
        test.assert_equals(fizz_buzz_custom("Happy", "Cow", 13, 27)[98], 99)