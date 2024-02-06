import codewars_test as test

def encode(s):
    words_list = s[::-1].split(' ')
    res = [word[1:] + word[0] for word in words_list]
    return ' '.join(reversed(res))

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(encode("Hello World!"),"lleHo dlroW!")