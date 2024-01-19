import codewars_test as test
from math import prod

def persistence(n):
    res = 0
    while n > 9:
        n = prod(map(int, str(n)))
        res += 1
    return res

@test.describe("Persistent Bugger.")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(persistence(39), 3)
        test.assert_equals(persistence(4), 0)
        test.assert_equals(persistence(25), 2)
        test.assert_equals(persistence(999), 4)