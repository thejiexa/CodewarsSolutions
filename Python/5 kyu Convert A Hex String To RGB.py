import codewars_test as test

hex_string_to_RGB = lambda hex_string: {'r':int(hex_string[1:3], 16), 'g': int(hex_string[3:5], 16), 'b': int(hex_string[5:7], 16)}

# def hex_string_to_RGB(hex_string): 
#     return {'r':int(hex_string[1:3], 16), 'g': int(hex_string[3:5], 16), 'b': int(hex_string[5:7], 16)}

@test.describe('Example Tests')
def example_tests():
    test.assert_equals(hex_string_to_RGB("#FF9933"), {'r':255, 'g':153, 'b':51})
    test.assert_equals(hex_string_to_RGB("#beaded"), {'r':190, 'g':173, 'b':237})
    test.assert_equals(hex_string_to_RGB("#000000"), {'r':0, 'g':0, 'b':0})
    test.assert_equals(hex_string_to_RGB("#111111"), {'r':17, 'g':17, 'b':17})
    test.assert_equals(hex_string_to_RGB("#Fa3456"), {'r':250, 'g':52, 'b':86})