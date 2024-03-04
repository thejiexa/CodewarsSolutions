import codewars_test as test

def largest_radial_sum(arr, d):
    step = len(arr) // d
    return max([sum(arr[i::step]) for i in range(step)])

sample_test_cases = [
    #   arr               d  expected
    ([1, 2, 3, 4],        2,    6),
    ([1, 5, 6, 3, 4, 2],  3,   11),
    ([1, 1, 0],           1,    1),
]

@test.describe('Sample tests')
def sample_tests():
    for arr, d, expected in sample_test_cases:
        @test.it(f'largest_radial_sum({arr}, {d})')
        def _():
            test.assert_equals(largest_radial_sum(arr, d), expected)