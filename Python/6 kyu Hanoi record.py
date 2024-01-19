import codewars_test as test

hanoi = lambda disks: 2 ** disks - 1

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it("Basic Tests")
    def basic_tests():
        test.assert_equals(hanoi(1), 1)
        test.assert_equals(hanoi(2), 3)
        test.assert_equals(hanoi(3), 7)
        test.assert_equals(hanoi(5), 31)
        test.assert_equals(hanoi(10), 1023)
        test.assert_equals(hanoi(20), 1048575)