import codewars_test as test

def sum_factorial(lst):
    factorial = lambda n: 1 if n < 2 else n * factorial(n - 1)
    return sum(factorial(i) for i in lst)

@test.describe("Sample Tests")
def sample_tests():
    
    @test.it("Small tests")
    def _():
        test.assert_equals(sum_factorial([4,6]), 744)
        test.assert_equals(sum_factorial([5,4,1]), 145)