import codewars_test as test

def alphabetized(s):
    return ''.join(sorted([i for i in s if i.isalpha()], key=str.lower))

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(alphabetized(""), "")
        test.assert_equals(alphabetized(" "), "")
        test.assert_equals(alphabetized(" a"), "a")
        test.assert_equals(alphabetized("a "), "a")
        test.assert_equals(alphabetized(" a "), "a")
        test.assert_equals(alphabetized("A b B a"), "AabB")
        test.assert_equals(alphabetized(" a b c d e f g h i j k l m n o p q r s t u v w x y z A B C D E F G H I J K L M N O P Q R S T U V W X Y Z"), "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ")
        test.assert_equals(alphabetized("!@$%^&*()_+=-`,"), "")
        test.assert_equals(alphabetized("The Holy Bible"), "BbeehHilloTy")
        test.assert_equals(alphabetized("CodeWars can't Load Today"), "aaaaCcdddeLnooorstTWy")