from re import fullmatch
import codewars_test as test

regex=r'^(?=.*\d)(?=.*[a-z].*)(?=.*[A-Z].*)[0-9a-zA-Z]{6,}$'

@test.describe("Tests")
def tests():

    def do_test(string : str, expected : bool):
        actual = bool(fullmatch(regex, string))
        test.assert_equals(actual, expected, f'for string "{string}"')

    @test.it('Sample tests')
    def sample_tests():
        do_test('fjd3IR9', True)
        do_test('ghdfj32', False)
        do_test('DSJKHD23', False)
        do_test('dsF43', False)
        do_test('4fdg5Fj3', True)
        do_test('DHSJdhjsU', False)
        do_test('fjd3IR9.;', False)
        do_test('fjd3  IR9', False)
        do_test('djI38D55', True)
        do_test('a2.d412', False)
        do_test('JHD5FJ53', False)
        do_test('!fdjn345', False)
        do_test('jfkdfj3j', False)
        do_test('123', False)
        do_test('abc', False)
        do_test('123abcABC', True)
        do_test('ABC123abc', True)
        do_test('Password123', True)