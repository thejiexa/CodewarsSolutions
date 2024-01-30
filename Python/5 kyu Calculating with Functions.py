import codewars_test as test

def zero(f = None): return int(f(0)) if f else 0 
def one(f = None): return int(f(1)) if f else 1 
def two(f = None): return int(f(2)) if f else 2 
def three(f = None): return int(f(3)) if f else 3 
def four(f = None): return int(f(4)) if f else 4 
def five(f = None): return int(f(5)) if f else 5 
def six(f = None): return int(f(6)) if f else 6 
def seven(f = None): return int(f(7)) if f else 7 
def eight(f = None): return int(f(8)) if f else 8 
def nine(f = None): return int(f(9)) if f else 9 

def plus(y): return lambda x: x + y
def minus(y): return lambda x: x - y
def times(y): return lambda x: x * y
def divided_by(y): return lambda x: x // y

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(seven(times(five())), 35)
        test.assert_equals(four(plus(nine())), 13)
        test.assert_equals(eight(minus(three())), 5)
        test.assert_equals(six(divided_by(two())), 3)