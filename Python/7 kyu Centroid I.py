import codewars_test as test

def centroid(c):
    return [round(i / len(c), 2) for i in list(map(sum,zip(*c)))]

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(centroid([[1,0,5], [0,1,5], [2,2,5]]), [1.0, 1.0, 5.0])
        test.assert_equals(centroid([[7,0,5], [3,1,5], [2,1,5]]), [4.0, 0.67, 5.0])