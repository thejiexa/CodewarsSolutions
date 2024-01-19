import codewars_test as test

bumps = lambda road: "Woohoo!" if road.count("n") < 16 else "Car Dead"

@test.describe("Fixed Tests")
def fixed_tests():
    @test.it('Basic Test Cases')
    def basic_test_cases():
        test.assert_equals(bumps("n"), "Woohoo!")
        test.assert_equals(bumps("__nn_nnnn__n_n___n____nn__nnn"), "Woohoo!")
        test.assert_equals(bumps("nnn_n__n_n___nnnnn___n__nnn__"), "Woohoo!")
        test.assert_equals(bumps("_nnnnnnn_n__n______nn__nn_nnn"), "Car Dead")
        test.assert_equals(bumps("______n___n_"), "Woohoo!")
        test.assert_equals(bumps("nnnnnnnnnnnnnnnnnnnnn"), "Car Dead")