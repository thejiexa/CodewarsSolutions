import codewars_test as test

# def longest(a1, a2):
#     return "".join(sorted((set(a1 + a2))))

longest = lambda a1, a2:"".join(sorted((set(a1 + a2))))

@test.describe("longest")
def tests():
    @test.it("basic tests")
    def basics():
        test.assert_equals(longest("aretheyhere", "yestheyarehere"), "aehrsty")
        test.assert_equals(longest("loopingisfunbutdangerous", "lessdangerousthancoding"), "abcdefghilnoprstu")
        test.assert_equals(longest("inmanylanguages", "theresapairoffunctions"), "acefghilmnoprstuy")