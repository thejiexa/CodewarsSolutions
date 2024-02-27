import codewars_test as test

def get_number_word(n):
    return ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'][n]

def numbers_of_letters(n):
    if n == 4:
        return ['four']

    digits = list(str(n))
    words = [get_number_word(int(digit)) for digit in digits]
    word = ''.join(words)

    return [word] + numbers_of_letters(len(word))


@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(numbers_of_letters(1), ["one", "three", "five", "four"])
        test.assert_equals(numbers_of_letters(12), ["onetwo", "six", "three", "five", "four"])
        test.assert_equals(numbers_of_letters(37), ["threeseven", "onezero", "seven", "five", "four"])
        test.assert_equals(numbers_of_letters(311), ['threeoneone', 'oneone', 'six', 'three', 'five', 'four'])
        test.assert_equals(numbers_of_letters(999), ["nineninenine", "onetwo", "six", "three", "five", "four"])