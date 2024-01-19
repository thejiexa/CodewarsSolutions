import codewars_test as test

get_middle = lambda s: s[(len(s) - 1) // 2: len(s) // 2 + 1]

@test.describe("Basic Tests")
def basic_tests():
    
    @test.it("Basic Tests")
    def basic_tests():
        test.assert_equals(get_middle("test"),"es")
        test.assert_equals(get_middle("testing"),"t")
        test.assert_equals(get_middle("middle"),"dd")
        test.assert_equals(get_middle("A"),"A")
        test.assert_equals(get_middle("of"),"of")