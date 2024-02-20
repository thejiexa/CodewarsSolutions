import codewars_test as test

def variance(numbers): 
    mean = sum(numbers) / len(numbers)
    variance = sum([pow(i - mean, 2) for i in numbers]) / len(numbers)
    return variance
    
@test.describe('Example Tests')
def example_tests():
    test.assert_approx_equals(variance([1, 2, 2, 3]), 0.5)
    test.assert_approx_equals(variance([-10, 0, 10, 20, 30]), 200)
    test.assert_approx_equals(variance([8, 9, 10, 11, 12]), 2)
    test.assert_approx_equals(variance([1.5, 2.5, 4, 2, 1, 1]), 1.0833333333333333)