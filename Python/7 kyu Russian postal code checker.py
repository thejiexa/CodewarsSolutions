import codewars_test as test
import re 

def zipvalidate(postcode):
    regex=r'^(?![05789])\d{6}$'
    return bool(re.fullmatch(regex, postcode))

@test.describe('Fixed Tests')
def fixed_tests():
    @test.it('Simple Cases')
    def example_cases():
        test.assert_equals(zipvalidate('198328'), True)
        test.assert_equals(zipvalidate('310003'), True)
        test.assert_equals(zipvalidate('424000'), True)
        test.assert_equals(zipvalidate('12A483'), False)
        test.assert_equals(zipvalidate('1@63'), False)
        test.assert_equals(zipvalidate('111'), False)
        test.assert_equals(zipvalidate('056879'), False)
        test.assert_equals(zipvalidate('1111111'), False)