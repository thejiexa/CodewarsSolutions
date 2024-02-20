import codewars_test as test

def find_summands(n):
    return [(n**2 - n + 1) + 2 * i for i in range(n)]

@test.it('Basic Test Cases')
def basic_test_cases():
    test.assert_equals( len(find_summands(1)), 1, 'Incorrect length for n = 1')
    test.assert_equals( sum(find_summands(1)), 1, 'Incorrect sum for n = 1')
    test.assert_equals( len(find_summands(3)), 3, 'Incorrect length for n = 3')
    test.assert_equals( sum(find_summands(3)), 27, 'Incorrect sum for n = 3')
    test.assert_equals( not any( x % 2 == 0 for x in find_summands(3) ), True, 'All sums have to be odd')