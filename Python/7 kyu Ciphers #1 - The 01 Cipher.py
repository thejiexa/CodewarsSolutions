import codewars_test as test

def encode(s):
    letters = "abcdefghijklmnopqrstuvwxyz"
    res = [("0" if letters.find(i) % 2 == 0 else "1") if i in letters else i for i in s.lower()]
    return "".join(res)

@test.describe('Basic tests')
def basic_tests():
    @test.it("Basic Tests")
    def basic_tests():
        test.assert_equals(encode("Hello World!"),"10110 00111!")