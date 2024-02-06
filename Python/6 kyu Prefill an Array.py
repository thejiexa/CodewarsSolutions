import codewars_test as test

def prefill(n,v=None):
    try:
        return [v] * int(n)
    except: 
        f"{n} is invalid"

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(prefill(3,1), [1,1,1])
        test.assert_equals(prefill(2,'abc'), ['abc','abc'])
        test.assert_equals(prefill('1',1), [1])
        test.assert_equals(prefill(3, prefill(2,'2d')), [['2d','2d'],['2d','2d'],['2d','2d']])
        test.assert_equals(prefill(0), [])
        try:
            prefill('xyz', 1)
        except TypeError as err:
            test.assert_equals(str(err), "xyz is invalid")