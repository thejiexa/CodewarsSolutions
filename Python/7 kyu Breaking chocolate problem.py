import codewars_test as test

break_chocolate = lambda n, m: n * m - 1 if n * m > 0 else n * m

@test.describe("Sample Tests")
def basic_tests():
    @test.it("Tests")
    def it_1():
        test.assert_equals(break_chocolate(5, 5), 24)
        test.assert_equals(break_chocolate(7, 4), 27)
        test.assert_equals(break_chocolate(1, 1), 0)
        test.assert_equals(break_chocolate(0, 0), 0)
        test.assert_equals(break_chocolate(6, 1), 5)