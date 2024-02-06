import codewars_test as test

def increment_string(string):
    chars = string.rstrip("0123456789")
    digits = string[len(chars):]
    return string + "1" if not digits else chars + str(int(digits) + 1).zfill(len(digits))

@test.describe("Basic Tests")
def basic_tests():
    
    @test.it("Basic Tests")
    def basic_tests():
        test.assert_equals(increment_string("foo"), "foo1")
        test.assert_equals(increment_string("foobar001"), "foobar002")
        test.assert_equals(increment_string("foobar1"), "foobar2")
        test.assert_equals(increment_string("foobar00"), "foobar01")
        test.assert_equals(increment_string("foobar99"), "foobar100")
        test.assert_equals(increment_string("foobar099"), "foobar100")
        test.assert_equals(increment_string("fo99obar99"), "fo99obar100")
        test.assert_equals(increment_string(""), "1")