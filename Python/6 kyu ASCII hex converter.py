import codewars_test as test

class Converter():
    # @staticmethod
    # def to_ascii(h):
    #     return bytes.fromhex(h).decode('ascii')
    
    # @staticmethod
    # def to_hex(s):
    #     return s.encode('utf-8').hex()
    
    to_ascii = lambda h: bytes.fromhex(h).decode('ascii')
    to_hex = lambda s: s.encode('utf-8').hex()

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        s = "Look mom, no hands"
        h = "4c6f6f6b206d6f6d2c206e6f2068616e6473"
        test.assert_equals(Converter.to_hex(s), h)
        test.assert_equals(Converter.to_ascii(h), s)
        test.assert_equals(Converter.to_hex(Converter.to_ascii(h)), h)
        test.assert_equals(Converter.to_ascii(Converter.to_hex(s)), s)