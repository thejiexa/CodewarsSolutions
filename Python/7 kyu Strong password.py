import codewars_test as test
from re import fullmatch

def check_password(s):
    regex=r'^(?=.*\d)(?=.*[a-z].*)(?=.*[A-Z].*)(?=.*?[!@#$%^&*?])[0-9a-zA-Z!@#$%^&*?]{8,20}$'
    return "valid" if bool(fullmatch(regex, s)) else "not valid"
    
@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(check_password(""), "not valid")
        test.assert_equals(check_password("password"), "not valid")
        test.assert_equals(check_password("P1@p"), "not valid")
        test.assert_equals(check_password("P1@pP1@p"), "valid")
        test.assert_equals(check_password("P1@pP1@pP1@pP1@pP1@pP1@p"), "not valid")
        test.assert_equals(check_password("Paaaaaa222!!!"), "valid")