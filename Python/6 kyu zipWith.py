import codewars_test as test
from operator import add,sub,mul

# def zip_with(fn, a1, a2):
#     res = []
#     for i in range(0, min(len(a1), len(a2))):
#         res.append(fn(a1[i], a2[i]))
#     return res

# zip_with = lambda fn,a1,a2: [fn(a1[i], a2[i]) for i in range(min(len(a1), len(a2)))]

zip_with = lambda fn,a1,a2: list(map(fn, a1, a2))

@test.describe("Basic tests")
def _():
    @test.it("Basic tests")
    def _():
        test.assert_equals( zip_with( add, [0,1,2,3,4,5], [6,5,4,3,2,1] ), [6,6,6,6,6,6] )
        test.assert_equals( zip_with( add, [0,1,2,3,4  ], [6,5,4,3,2,1] ), [6,6,6,6,6  ] )
        test.assert_equals( zip_with( add, [0,1,2,3,4,5], [6,5,4,3,2  ] ), [6,6,6,6,6  ] )
        test.assert_equals( zip_with( pow, [10,10,10,10], [0,1,2,3] ), [1,10,100,1000] )
        test.assert_equals( zip_with( max, [1,4,7,1,4,7], [4,7,1,4,7,1] ), [4,7,7,4,7,7] )
        test.assert_equals( zip_with( add, [0,1,2,3], [0,1,2,3] ), [0,2,4,6] )
        test.assert_equals( zip_with( add, [0,1,2,3], [0,1,2,3] ), [0,2,4,6] )
        test.assert_equals( zip_with( pow, [10,10,10,10,10,10,10], [0,1,2,3,4,5,6] ), [1e0,1e1,1e2,1e3,1e4,1e5,1e6] )
        test.assert_equals( zip_with( sub, [0,1,2,3,4,5], [6,5,4,3,2,1] ), [-6,-4,-2,0,2,4] )
        test.assert_equals( zip_with( mul, ["a","b","c","d","e","f"], [6,5,4,3,2,1] ), ["aaaaaa","bbbbb","cccc","ddd","ee","f"] )