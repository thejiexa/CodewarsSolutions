import codewars_test as test

def sum_of_sums(n):
    z_n = n * (n + 1) * (n + 2) // 6
    return (z_n * (z_n + 1)) // 2

@test.describe('Fixed tests')
def example_tests():

    @test.it('Example tests')
    def example_test_cases():
        test.assert_equals(sum_of_sums(3),55)
        test.assert_equals(sum_of_sums(5), 630)
        test.assert_equals(sum_of_sums(100), 14740530850)