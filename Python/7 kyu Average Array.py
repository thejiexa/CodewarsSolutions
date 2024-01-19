import codewars_test as test
from itertools import zip_longest

def avg_array(arrays):
    return [sum(i) / len(arrays) for i in zip(*arrays)]

def test_approx_equals(act, exp, error=1e-8):
    for a, e in zip_longest(act, exp, fillvalue=float("inf")):
        if abs(e - a) > abs(e) * error:
            test.fail("Test failed!\nYour result %s should be close to the expected result %s" % (act, exp))
            break
    else:
        test.pass_()
        
@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test_approx_equals(avg_array([[1, 2, 3, 4], [5, 6, 7, 8]]), [3, 4, 5, 6])
        test_approx_equals(avg_array([[2, 3, 9, 10, 7], [12, 6, 89, 45, 3], [9, 12, 56, 10, 34], [67, 23, 1, 88, 34]]), [22.5, 11, 38.75, 38.25, 19.5])
        test_approx_equals(avg_array([[2, 5, 4, 3, 19],[2, 5, 6, 7, 10]]), [2, 5, 5, 5, 14.5])
        test_approx_equals(avg_array([[1.2, 8.521, 0.4, 3.14, 1.9], [2, 4.5, 3.75, 0.987, 1.0]]), [1.6, 6.5105, 2.075, 2.0635, 1.45])
        test_approx_equals(avg_array([[2,5,-4,3,-19],[-2,-5,6,7,10]]), [0,0,1,5,-4.5])
        test_approx_equals(avg_array([[-2,-18,-45,-10],[0,-45,-20,-34]]), [-1,-31.5,-32.5,-22])